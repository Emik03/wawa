// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Callbacks;

/// <summary>Implementations for <see cref="Selected"/>.</summary>
[PublicAPI]
public static class SelectedCore
{
    /// <summary>
    /// Gets the <see cref="Entity"/> of this <see cref="Selected"/>.
    /// An empty value is given if there is no attached <see cref="Entity"/> on the <see cref="Selected"/>.
    /// </summary>
    /// <param name="that">This instance of <see cref="Selected"/>.</param>
    /// <returns>
    /// A <see cref="Maybe{T}"/>, consisting of either a <see cref="Entity"/>
    /// that is attached to this instance, or <see langword="default"/>.
    /// </returns>
    [MustUseReturnValue, PublicAPI]
    public static Maybe<Entity> ToEntity(this Selected that) => Entity.FromComponent(that.Value);

    /// <summary>Creates an instance of <see cref="Entity"/> where <see cref="Entity.Solvable"/> is set.</summary>
    /// <param name="that">The <see cref="KMBombModule"/> to pass in <see cref="Entity"/>.</param>
    /// <returns>A new instance of <see cref="Entity"/> which encapsulates <paramref name="that"/>.</returns>
    [CLSCompliant(false), MustUseReturnValue, NotNull, PublicAPI, Pure]
    public static Selected AsSelectable(this KMSelectable that) => new(that);

    /// <summary>Creates an <see cref="ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="that">The collection.</param>
    /// <returns>An immutable array.</returns>
    [MustUseReturnValue, NotNull, PublicAPI]
    public static ReadOnlyCollection<Maybe<Entity>> ToEntities(this IEnumerable<Selected> that) =>
        new(that.Select(ToEntity).ToList());

    /// <summary>Creates an <see cref="ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="that">The collection.</param>
    /// <returns>An immutable array.</returns>
    [CLSCompliant(false), NotNull, PublicAPI, Pure]
    public static ReadOnlyCollection<Selected> ToSelectables(this IEnumerable<KMSelectable> that) =>
        new(that.Select(AsSelectable).ToList());
}
