// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Recall;

/// <summary>
/// Encapsulates a solvable or needy module in either its vanilla or modded counterpart,
/// and extends functionality to get or mutate its inner values and events without worrying the kind of module it is.
/// </summary>
[PublicAPI]
public sealed partial class Entity : ICloneable, IEquatable<Entity>, IEqualityComparer<Entity>, IVanilla
{
    static readonly Dictionary<GameObject, ReadOnlyCollection<Entity>> s_allModules = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="Entity"/> class.
    /// This guarantees the module kind solvable and modded.
    /// </summary>
    /// <param name="solvable">The <see cref="KMBombModule"/> instance to encapsulate.</param>
    [CLSCompliant(false), PublicAPI]
    public Entity([NotNull] KMBombModule solvable) => Value = solvable;

    /// <summary>
    /// Initializes a new instance of the <see cref="Entity"/> class. This guarantees the module kind needy and modded.
    /// </summary>
    /// <param name="needy">The <see cref="KMNeedyModule"/> instance to encapsulate.</param>
    [CLSCompliant(false), PublicAPI]
    public Entity([NotNull] KMNeedyModule needy) => Value = needy;

    /// <summary>
    /// Initializes a new instance of the <see cref="Entity"/> class. This guarantees the module kind vanilla.
    /// </summary>
    /// <param name="bombComponent">The <see cref="MonoBehaviour"/> instance to use to obtain the components.</param>
    internal Entity([NotNull] MonoBehaviour bombComponent) => Value = bombComponent;

    /// <summary>Gets the value which is guaranteed to be a <see cref="MonoBehaviour"/>.</summary>
    [CLSCompliant(false), PublicAPI]
    public MonoBehaviour Value { [Pure] get; }

    [AllowNull, CanBeNull]
    MonoBehaviour VanillaTimer
    {
        [MustUseReturnValue]
        get =>
            Value is KMBombModule or KMNeedyModule
                ? null
                : ((object)Value.Core() as NeedyComponent)?.GetComponentInChildren<NeedyTimer>().Core();
    }

    /// <summary>
    /// Determines whether both instances point to the same component.
    /// </summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both of them point to the same component, otherwise <see langword="false"/>.
    /// </returns>
    [PublicAPI, Pure]
    public static bool operator ==([AllowNull, CanBeNull] Entity? left, [AllowNull, CanBeNull] Entity? right) =>
        left?.Equals(right) ?? right is null;

    /// <summary>Determines whether both instances do not point to the same component.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both of them do not point to the same component,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [PublicAPI, Pure]
    public static bool operator !=([AllowNull, CanBeNull] Entity? left, [AllowNull, CanBeNull] Entity? right) =>
        !(left == right);

    /// <summary>Implicitly calls the constructor.</summary>
    /// <param name="solvable">The <see cref="KMBombModule"/> to pass in to the constructor.</param>
    [CLSCompliant(false), PublicAPI, Pure]
    public static implicit operator Entity([NotNull] KMBombModule solvable) => new(solvable);

    /// <summary>
    /// Implicitly calls the constructor.
    /// </summary>
    /// <param name="needy">The <see cref="KMNeedyModule"/> to pass in to the constructor.</param>
    [CLSCompliant(false), PublicAPI, Pure]
    public static implicit operator Entity([NotNull] KMNeedyModule needy) => new(needy);

    /// <summary>
    /// Converts the <see cref="KMBombModule"/> to a <see langword="new"/> <see cref="Entity"/>.
    /// </summary>
    /// <param name="solvable">The <see cref="KMBombModule"/> instance to convert.</param>
    /// <returns>
    /// A <see langword="new"/> <see cref="Entity"/> instance encapsulating <paramref name="solvable"/>.
    /// </returns>
    [CLSCompliant(false), PublicAPI, Pure]
    public static Entity FromKMBombModule([NotNull] KMBombModule solvable) => new(solvable);

    /// <summary>
    /// Converts the <see cref="KMNeedyModule"/> to a <see langword="new"/> <see cref="Entity"/>.
    /// </summary>
    /// <param name="needy">The <see cref="KMNeedyModule"/> instance to convert.</param>
    /// <returns>A <see langword="new"/> <see cref="Entity"/> instance encapsulating <paramref name="needy"/>.</returns>
    [CLSCompliant(false), PublicAPI, Pure]
    public static Entity FromKMNeedyModule([NotNull] KMNeedyModule needy) => new(needy);

    /// <summary>
    /// Gets all modules that are children of a provided <see cref="GameObject"/>, and caches it in a thread-safe manner.
    /// </summary>
    /// <param name="gameObject">The <see cref="GameObject"/> to get the modules from.</param>
    /// <returns>
    /// A <see cref="ReadOnlyCollection{T}"/> of type <see cref="Entity"/>
    /// which contains every module from <paramref name="gameObject"/>.
    /// </returns>
    [CLSCompliant(false), MustUseReturnValue, NotNull, PublicAPI]
    public static ReadOnlyCollection<Entity> GetChildren([AllowNull, CanBeNull] GameObject gameObject)
    {
        if (gameObject is null)
            return Lot<Entity>.Empty;

        if (s_allModules.TryGetValue(gameObject, out var children))
            return children;

        ReadOnlyCollection<Entity> modules = new(GetModules(gameObject).ToList());

        foreach (var key in s_allModules.Keys.Where(g => !g).ToList())
            s_allModules.Remove(key);

        s_allModules[gameObject] = modules;
        return modules;
    }

