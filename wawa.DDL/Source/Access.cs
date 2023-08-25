// SPDX-License-Identifier: MPL-2.0
namespace Wawa.DDL;

/// <summary>A class for accessing things from the game.</summary>
[PublicAPI]
public static class Access
{
    /// <summary>Gets a value indicating whether the runtime is in-game.</summary>
    /// <remarks><para>Opposite of <see cref="Application.isEditor"/>, but as a pure getter.</para></remarks>
    [PublicAPI]
    public static bool IsKtane { [Pure] get; } = !Application.isEditor;

    /// <summary>Method for obtaining something from the game, ensuring that the Unity editor stays happy.</summary>
    /// <typeparam name="T">The context item, be sure that this doesn't come from the game.</typeparam>
    /// <typeparam name="TResult">The type of the return, be sure that this doesn't come from the game.</typeparam>
    /// <param name="context">The context element to pass into the callback.</param>
    /// <param name="factory">The factory containing the game data.</param>
    /// <param name="def">The default value.</param>
    /// <returns>The value from <paramref name="factory"/>, or <see langword="default" />.</returns>
    [PublicAPI]
    public static TResult FromGame<T, TResult>(
        [AllowNull, CanBeNull] T context,
        [InstantHandle, NotNull, RequireStaticDelegate(IsError = true)] Converter<T, TResult> factory,
        [AllowNull, CanBeNull] TResult def = default
    ) => // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
        IsKtane ? factory(context) : def;
}
