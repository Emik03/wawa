// SPDX-License-Identifier: MPL-2.0
global using Newtonsoft.Json;
global using Newtonsoft.Json.Converters;
global using Newtonsoft.Json.Linq;
global using Wawa.Optionals;
global using static System.Reflection.BindingFlags;
global using static Wawa.DDL.Access;
global using static Wawa.DDL.Lookup;
global using static Wawa.IO.Internals.Globals;
global using static Wawa.IO.PathFinder;
global using Formatting = Newtonsoft.Json.Formatting;

namespace Wawa.IO.Internals;

/// <summary>Contains static methods able to be accessed from anywhere within this library.</summary>
static class Globals
{
    /// <summary>The default string comparison throughout the library.</summary>
    internal const StringComparison Ordinal = StringComparison.Ordinal;

    [NotNull]
    static readonly Dictionary<MethodBase, IDictionary> s_cache = new();

    /// <summary>Runs and catches various exception types found in IO operations.</summary>
    /// <typeparam name="T">The type of parameter.</typeparam>
    /// <param name="item">The item to pass in.</param>
    /// <param name="action">The name to run.</param>
    internal static void SuppressIO<T>(this T item, [InstantHandle, NotNull] in Action<T> action)
    {
        try
        {
            action(item);
        }
        catch (Exception ex) when (ex.IsIO())
        {
            AssemblyLog($"Caught error of type {ex.GetType().Name}.");
        }
    }

    /// <summary>Compares two strings based on <see cref="StringComparison.Ordinal"/>.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>Whether the two values are the same based on <see cref="StringComparison.Ordinal"/>.</returns>
    [Pure]
    internal static bool
        OrdinalEquals([AllowNull, CanBeNull] this string left, [AllowNull, CanBeNull] in string right) =>
        string.Equals(left, right, Ordinal);

    /// <summary>Computes an expensive computation, then caches it in subsequent calls.</summary>
    /// <typeparam name="T">The type of the parameter.</typeparam>
    /// <typeparam name="TResult">The type of return.</typeparam>
    /// <param name="key">The parameter of the method.</param>
    /// <param name="factory">The expensive callback.</param>
    /// <param name="editor">The expensive callback exclusive to the editor.</param>
    /// <returns>The value from the first time <paramref name="factory" /> was invoked.</returns>
    [CanBeNull, Pure]
    [return: AllowNull]
    internal static TResult Get<T, TResult>(
        [NotNull] this T key,
        [InstantHandle, NotNull] in Func<T, TResult> factory,
        [AllowNull, CanBeNull, InstantHandle, RequireStaticDelegate(IsError = true)] in Func<T, TResult> editor = null
    )
        where T : class
        where TResult : class
    {
        var caller = new StackFrame(1).GetMethod();
        var dict = s_cache.TryGetValue(caller, out var d) ? d : s_cache[caller] = new Dictionary<T, TResult>();

        if (dict.Contains(key))
            return dict[key] as TResult;

        var value = IsKtane ? factory(key) : editor?.Invoke(key);
        dict[key] = value;

        return value;
    }

    /// <summary>
    /// Runs and returns the parameter, and catches various exception types found in IO operations.
    /// A caught <see cref="Exception" /> will <see langword="return" /> <see langword="default" />.
    /// </summary>
    /// <typeparam name="T">The type of parameter.</typeparam>
    /// <typeparam name="TResult">The type of return.</typeparam>
    /// <param name="item">The item to pass in.</param>
    /// <param name="func">The name to run.</param>
    /// <param name="force">Whether to force execution regardless if in editor or not.</param>
    /// <returns>
    /// The returned value of <paramref file="func" />, or <see langword="default" />
    /// in the event of an <see cref="Exception" /> related to files.
    /// </returns>
    [CanBeNull]
    [return: AllowNull]
    internal static TResult SuppressIO<T, TResult>(
        [DisallowNull, NotNull] this T item,
        [InstantHandle, NotNull] in Func<T, TResult> func,
        [InstantHandle] in bool force = false
    )
    {
        if (!force && !IsKtane)
            return default;

        try
        {
            return func(item);
        }
        catch (Exception ex) when (ex.IsIO())
        {
            AssemblyLog($"Caught error of type {ex.GetType().Name}, returning no value.");

            return default;
        }
    }

    [Pure]
    static bool IsIO(this Exception ex) =>
        ex is ArgumentOutOfRangeException or
            BadImageFormatException or
            FileLoadException or
            IOException or
            JsonException or
            InvalidOperationException or
            NotSupportedException or
            UnauthorizedAccessException;
}
