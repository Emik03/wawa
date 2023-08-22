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
    /// <remarks><para>
    /// This API primarily exists for if you already have a reference to Assembly-CSharp.dll, typically involving using
    /// a class library to allow such a reference. If you do not use a class library, then this method can be ignored in
    /// favor of wrappers such as <see cref="Lookup"/>, <see cref="Missions"/>, or <see cref="Preferences"/>.
    /// </para><para>
    /// Unlike the other APIs exposed by these libraries, the return value of <typeparamref name="TResult"/>'s
    /// nullability may not be trusted if it is a reference type or <see cref="Nullable{T}"/>, even when
    /// <paramref name="def"/> itself is non-null. As such, enable nullable reference types or use
    /// <see cref="Maybe.AsMaybe{T}"/> to enforce type safety.
    /// </para><para>
    /// To guarantee the DDL pattern, ensure that <typeparamref name="T"/> and <typeparamref name="TResult"/> are not
    /// from a potentially unavailable reference, and avoid creating closures that capture state without first
    /// downcasting to <see cref="object"/> beforehand, and recasting within the closure.
    /// </para><para>
    /// Never assume functions or fields pulled directly from Assembly-CSharp.dll are safe and guaranteed non-null.
    /// </para></remarks>
    /// <typeparam name="T">The context item, be sure that this doesn't come from the game.</typeparam>
    /// <typeparam name="TResult">The type of the return, be sure that this doesn't come from the game.</typeparam>
    /// <param name="context">The context element to pass into the callback.</param>
    /// <param name="factory">The factory containing one or more references that may be unavailable.</param>
    /// <param name="def">The value to return instead, since <paramref name="factory"/> is for in-game only.</param>
    /// <returns>The value from <paramref name="factory"/>, or <see langword="default" />.</returns>
    [CanBeNull, PublicAPI]
    [return: AllowNull]
    public static TResult FromGame<T, TResult>(
        [AllowNull, CanBeNull] T context,
        [InstantHandle, NotNull, RequireStaticDelegate(IsError = true)] Converter<T, TResult> factory,
        [AllowNull, CanBeNull] TResult def = default
    ) => // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
        IsKtane ? factory(context) : def;
}
