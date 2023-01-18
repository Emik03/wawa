// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Modules;

/// <summary>Encapsulation of status conditions for a <see cref="ModdedModule"/>.</summary>
[PublicAPI]
public sealed class State : ICloneable, IEquatable<State>, IEqualityComparer<State>
{
    [NotNull]
    const string Prefix = "id: ";

    [NotNull]
    static readonly Dictionary<string, int> s_ids = new(StringComparer.Ordinal);

    [NotNull]
    readonly string _name;

    /// <summary>Initializes a new instance of the <see cref="State"/> class.</summary>
    /// <param name="name">
    /// The <see cref="string"/> containing the module id which is used to assign <see cref="Id"/>.
    /// </param>
#pragma warning disable CA1854
    internal State([NotNull] string name) => Id = s_ids.ContainsKey(_name = name) ? ++s_ids[name] : s_ids[name] = 1;
#pragma warning restore CA1854

    /// <summary>
    /// Gets or sets a value indicating whether the module has ever called <see cref="ModdedModule.Strike"/>.
    /// </summary>
    [PublicAPI]
    public bool HasStruck { [Pure] get; set; }

    /// <summary>Gets a value indicating whether the module is solved.</summary>
    [PublicAPI]
    public bool IsSolved { [Pure] get; internal set; }

    /// <summary>Gets the unique module id of this module type, primarily used in logging.</summary>
    [NonNegativeValue, PublicAPI]
    public int Id { [Pure] get; }

    /// <summary>
    /// Gets or sets a value indicating whether the module has thrown an unhandled <see cref="Exception"/>.
    /// </summary>
    internal bool HasException { [Pure] get; set; }

    /// <summary>Gets or sets the amount of times <see cref="ModdedModule.Strike"/> was called.</summary>
    [NonNegativeValue]
    internal int Strikes { [Pure] get; set; }

    /// <inheritdoc/>
    [Pure]
    public object Clone() => new State(_name);

    /// <inheritdoc/>
    [Pure]
    public bool Equals(State x, State y) => x == y;

    /// <inheritdoc/>
    [Pure]
    public int GetHashCode([AllowNull, CanBeNull] State obj) => obj?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    [Pure]
    public bool Equals(State other) => this == other;

    /// <summary>Determines whether both instances contain the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both instances contain the same values, otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool operator ==([AllowNull, CanBeNull] State left, [AllowNull, CanBeNull] State right) =>
        left is null
            ? right is null
            : right is not null &&
            left.HasStruck == right.HasStruck &&
            left.IsSolved == right.IsSolved &&
            left.Id == right.Id;

    /// <summary>Determines whether both instances do not contain the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both instances do not contain the same values,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool operator !=([AllowNull, CanBeNull] State left, [AllowNull, CanBeNull] State right) =>
        !(left == right);

    /// <inheritdoc/>
    [Pure]
    public override bool Equals([AllowNull] object obj) => Equals(obj as State);

    /// <inheritdoc/>
    [NonNegativeValue, Pure]
    public override int GetHashCode() => Id;

    /// <inheritdoc/>
    [Pure]
    public override string ToString() => $"{Prefix}{Id}";
}
