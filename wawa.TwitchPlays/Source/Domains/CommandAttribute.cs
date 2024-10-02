// SPDX-License-Identifier: MPL-2.0
namespace Wawa.TwitchPlays.Domains;

/// <summary>
/// An <see cref="Attribute"/> to attach to methods to signify that
/// the command should be processed by <see cref="Twitch{T}"/>.
/// </summary>
/// <param name="prefix">The prefix of this command.</param>
/// <param name="priority">The priority of the command. A higher value means it will be evaluated sooner.</param>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true), CLSCompliant(false), PublicAPI]
public sealed class CommandAttribute([AllowNull, CanBeNull] string prefix = null, int priority = 0) : Attribute,
    ICloneable,
    IEquatable<CommandAttribute>,
    IEqualityComparer<CommandAttribute>
{
    /// <summary>Indicates that there is no prefix, and that the command is inferred by the method name.</summary>
    [NotNull]
    const string Null = "<inferred>";

    /// <summary>Gets the priority. Higher means evaluated sooner.</summary>
    [PublicAPI]
    public int Priority { [Pure] get; } = priority;

    /// <summary>Gets the prefix of this command. If <see cref="Maybe.None{T}"/>, the prefix is inferred.</summary>
    [PublicAPI]
    public Maybe<string> Prefix { [Pure] get; } = prefix;

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public object Clone() => new CommandAttribute(Prefix.Value, Priority);

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public bool Equals(CommandAttribute x, CommandAttribute y) => x == y;

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public int GetHashCode([AllowNull, CanBeNull] CommandAttribute obj) => obj?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public bool Equals([AllowNull] CommandAttribute other) => this == other;

    /// <summary>Determines whether both have the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both of them contain the same values,
    /// otherwise <see langword="false"/>.</returns>
    [PublicAPI, Pure]
    public static bool operator ==(
        [AllowNull, CanBeNull] CommandAttribute left,
        [AllowNull, CanBeNull] CommandAttribute right
    ) =>
        left?.Prefix == right?.Prefix && left?.Priority == right?.Priority;

    /// <summary>Determines whether both do not have the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both of them do not contain the same values,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [PublicAPI, Pure]
    public static bool operator !=(
        [AllowNull, CanBeNull] CommandAttribute left,
        [AllowNull, CanBeNull] CommandAttribute right
    ) =>
        !(left == right);

    /// <inheritdoc/>
    [PublicAPI, Pure] // ReSharper disable once AssignNullToNotNullAttribute
    public override bool Equals([AllowNull] object obj) => Equals(obj as CommandAttribute);

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public override int GetHashCode() => Prefix.GetHashCode() + Priority;

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public override string ToString() => Prefix.UnwrapOr(Null);
}
