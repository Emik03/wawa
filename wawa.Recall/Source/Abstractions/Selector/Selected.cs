// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Callbacks;

/// <summary>
/// Encapsulates a vanilla or modded selectable, and extends functionality to get or
/// mutate its inner values and events without worrying the kind of selectable it is.
/// </summary>
[PublicAPI]
public sealed partial class Selected : ICloneable, IEquatable<Selected>, IEqualityComparer<Selected>, IVanilla
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Selected"/> class. This guarantees the selectable kind solvable.
    /// </summary>
    /// <param name="selectable">The <see cref="KMSelectable"/> instance to encapsulate.</param>
    [CLSCompliant(false), PublicAPI]
    public Selected(KMSelectable selectable) => Value = selectable;

    /// <summary>
    /// Initializes a new instance of the <see cref="Selected"/> class. This guarantees the selectable kind vanilla.
    /// </summary>
    /// <param name="selectable">The Selectable instance to encapsulate.</param>
    internal Selected(MonoBehaviour selectable) => Value = selectable;

    /// <summary>Gets the value which is guaranteed to be a <see cref="MonoBehaviour"/>.</summary>
    [PublicAPI]
    public MonoBehaviour Value { [Pure] get; }

    /// <summary>Determines whether both instances point to the same component.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both of them point to the same component, otherwise <see langword="false"/>.
    /// </returns>
    [PublicAPI, Pure]
    public static bool operator ==([AllowNull, CanBeNull] Selected? left, [AllowNull, CanBeNull] Selected? right) =>
        left?.Equals(right) ?? right is null;

    /// <summary>Determines whether both instances do not point to the same component.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both of them do not point
    /// to the same component, otherwise <see langword="false"/>.
    /// </returns>
    [PublicAPI, Pure]
    public static bool operator !=(Selected? left, Selected? right) => !(left == right);

    /// <summary>Implicitly calls the constructor.</summary>
    /// <param name="selectable">The <see cref="KMSelectable"/> to pass in to the constructor.</param>
    [CLSCompliant(false), NotNull, PublicAPI, Pure]
    public static implicit operator Selected(KMSelectable selectable) => new(selectable);

    /// <summary>
    /// Converts the <see cref="KMBombModule"/> to a <see langword="new"/> <see cref="Selected"/>.
    /// </summary>
    /// <param name="selectable">The <see cref="KMBombModule"/> instance to convert.</param>
    /// <returns>A <see langword="new"/> <see cref="Selected"/> instance encapsulating <paramref name="selectable"/>.</returns>
    [CLSCompliant(false), NotNull, PublicAPI, Pure]
    public static Selected FromKMSelectable(KMSelectable selectable) => new(selectable);

    /// <summary>
    /// Gets a new instance of <see cref="Selected"/> based on
    /// the first found selectable of the <see cref="Component"/>.
    /// </summary>
    /// <param name="component">
    /// The <see cref="Component"/> to find components of using <see cref="Component.GetComponent{T}"/>.
    /// </param>
    /// <returns>
    /// A <see cref="Maybe{T}"/>, consisting of either a <see cref="Selected"/>
    /// that is attached to this instance, or <see langword="default"/>.
    /// </returns>
    [CLSCompliant(false), PublicAPI, Pure]
    public static Maybe<Selected> FromComponent([NotNull] Component component) =>
        component.GetComponent<KMSelectable>() is var selectable && selectable ? new Selected(selectable) :
        IsKtane ? ToSelectableInner(component) : default;

    /// <inheritdoc cref="IEquatable{T}.Equals(T)"/>
    [PublicAPI, Pure] // ReSharper disable AnnotationRedundancyInHierarchy
    public bool Equals([AllowNull, CanBeNull] Selected other) => Value == other?.Value;

    /// <inheritdoc cref="IEqualityComparer{T}.Equals(T, T)"/>
    [PublicAPI, Pure]
    public bool Equals([AllowNull, CanBeNull] Selected x, [AllowNull, CanBeNull] Selected y) => x == y;

    /// <inheritdoc cref="IEqualityComparer{T}.GetHashCode(T)"/>
    [PublicAPI, Pure]
    public int GetHashCode([AllowNull, CanBeNull] Selected obj) => obj?.GetHashCode() ?? 0;

    /// <inheritdoc cref="ICloneable.Clone()"/>
    [PublicAPI, Pure] // ReSharper restore AnnotationRedundancyInHierarchy
    public object Clone() => new Selected(Value);

    /// <inheritdoc cref="object.Equals(object)"/>
    [PublicAPI, Pure]
    public override bool Equals([AllowNull] object obj) => Equals(obj as Selected);

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public override int GetHashCode() => -1937169414 + EqualityComparer<MonoBehaviour>.Default.GetHashCode(Value);

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public override string ToString() => Value.name;

    [MustUseReturnValue]
    static Maybe<Selected> ToSelectableInner(in Component component) =>
        component.GetComponent(typeof(Selectable)) is MonoBehaviour m ? new Selected(m) : null;
}
