// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Callbacks;

/// <summary>Implementations for <see cref="Entity"/>.</summary>
public static class EntityCore
{
    /// <summary>Creates an instance of <see cref="Entity"/> where <see cref="Entity.Solvable"/> is set.</summary>
    /// <param name="solvable">The <see cref="KMBombModule"/> to pass in <see cref="Entity"/>.</param>
    /// <returns>A new instance of <see cref="Entity"/> which encapsulates <paramref name="solvable"/>.</returns>
    [CLSCompliant(false), NotNull, Pure]
    public static Entity AsEntity([NotNull] this KMBombModule solvable) => new(solvable);

    /// <summary>Creates an instance of <see cref="Entity"/> where <see cref="Entity.Needy"/> is set.</summary>
    /// <param name="needy">The <see cref="KMNeedyModule"/> to pass in <see cref="Entity"/>.</param>
    /// <returns>A new instance of <see cref="Entity"/> which encapsulates <paramref name="needy"/>.</returns>
    [CLSCompliant(false), NotNull, Pure]
    public static Entity AsEntity([NotNull] this KMNeedyModule needy) => new(needy);

    /// <summary>
    /// Gets the <see cref="Highlighted"/> of this <see cref="Entity"/>.
    /// An empty value is given if there is no attached <see cref="Selected"/> on the <see cref="Entity"/>.
    /// </summary>
    /// <param name="that">This instance of <see cref="Entity"/>.</param>
    /// <returns>
    /// A <see cref="Maybe{T}"/>, consisting of either a <see cref="Selected"/>
    /// that is attached to this instance, or <see langword="default"/>.
    /// </returns>
    [MustUseReturnValue]
    public static Maybe<Highlighted> ToHighlightable([NotNull] this Entity that) =>
        Highlighted.FromComponent(that.Value);

    /// <summary>
    /// Gets the <see cref="Selected"/> of this <see cref="Entity"/>.
    /// An empty value is given if there is no attached <see cref="Selected"/> on the <see cref="Entity"/>.
    /// </summary>
    /// <param name="entity">This instance of <see cref="Entity"/>.</param>
    /// <returns>
    /// A <see cref="Maybe{T}"/>, consisting of either a <see cref="Selected"/>
    /// that is attached to this instance, or <see langword="default"/>.
    /// </returns>
    [MustUseReturnValue]
    public static Maybe<Selected> ToSelectable([NotNull] this Entity entity) => Selected.FromComponent(entity.Value);

    /// <summary>Gets all modules that are children of a provided <see cref="GameObject"/>.</summary>
    /// <param name="gameObject">The <see cref="GameObject"/> to get the modules from.</param>
    /// <returns>
    /// A <see cref="ReadOnlyCollection{T}"/> of type <see cref="Entity"/>
    /// which contains every module from <paramref name="gameObject"/>.
    /// </returns>
    [CLSCompliant(false), MustUseReturnValue, NotNull]
    public static ReadOnlyCollection<Entity> GetChildren([AllowNull, CanBeNull] this GameObject gameObject) =>
        Entity.GetChildren(gameObject);

    /// <summary>Gets all modules that are children of a provided <see cref="KMBomb"/>.</summary>
    /// <param name="bomb">The <see cref="KMBomb"/> to get the modules from.</param>
    /// <returns>A <see cref="ReadOnlyCollection{T}"/> of type <see cref="Entity"/> which contains every module from <paramref name="bomb"/>.</returns>
    [CLSCompliant(false), MustUseReturnValue, NotNull]
    public static ReadOnlyCollection<Entity> ToEntities([AllowNull, CanBeNull] this KMBomb bomb) =>
        bomb ? bomb.gameObject.GetChildren() : Chest<Entity>.Empty;

    /// <summary>Creates an <see cref="ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="solvables">The collection.</param>
    /// <returns>An immutable array.</returns>
    [CLSCompliant(false), MustUseReturnValue, NotNull]
    public static ReadOnlyCollection<Entity> ToEntities(
        [AllowNull, CanBeNull] this IEnumerable<KMBombModule> solvables
    ) =>
        solvables is null ? Chest<Entity>.Empty : new(solvables.Select(AsEntity).ToList());

    /// <summary>Creates an <see cref="ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="needies">The collection.</param>
    /// <returns>An immutable array.</returns>
    [CLSCompliant(false), MustUseReturnValue, NotNull]
    public static ReadOnlyCollection<Entity> ToEntities(
        [AllowNull, CanBeNull] this IEnumerable<KMNeedyModule> needies
    ) =>
        needies is null ? Chest<Entity>.Empty : new(needies.Select(AsEntity).ToList());

    /// <summary>Creates an <see cref="ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="entities">The collection.</param>
    /// <returns>An immutable array.</returns>
    [MustUseReturnValue, NotNull]
    public static ReadOnlyCollection<Maybe<Highlighted>> ToHighlighters(
        [AllowNull, CanBeNull] this IEnumerable<Entity> entities
    ) =>
        entities is null ? Chest<Maybe<Highlighted>>.Empty : new(entities.Select(ToHighlightable).ToList());

    /// <summary>Creates an <see cref="ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="entities">The collection.</param>
    /// <returns>An immutable array.</returns>
    [MustUseReturnValue, NotNull]
    public static ReadOnlyCollection<Maybe<Selected>> ToSelectors(
        [AllowNull, CanBeNull] this IEnumerable<Entity> entities
    ) =>
        entities is null ? Chest<Maybe<Selected>>.Empty : new(entities.Select(ToSelectable).ToList());

    /// <summary>Creates an <see cref="ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="bombs">The collection.</param>
    /// <returns>An immutable array.</returns>
    [CLSCompliant(false), MustUseReturnValue, NotNull]
    public static ReadOnlyCollection<ReadOnlyCollection<Entity>> ToManyEntities(
        [AllowNull, CanBeNull] this IEnumerable<KMBomb> bombs
    ) =>
        bombs is null ? Chest<ReadOnlyCollection<Entity>>.Empty : new(bombs.Select(ToEntities).ToList());
}
