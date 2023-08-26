// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Callbacks;

/// <summary>Implementations for <see cref="Highlighted"/>.</summary>
[PublicAPI]
public static class HighlightedCore
{
    /// <summary>Creates an instance of <see cref="Entity"/> where <see cref="Entity.Solvable"/> is set.</summary>
    /// <param name="highlightable">The <see cref="KMBombModule"/> to pass in <see cref="Entity"/>.</param>
    /// <returns>A new instance of <see cref="Entity"/> which encapsulates <paramref name="highlightable"/>.</returns>
    [CLSCompliant(false), NotNull, PublicAPI, Pure]
    public static Highlighted AsHighlighter([NotNull] this KMHighlightable highlightable) => new(highlightable);

    /// <summary>
    /// Gets the <see cref="Entity"/> of this <see cref="Highlighted"/>.
    /// An empty value is given if there is no attached <see cref="Entity"/> on the <see cref="Highlighted"/>.
    /// </summary>
    /// <param name="highlighted">This instance of <see cref="Highlighted"/>.</param>
    /// <returns>
    /// A <see cref="Maybe{T}"/>, consisting of either a <see cref="Entity"/>
    /// that is attached to this instance, or <see langword="default"/>.
    /// </returns>
    [PublicAPI, Pure]
    public static Maybe<Entity> ToEntity([NotNull] this Highlighted highlighted) =>
        Entity.FromComponent(highlighted.Value);

    /// <summary>Creates a <see cref="ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="highlighters">The collection.</param>
    /// <returns>An immutable array.</returns>
    [NotNull, PublicAPI, Pure]
    public static ReadOnlyCollection<Maybe<Entity>> ToEntities(
        [AllowNull, CanBeNull] this IEnumerable<Highlighted> highlighters
    ) =>
        highlighters is null ? Lot<Maybe<Entity>>.Empty : new(highlighters.Select(ToEntity).ToList());

    /// <summary>Creates a <see cref="ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="highlightables">The collection.</param>
    /// <returns>An immutable array.</returns>
    [CLSCompliant(false), NotNull, PublicAPI, Pure]
    public static ReadOnlyCollection<Highlighted> ToHighlighters(
        [AllowNull, CanBeNull] this IEnumerable<KMHighlightable> highlightables
    ) =>
        highlightables is null ? Lot<Highlighted>.Empty : new(highlightables.Select(AsHighlighter).ToList());
}