    /// <summary>Hooks the logger to all instances.</summary>
    /// <remarks><para>
    /// Since the logger is implicitly created within this function, the logging cannot easily
    /// be reversed without using the nuclear option <see cref="Generator.Clear{T}(Hook{T})"/>.
    /// </para></remarks>
    /// <returns>All entities in the current scene, where each collection represents a separate bomb.</returns>
    [NotNull, PublicAPI]
    public static ReadOnlyCollection<ReadOnlyCollection<Entity>> LogEverything()
    {
        HashSet<MonoBehaviour> set = new();

        Unit Enumerate([NotNull] Selected next)
        {
            Unit CheckForKey([NotNull] Selected next)
            {
                var key = next.Value;

                if (set.Contains(key))
                    return default;

                set.Add(key);
                Enumerate(next.Log());
                return default;
            }

            CheckForKey(next);
            next.Parent.Match(CheckForKey);

            foreach (var child in next.Children)
                child.Match(CheckForKey);

            return default;
        }

        var km = Object.FindObjectsOfType<KMBomb>();
        var ret = new ReadOnlyCollection<Entity>[km.Length];

        for (var i = 0; i < km.Length; i++)
        {
            var current = km[i].ToEntities();
            ret[i] = current;

            foreach (var x in current)
                x.Log().ToSelectable().Match(Enumerate);
        }

        return Array.AsReadOnly(ret);
    }

    /// <summary>
    /// Gets the <see cref="Entity"/> of this <see cref="Selected"/>.
    /// An empty value is given if there is no attached <see cref="Entity"/> on the <see cref="Selected"/>.
    /// </summary>
    /// <param name="component">
    /// The <see cref="Component"/> to find components of using <see cref="Component.GetComponent{T}"/>.
    /// </param>
    /// <returns>
    /// A <see cref="Maybe{T}"/>, consisting of either a <see cref="Entity"/>
    /// that is attached to this instance, or <see langword="default"/>.
    /// </returns>
    [CLSCompliant(false), MustUseReturnValue, PublicAPI]
    public static Maybe<Entity> FromComponent([NotNull] Component component) =>
        component.GetComponent<KMBombModule>() is var solvable && solvable ? new(solvable) :
        component.GetComponent<KMNeedyModule>() is var needy && needy ? new Entity(needy) :
        IsKtane ? ToEntityInner(component) : default;

    /// <inheritdoc cref="IEquatable{T}.Equals(T)"/>
    [PublicAPI, Pure]
    public bool Equals([AllowNull] Entity? other) => Value == other?.Value;

    /// <inheritdoc cref="IEqualityComparer{T}.Equals(T, T)"/>
    [PublicAPI, Pure]
    public bool Equals([AllowNull] Entity x, [AllowNull] Entity y) => x == y;

    /// <inheritdoc cref="IEqualityComparer{T}.GetHashCode(T)"/>
    [PublicAPI, Pure]
    public int GetHashCode([AllowNull, CanBeNull] Entity obj) => obj?.GetHashCode() ?? 0;

    /// <inheritdoc cref="ICloneable.Clone"/>
    // For performance reasons, we rely on the implementation details of the MonoBehaviour constructor.
    // Should its specifics change, we must change this implementation too.
    [PublicAPI, Pure]
    public object Clone() => new Entity(Value);

    /// <inheritdoc cref="object.Equals(object)"/>
    [PublicAPI, Pure]
    public override bool Equals([AllowNull] object obj) => Equals(obj as Entity);

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public override int GetHashCode() => -1937169414 + EqualityComparer<MonoBehaviour>.Default.GetHashCode(Value);

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public override string ToString() => $"{Name.Value} ({Id.Value})";

    [MustUseReturnValue, NotNull]
    static IEnumerable Vanillas([NotNull] in GameObject gameObject) =>
        gameObject
           .GetComponentsInChildren(typeof(BombComponent))
           .Where(c => !(c.GetComponent<KMBombModule>() || c.GetComponent<KMNeedyModule>()));

    [NotNull, Pure]
    static IEnumerable<Entity> GetModules([NotNull] GameObject gameObject)
    {
        foreach (var solvable in gameObject.GetComponentsInChildren<KMBombModule>())
            yield return solvable;

        foreach (var needy in gameObject.GetComponentsInChildren<KMNeedyModule>())
            yield return needy;

        if (!IsKtane)
            yield break;

        foreach (var vanilla in Vanillas(gameObject))
            yield return new((MonoBehaviour)vanilla);
    }

    [MustUseReturnValue]
    static Maybe<Entity> ToEntityInner([NotNull] in Component component) =>
        new Maybe<Component>(component.GetComponent(typeof(BombComponent))).Match(c => new Entity((MonoBehaviour)c));
}
