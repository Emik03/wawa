// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Callbacks.Internals;

/// <summary>Contains static methods able to be accessed from anywhere within this library.</summary>
static class Globals
{
    /// <summary>Gets a value indicating whether the runtime is in-game.</summary>
    /// <remarks><para>Opposite of <see cref="Application.isEditor"/>, but as a pure getter.</para></remarks>
    public static bool IsKtane { [Pure] get; } = !Application.isEditor;

    /// <summary>Converts this instance to the core module.</summary>
    /// <param name="that">The object to convert.</param>
    /// <returns><paramref name="that"/> as <see cref="CoreBehaviour"/>.</returns>
    [return: AllowNull, NotNullIfNotNull(nameof(that))]
    [CanBeNull, Pure] // ReSharper disable once SuspiciousTypeConversion.Global
    public static CoreBehaviour? Core([AllowNull, CanBeNull] this MonoBehaviour that) => (CoreBehaviour)(object)that;

    /// <summary>Converts this instance to the unity module.</summary>
    /// <param name="that">The object to convert.</param>
    /// <returns><paramref name="that"/> as <see cref="MonoBehaviour"/>.</returns>
    [return: AllowNull, NotNullIfNotNull(nameof(that))]
    [CanBeNull, Pure] // ReSharper disable once SuspiciousTypeConversion.Global
    public static MonoBehaviour? Core([AllowNull, CanBeNull] this CoreBehaviour that) => (MonoBehaviour)(object)that;
}
