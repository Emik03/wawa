// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Callbacks.Internals;

/// <summary>Contains static methods able to be accessed from anywhere within this library.</summary>
static class Globals
{
    /// <summary>Contains cached elements.</summary>
    /// <typeparam name="T">The type of item.</typeparam>
    public static class DelegateLot<T>
        where T : Delegate
    {
        /// <summary>Gets the function that returns the parameter.</summary>
        public static Func<T, Delegate> Id => x => x;
    }

    /// <summary>Contains cached elements.</summary>
    /// <typeparam name="T">The type of item.</typeparam>
    public static class Lot<T>
    {
        /// <summary>Gets the function that returns the parameter.</summary>
        public static Func<T, T> Id => x => x;

        /// <summary>Gets the empty set.</summary>
        public static ReadOnlyCollection<T> Empty { [Pure] get; } = new(new T[] { });
    }

    /// <summary>Gets the <see cref="AssemblyName"/> of the caller that invoked the method calling this.</summary>
    /// <remarks><para>This is used by the library to log itself, and obtain information about callers.</para></remarks>
    [NotNull] // ReSharper disable once NullableWarningSuppressionIsUsed
    static AssemblyName Caller => new StackFrame(3).GetMethod().ReflectedType?.Assembly.GetName()!;

    /// <summary>Gets the name of <see cref="Caller"/>.</summary>
    [NotNull]
    static string Who => Caller.Name;

    /// <summary>Gets the version of <see cref="Caller"/>.</summary>
    [NotNull]
    static string Which =>
        Caller.Version is var ver && ver is { Minor: 0, Build: 0, Revision: 0 } ? $"v{ver.Major}" :
        ver is { Build: 0, Revision: 0 } ? $"v{ver.Major}.{ver.Minor}" :
        ver is { Revision: 0 } ? $"v{ver.Major}.{ver.Minor}.{ver.Build}" :
        $"v{ver.Major}.{ver.Minor}.{ver.Build}.{ver.Revision}";

    /// <summary>Gets a value indicating whether the runtime is in-game.</summary>
    /// <remarks><para>Opposite of <see cref="Application.isEditor"/>, but as a pure getter.</para></remarks>
    public static bool IsKtane { [Pure] get; } = !Application.isEditor;

    /// <summary>Converts this instance to the core module.</summary>
    /// <param name="that">The object to convert.</param>
    /// <returns><paramref name="that"/> <see langword="as"/> <see cref="CoreBehaviour"/>.</returns>
    // ReSharper disable SuspiciousTypeConversion.Global
    [NotNull, Pure]
    public static CoreBehaviour Core([NotNull] this MonoBehaviour that) => (CoreBehaviour)(object)that;

    /// <summary>Converts this instance to the unity module.</summary>
    /// <param name="that">The object to convert.</param>
    /// <returns><paramref name="that"/> <see langword="as"/> <see cref="MonoBehaviour"/>.</returns>
    [NotNull, Pure]
    public static MonoBehaviour Core([NotNull] this CoreBehaviour that) => (MonoBehaviour)(object)that;

    /// <summary>Gets the path of the current <see cref="Transform"/>.</summary>
    /// <param name="current">The current <see cref="Transform"/>.</param>
    /// <returns>The path in the hierarchy to the parameter <paramref name="current"/>.</returns>
    [NotNull, Pure]
    public static string GetPath([NotNull] this Transform current) =>
        $"{(current.parent ? current.parent.GetPath() : "")}/{current.name}";

    /// <summary>Gets the path of the current <see cref="Component"/>.</summary>
    /// <param name="component">The current <see cref="Component"/>.</param>
    /// <param name="label">An additional label to attach to the end.</param>
    /// <returns>The path in the hierarchy to the parameter <paramref name="component"/>.</returns>
    [NotNull, Pure]
    public static string GetPath([NotNull] this Component component, [CanBeNull] string label) =>
        $"[{Who} {Which}] {component.transform.GetPath()}/{component.GetType().Name}.{label}";
}
