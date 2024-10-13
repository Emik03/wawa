// SPDX-License-Identifier: MPL-2.0
namespace wawa.Recall;

/// <summary>Encapsulates a vanilla or modded highlight.</summary>
/// <remarks><para>
/// If <see cref="IsRewritten"/> is <see langword="true"/>, all selectables are modded, even when attached to vanilla
/// <see cref="Entity"/> instances. For more information, see the remarks section for the class <see cref="Entity"/>.
/// </para></remarks>
[PublicAPI] // ReSharper disable once RedundantExtendsListEntry
public sealed partial class Highlighted : ICloneable, IEquatable<Highlighted>, IEqualityComparer<Highlighted>, IVanilla
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Highlighted"/> class.
    /// This guarantees the highlightable kind solvable.
    /// </summary>
    /// <param name="highlightable">The <see cref="KMHighlightable"/> instance to encapsulate.</param>
    [CLSCompliant(false), PublicAPI]
    public Highlighted([NotNull] KMHighlightable highlightable) => Value = highlightable;

    /// <summary>
    /// Initializes a new instance of the <see cref="Highlighted"/> class.
    /// This guarantees the highlightable kind vanilla.
    /// </summary>
    /// <param name="highlightable">The Selectable instance to encapsulate.</param>
    internal Highlighted([NotNull] MonoBehaviour highlightable) => Value = highlightable;

    /// <summary>Gets the value which is guaranteed to be a <see cref="MonoBehaviour"/>.</summary>
    [CLSCompliant(false), PublicAPI]
    public MonoBehaviour Value { [Pure] get; }

    /// <summary>
    /// Determines whether both instances point to the same component.
    /// </summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>The value <see langword="true"/> if both of them point to the same component, otherwise <see langword="false"/>.</returns>
    [Pure, PublicAPI]
    public static bool operator ==(
        [AllowNull, CanBeNull] Highlighted left,
        [AllowNull, CanBeNull] Highlighted right
    ) => // ReSharper disable once AssignNullToNotNullAttribute
        left?.Equals(right) ?? right is null;

    /// <summary>
    /// Implicitly calls the constructor.
    /// </summary>
    /// <param name="highlightable">The <see cref="KMHighlightable"/> to pass in to the constructor.</param>
    [CLSCompliant(false), NotNull, PublicAPI, Pure]
    public static implicit operator Highlighted([NotNull] KMHighlightable highlightable) => new(highlightable);

    /// <summary>
    /// Determines whether both instances do not point to the same component.
    /// </summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>The value <see langword="true"/> if both of them do not point to the same component, otherwise <see langword="false"/>.</returns>
    [Pure, PublicAPI]
    public static bool operator !=(
        [AllowNull, CanBeNull] Highlighted left,
        [AllowNull, CanBeNull] Highlighted right
    ) =>
        !(left == right);

    /// <summary>
    /// Converts the <see cref="KMBombModule"/> to a <see langword="new"/> <see cref="Selected"/>.
    /// </summary>
    /// <param name="highlightable">The <see cref="KMBombModule"/> instance to convert.</param>
    /// <returns>A <see langword="new"/> <see cref="Selected"/> instance encapsulating <paramref name="highlightable"/>.</returns>
    [CLSCompliant(false), NotNull, PublicAPI, Pure]
    public static Highlighted FromKMHighlightable([NotNull] KMHighlightable highlightable) => new(highlightable);

    /// <summary>
    /// Gets a new instance of <see cref="Highlighted"/> based on the first found highlightable of the <see cref="Component"/>.
    /// </summary>
    /// <param name="component">
    /// The <see cref="Component"/> to find components of using <see cref="Component.GetComponent{T}"/>.
    /// </param>
    /// <returns>
    /// A <see cref="Maybe{T}"/>, consisting of either a <see cref="Selected"/>
    /// that is attached to this instance, or <see langword="default"/>.
    /// </returns>
    [CLSCompliant(false), MustUseReturnValue, PublicAPI]
    public static Maybe<Highlighted> FromComponent([NotNull] Component component) =>
        component.GetComponent<KMHighlightable>() is var highlightable && highlightable ?
            new Highlighted(highlightable) :
            IsKtane ? ToHighlightableInner(component) : default;

    /// <inheritdoc cref="IEquatable{T}.Equals(T)"/>
    [PublicAPI, Pure] // ReSharper disable once ConstantConditionalAccessQualifier
    public bool Equals([AllowNull] Highlighted other) => Value == other?.Value;

    /// <inheritdoc cref="IEqualityComparer{T}.Equals(T, T)"/>
    [PublicAPI, Pure]
    public bool Equals([AllowNull] Highlighted x, [AllowNull] Highlighted y) => x == y;

    /// <inheritdoc cref="IEqualityComparer{T}.GetHashCode(T)"/>
    [PublicAPI, Pure]
    public int GetHashCode([AllowNull, CanBeNull] Highlighted obj) => obj?.GetHashCode() ?? 0;

    /// <inheritdoc cref="ICloneable.Clone"/>
    [PublicAPI, Pure]
    public object Clone() => new Highlighted(Value);

    /// <inheritdoc cref="object.Equals(object)"/>
    [PublicAPI, Pure] // ReSharper disable once AssignNullToNotNullAttribute
    public override bool Equals([AllowNull] object? obj) => Equals(obj as Highlighted);

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public override int GetHashCode() => -1937169414 + EqualityComparer<MonoBehaviour>.Default.GetHashCode(Value);

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public override string ToString() => Value.name;

    [MustUseReturnValue]
    static Maybe<Highlighted> ToHighlightableInner([NotNull] in Component component) =>
        component.GetComponent(typeof(Highlightable)) is MonoBehaviour m ? new Highlighted(m) : null;
}
