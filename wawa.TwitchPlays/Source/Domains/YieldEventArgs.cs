// SPDX-License-Identifier: MPL-2.0
namespace Wawa.TwitchPlays.Domains;

/// <summary>An <see cref="EventArgs"/> for yielded items.</summary>
[PublicAPI]
public sealed class YieldEventArgs : EventArgs,
    ICloneable,
    IEquatable<YieldEventArgs>,
    IEqualityComparer<YieldEventArgs>
{
    /// <summary>Initializes a new instance of the <see cref="YieldEventArgs"/> class.</summary>
    /// <param name="o">The value to store.</param>
    internal YieldEventArgs([AllowNull, CanBeNull] Instruction o) => Query = o;

    /// <summary>Gets the value that was yielded.</summary>
    /// <remarks><para>
    /// A <see langword="null"/> <see cref="Instruction"/> is a completely valid query,
    /// so this value is therefore around a <see cref="Maybe{T}"/>.
    /// </para></remarks>
    public Maybe<Instruction> Query { [Pure] get; }

    /// <inheritdoc/>
    [Pure]
    public object Clone() => new YieldEventArgs(Query.Value);

    /// <inheritdoc/>
    [Pure]
    public bool Equals(YieldEventArgs x, YieldEventArgs y) => x == y;

    /// <inheritdoc/>
    [Pure]
    public int GetHashCode([AllowNull, CanBeNull] YieldEventArgs obj) => obj?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    [Pure]
    public bool Equals(YieldEventArgs other) => this == other;

    /// <summary>Determines whether both instances point to the same component.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both of them point to the same component, otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool operator ==(
        [AllowNull, CanBeNull] YieldEventArgs left,
        [AllowNull, CanBeNull] YieldEventArgs right
    ) =>
        left is null ? right is null : right is not null && left.Query == right.Query;

    /// <summary>Determines whether both instances do not point to the same component.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both of them do not point to the same component,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool operator !=(
        [AllowNull, CanBeNull] YieldEventArgs left,
        [AllowNull, CanBeNull] YieldEventArgs right
    ) =>
        !(left == right);

    /// <inheritdoc/>
    [Pure]
    public override bool Equals([AllowNull] object obj) => Equals(obj as YieldEventArgs);

    /// <inheritdoc/>
    [Pure]
    public override int GetHashCode() => Query.GetHashCode();

    /// <summary>Uses <see cref="Stringifier.Stringify{T}(T, bool, bool)"/> on <see cref="Query"/>.</summary>
    /// <returns>A <see cref="string"/> representation of <see cref="Query"/>.</returns>
    [Pure]
    public override string ToString() => Stringifier.Stringify(Query);
}
