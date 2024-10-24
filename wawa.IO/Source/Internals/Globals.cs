// SPDX-License-Identifier: MPL-2.0
namespace wawa.IO.Internals;

/// <summary>Contains static methods able to be accessed from anywhere within this library.</summary>
static class Globals
{
    /// <summary>The default string comparison throughout the library.</summary>
    internal const StringComparison Ordinal = StringComparison.Ordinal;

    [NotNull]
    static readonly Dictionary<int, IDictionary> s_cache = [];

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
        catch (Exception ex)
        {
            // CANNOT BE 'WHEN' CLAUSE: .NET Framework 3.5 does not support IL metadata 'filter'.
#pragma warning disable RCS1236
            if (!ex.IsIO())
                throw;
#pragma warning restore RCS1236
            AssemblyLog($"Caught the {ex.GetType().Name} while performing IO.", LogType.Warning);
        }
    }

    /// <summary>Compares two strings based on <see cref="StringComparison.Ordinal"/>.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>Whether the two values are the same based on <see cref="StringComparison.Ordinal"/>.</returns>
    [Pure]
    internal static bool OrdinalEquals(
        [AllowNull, CanBeNull] this string left,
        [AllowNull, CanBeNull] in string right
    ) =>
        string.Equals(left, right, Ordinal);

    /// <summary>Computes an expensive computation, then caches it in subsequent calls.</summary>
    /// <remarks><para>This method assumes that every caller member's name is unique from each other.</para></remarks>
    /// <typeparam name="T">The type of the parameter.</typeparam>
    /// <typeparam name="TResult">The type of return.</typeparam>
    /// <param name="key">The parameter of the method.</param>
    /// <param name="ktane">The expensive callback.</param>
    /// <param name="editor">The expensive callback exclusive to the editor.</param>
    /// <param name="caller">The caller member name.</param>
    /// <param name="overriden">The name of the factory to invoke.</param>
    /// <returns>The value from the first time <paramref name="ktane"/> was invoked.</returns>
    [CanBeNull, Pure]
    [return: AllowNull]
    internal static TResult Get<T, TResult>(
        [NotNull] this T key,
        [InstantHandle, NotNull, RequireStaticDelegate(IsError = true)] in Converter<T, TResult> ktane,
        [AllowNull, CanBeNull, InstantHandle, RequireStaticDelegate(IsError = true)] in Converter<T, TResult> editor =
            null,
        [CallerLineNumber, NonNegativeValue] int caller = 0,
        [CallerMemberName, CanBeNull] string overriden = ""
    )
        where TResult : class
    {
        KeyValuePair<T, Type> k = new(key, typeof(TResult));

        if (!s_cache.TryGetValue(caller, out var dictionary))
        {
            var first = Invoke(key, ktane, editor, overriden);

            s_cache[caller] =
                new Dictionary<KeyValuePair<T, Type>, object>(TypePairEqualityComparer<T>.Instance) { [k] = first };

            return first;
        }

        if ((Dictionary<KeyValuePair<T, Type>, object>)dictionary is var cast && cast.TryGetValue(k, out var cached))
            return (TResult)cached;

        var value = Invoke(key, ktane, editor, overriden);
        cast[k] = value;
        return value;
    }

    /// <summary>
    /// Runs and returns the parameter, and catches various exception types found in IO operations.
    /// A caught <see cref="Exception"/> will <see langword="return"/> <see langword="default"/>.
    /// </summary>
    /// <typeparam name="T">The type of parameter.</typeparam>
    /// <typeparam name="TResult">The type of return.</typeparam>
    /// <param name="item">The item to pass in.</param>
    /// <param name="func">The name to run.</param>
    /// <param name="force">Whether to force execution regardless if in editor or not.</param>
    /// <returns>
    /// The returned value of <paramref file="func"/>, or <see langword="default"/>
    /// in the event of an <see cref="Exception"/> related to files.
    /// </returns>
    [CanBeNull]
    [return: AllowNull]
    internal static TResult SuppressIO<T, TResult>(
        [DisallowNull, NotNull] this T item,
        [InstantHandle, NotNull] in Func<T, TResult> func,
        [InstantHandle] bool force = false
    )
    {
        if (!force && !IsKtane && !IsRewritten)
            return default;

        try
        {
            return func(item);
        }
        catch (Exception ex)
        {
            // CANNOT BE 'WHEN' CLAUSE: .NET Framework 3.5 does not support IL metadata 'filter'.
#pragma warning disable RCS1236
            if (!ex.IsIO())
                throw;
#pragma warning restore RCS1236
            AssemblyLog($"Caught the {ex.GetType().Name} while performing IO. Returning no value.", LogType.Warning);
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

    [CanBeNull, Pure]
    [return: AllowNull]
    static TResult Invoke<T, TResult>(
        [NotNull] in T key,
        [InstantHandle, NotNull, RequireStaticDelegate(IsError = true)] in Converter<T, TResult> factory,
        [AllowNull, CanBeNull, InstantHandle, RequireStaticDelegate(IsError = true)] in Converter<T, TResult> editor,
        [CanBeNull] string overriden
    )
        where TResult : class =>
        !IsKtane && !IsRewritten ? editor?.Invoke(key) :
        overriden is null ? factory(key) : FromGame(key, factory, null, overriden);
}
