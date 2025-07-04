// SPDX-License-Identifier: MPL-2.0
namespace wawa.Recall;

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

    /// <summary>Adds the parameter values to the corresponding hooks, when applicable.</summary>
    /// <param name="that">This instance of <see cref="Entity"/>.</param>
    /// <param name="onActivate">Invoked when the lights turn on.</param>
    /// <param name="onNeedyActivate">Invoked when the needy activates.</param>
    /// <param name="onNeedyDeactivate">Invoked when the needy deactivates.</param>
    /// <param name="onNeedyTimerExpired">Invoked when the needy timer expires.</param>
    /// <param name="onNeedyTimerGet">Invoked to get the time remaining of the needy timer.</param>
    /// <param name="onNeedyTimerSet">Invoked to set the time of the needy timer.</param>
    /// <param name="onRuleGeneration">Invoked to get the random seed used to generate rules for the game.</param>
    /// <param name="onSolve">Invoked when the entire module has been solved.</param>
    /// <param name="onStrike">Invoked on any mistake that causes a bomb strike.</param>
    /// <returns>Itself.</returns>
    // ReSharper disable MethodOverloadWithOptionalParameter
    [NotNull, PublicAPI]
    public static Entity Add(
        [NotNull] this Entity that,
        [AllowNull, CanBeNull] Action onActivate = null,
        [AllowNull, CanBeNull] Action onNeedyActivate = null,
        [AllowNull, CanBeNull] Action onNeedyDeactivate = null,
        [AllowNull, CanBeNull] Action onNeedyTimerExpired = null,
        [AllowNull, CanBeNull] Action onNeedyTimerGet = null,
        [AllowNull, CanBeNull] Action onNeedyTimerSet = null,
        [AllowNull, CanBeNull] Action onRuleGeneration = null,
        [AllowNull, CanBeNull] Action onSolve = null,
        [AllowNull, CanBeNull] Action onStrike = null
    )
    {
        that.Solve.Add(onSolve);
        that.Strike.Add(onStrike);
        that.Activate.Add(onActivate);
        that.NeedyActivate.TryAdd(onNeedyActivate);
        that.NeedyTimerGet.TryAdd(onNeedyTimerGet);
        that.NeedyTimerSet.TryAdd(onNeedyTimerSet);
        that.RuleGeneration.TryAdd(onRuleGeneration);
        that.NeedyDeactivate.TryAdd(onNeedyDeactivate);
        that.NeedyTimerExpired.TryAdd(onNeedyTimerExpired);
        return that;
    }

    /// <summary>Alters the status light to <paramref name="lights"/>.</summary>
    /// <remarks><para>In the editor, this method does nothing.</para></remarks>
    /// <param name="that">This instance of <see cref="Entity"/>.</param>
    /// <param name="lights">The status lights to enable.</param>
    /// <returns>The instance itself.</returns>
    [PublicAPI]
    public static Entity Change([NotNull] this Entity that, StatusLights lights)
    {
        FromGame(new KeyValuePair<MonoBehaviour, byte>(that.Value, (byte)lights), ChangeInner);
        return that;
    }

    /// <summary>Plays the strike sound effect and flashes the status light red, without registering a strike.</summary>
    /// <remarks><para>In the editor, this method does nothing.</para></remarks>
    /// <param name="that">This instance of <see cref="Entity"/>.</param>
    /// <returns>The instance itself.</returns>
    [PublicAPI]
    public static Entity FakeStrike([NotNull] this Entity that)
    {
        FromGame(that.Value, FakeStrikeInner);
        return that;
    }

    /// <summary>Sets the parameter values to the corresponding hooks, when applicable.</summary>
    /// <inheritdoc cref="Add(Entity, Action, Action, Action, Action, Action, Action, Action, Action, Action)"/>
    [NotNull, PublicAPI]
    public static Entity Set(
        [NotNull] this Entity that,
        [AllowNull, CanBeNull] Action onActivate = null,
        [AllowNull, CanBeNull] Action onNeedyActivate = null,
        [AllowNull, CanBeNull] Action onNeedyDeactivate = null,
        [AllowNull, CanBeNull] Action onNeedyTimerExpired = null,
        [AllowNull, CanBeNull] Action onNeedyTimerGet = null,
        [AllowNull, CanBeNull] Action onNeedyTimerSet = null,
        [AllowNull, CanBeNull] Action onRuleGeneration = null,
        [AllowNull, CanBeNull] Action onSolve = null,
        [AllowNull, CanBeNull] Action onStrike = null
    )
    {
        that.Solve.Set(onSolve);
        that.Strike.Set(onStrike);
        that.Activate.Set(onActivate);
        that.NeedyActivate.TrySet(onNeedyActivate);
        that.NeedyTimerGet.TrySet(onNeedyTimerGet);
        that.NeedyTimerSet.TrySet(onNeedyTimerSet);
        that.RuleGeneration.TrySet(onRuleGeneration);
        that.NeedyDeactivate.TrySet(onNeedyDeactivate);
        that.NeedyTimerExpired.TrySet(onNeedyTimerExpired);
        return that;
    }

    /// <summary>Removes the parameter values to the corresponding hooks, when applicable.</summary>
    /// <inheritdoc cref="Add(Entity, Action, Action, Action, Action, Action, Action, Action, Action, Action)"/>
    [NotNull, PublicAPI]
    public static Entity Remove(
        [NotNull] this Entity that,
        [AllowNull, CanBeNull] Action onActivate = null,
        [AllowNull, CanBeNull] Action onNeedyActivate = null,
        [AllowNull, CanBeNull] Action onNeedyDeactivate = null,
        [AllowNull, CanBeNull] Action onNeedyTimerExpired = null,
        [AllowNull, CanBeNull] Action onNeedyTimerGet = null,
        [AllowNull, CanBeNull] Action onNeedyTimerSet = null,
        [AllowNull, CanBeNull] Action onRuleGeneration = null,
        [AllowNull, CanBeNull] Action onSolve = null,
        [AllowNull, CanBeNull] Action onStrike = null
    )
    {
        that.Solve.Remove(onSolve);
        that.Strike.Remove(onStrike);
        that.Activate.Remove(onActivate);
        that.NeedyActivate.TryRemove(onNeedyActivate);
        that.NeedyTimerGet.TryRemove(onNeedyTimerGet);
        that.NeedyTimerSet.TryRemove(onNeedyTimerSet);
        that.RuleGeneration.TryRemove(onRuleGeneration);
        that.NeedyDeactivate.TryRemove(onNeedyDeactivate);
        that.NeedyTimerExpired.TryRemove(onNeedyTimerExpired);
        return that;
    }

    /// <summary>Adds the parameter values to the corresponding hooks, when applicable.</summary>
    /// <param name="that">This instance of <see cref="Entity"/>.</param>
    /// <param name="needyTimerGet">Invoked to get the time remaining of the needy timer.</param>
    /// <param name="needyTimerSet">Invoked to set the time of the needy timer.</param>
    /// <param name="ruleGeneration">Invoked to get the random seed used to generate rules for the game.</param>
    /// <param name="onSolve">Invoked when the entire module has been solved.</param>
    /// <param name="onStrike">Invoked on any mistake that causes a bomb strike.</param>
    /// <returns>Itself.</returns>
    [NotNull, PublicAPI]
    public static Entity AddRaw(
        [NotNull] Entity that,
        [AllowNull, CanBeNull] Func<float> needyTimerGet = null,
        [AllowNull, CanBeNull] Action<float> needyTimerSet = null,
        [AllowNull, CanBeNull] Func<int> ruleGeneration = null,
        [AllowNull, CanBeNull] Func<bool> onSolve = null,
        [AllowNull, CanBeNull] Func<bool> onStrike = null
    )
    {
        that.NeedyTimerSet.TryAdd(needyTimerSet);
        that.RuleGeneration.TryAdd(ruleGeneration);
        that.NeedyTimerGet.TryAdd(needyTimerGet);
        that.Solve.AddRaw(onSolve);
        that.Strike.AddRaw(onStrike);
        return that;
    }

    /// <summary>Removes the parameter values to the corresponding hooks, when applicable.</summary>
    /// <inheritdoc cref="AddRaw"/>
    [NotNull, PublicAPI]
    public static Entity RemoveRaw(
        [NotNull] Entity that,
        [AllowNull, CanBeNull] Func<float> needyTimerGet = null,
        [AllowNull, CanBeNull] Action<float> needyTimerSet = null,
        [AllowNull, CanBeNull] Func<int> ruleGeneration = null,
        [AllowNull, CanBeNull] Func<bool> onSolve = null,
        [AllowNull, CanBeNull] Func<bool> onStrike = null
    )
    {
        that.NeedyTimerSet.TryRemove(needyTimerSet);
        that.RuleGeneration.TryRemove(ruleGeneration);
        that.NeedyTimerGet.TryRemove(needyTimerGet);
        that.Solve.AddRaw(onSolve);
        that.Strike.AddRaw(onStrike);
        return that;
    }

    /// <summary>Sets the parameter values to the corresponding hooks, when applicable.</summary>
    /// <inheritdoc cref="AddRaw"/>
    [NotNull, PublicAPI]
    public static Entity SetRaw(
        [NotNull] Entity that,
        [AllowNull, CanBeNull] Func<float> needyTimerGet = null,
        [AllowNull, CanBeNull] Action<float> needyTimerSet = null,
        [AllowNull, CanBeNull] Func<int> ruleGeneration = null,
        [AllowNull, CanBeNull] Func<bool> onSolve = null,
        [AllowNull, CanBeNull] Func<bool> onStrike = null
    )
    {
        that.NeedyTimerSet.TrySet(needyTimerSet);
        that.RuleGeneration.TrySet(ruleGeneration);
        that.NeedyTimerGet.TrySet(needyTimerGet);
        that.Solve.AddRaw(onSolve);
        that.Strike.AddRaw(onStrike);
        return that;
    }

    /// <summary>Hooks the logger to each instance.</summary>
    /// <remarks><para>
    /// Since the logger is implicitly created within this function, the logging cannot easily
    /// be reversed without using the nuclear option <see cref="Generator.Clear{T}(Hook{T})"/>.
    /// </para></remarks>
    /// <param name="that">This instance of <see cref="Selected"/>.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [NotNull, PublicAPI]
    public static Entity Log([NotNull] this Entity that) =>
        that.Add(
            that.Logger(nameof(Entity.Activate)),
            that.Logger(nameof(Entity.NeedyActivate)),
            that.Logger(nameof(Entity.NeedyDeactivate)),
            that.Logger(nameof(Entity.NeedyTimerExpired)),
            that.Logger(nameof(Entity.NeedyTimerGet)),
            that.Logger(nameof(Entity.NeedyTimerSet)),
            that.Logger(nameof(Entity.RuleGeneration)),
            that.Logger(nameof(Entity.Solve)),
            that.Logger(nameof(Entity.Strike))
        );

    /// <inheritdoc cref="Log(Entity)"/>
    // ReSharper disable PossibleMultipleEnumeration
    [NotNull, PublicAPI]
    public static IEnumerable<Entity> Log([NotNull] this IEnumerable<Entity> that)
    {
        foreach (var next in that)
            next.Log();

        return that;
    }

    /// <inheritdoc cref="Log(Entity)"/>
    [NotNull, PublicAPI]
    public static IEnumerable<Maybe<Entity>> Log([NotNull] this IEnumerable<Maybe<Entity>> that)
    {
        foreach (var next in that)
            if (next.Value is { } value)
                value.Log();

        return that; // ReSharper restore PossibleMultipleEnumeration
    }

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
        bomb ? GetChildren(bomb.gameObject) : Lot<Entity>.Empty;

    /// <summary>Creates an <see cref="ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="solvables">The collection.</param>
    /// <returns>An immutable array.</returns>
    [CLSCompliant(false), MustUseReturnValue, NotNull]
    public static ReadOnlyCollection<Entity> ToEntities(
        [AllowNull, CanBeNull] this IEnumerable<KMBombModule> solvables
    ) =>
        solvables is null ? Lot<Entity>.Empty : new([..solvables.Select(AsEntity)]);

    /// <summary>Creates an <see cref="ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="needies">The collection.</param>
    /// <returns>An immutable array.</returns>
    [CLSCompliant(false), MustUseReturnValue, NotNull]
    public static ReadOnlyCollection<Entity> ToEntities(
        [AllowNull, CanBeNull] this IEnumerable<KMNeedyModule> needies
    ) =>
        needies is null ? Lot<Entity>.Empty : new([..needies.Select(AsEntity)]);

    /// <summary>Creates an <see cref="ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="entities">The collection.</param>
    /// <returns>An immutable array.</returns>
    [MustUseReturnValue, NotNull]
    public static ReadOnlyCollection<Maybe<Highlighted>> ToHighlighters(
        [AllowNull, CanBeNull] this IEnumerable<Entity> entities
    ) =>
        entities is null ? Lot<Maybe<Highlighted>>.Empty : new([..entities.Select(ToHighlightable)]);

    /// <summary>Creates an <see cref="ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="entities">The collection.</param>
    /// <returns>An immutable array.</returns>
    [MustUseReturnValue, NotNull]
    public static ReadOnlyCollection<Maybe<Selected>> ToSelectors(
        [AllowNull, CanBeNull] this IEnumerable<Entity> entities
    ) =>
        entities is null ? Lot<Maybe<Selected>>.Empty : new([..entities.Select(ToSelectable)]);

    /// <summary>Creates an <see cref="ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="bombs">The collection.</param>
    /// <returns>An immutable array.</returns>
    [CLSCompliant(false), MustUseReturnValue, NotNull]
    public static ReadOnlyCollection<ReadOnlyCollection<Entity>> ToManyEntities(
        [AllowNull, CanBeNull] this IEnumerable<KMBomb> bombs
    ) =>
        bombs is null ? Lot<ReadOnlyCollection<Entity>>.Empty : new([..bombs.Select(ToEntities)]);

    [MustUseReturnValue]
    static KeyValuePair<MonoBehaviour, byte> ChangeInner(KeyValuePair<MonoBehaviour, byte> arg)
    {
        [Pure]
        static bool HasFlag(byte l, StatusLights filter) => ((StatusLights)l & filter) is not StatusLights.None;

        var core = arg.Key.Core();

        if ((core as BombComponent ?? core.GetComponent<BombComponent>()) is var value && !value)
            return arg;

        var light = value.StatusLightParent.StatusLight;
        light.StopAllCoroutines();
        light.InactiveLight.SetActive(HasFlag(arg.Value, StatusLights.Off));
        light.PassLight.SetActive(HasFlag(arg.Value, StatusLights.Solve));
        light.StrikeLight.SetActive(HasFlag(arg.Value, StatusLights.Strike));
        return arg;
    }

    static MonoBehaviour FakeStrikeInner([NotNull] MonoBehaviour entity)
    {
        var core = entity.Core();
        MasterAudio.PlaySound3DAtTransformAndForget("strike", core.transform);

        if ((core as BombComponent ?? core.GetComponent<BombComponent>()) is var value && value)
            value.StatusLightParent.StatusLight.FlashStrike();

        return entity;
    }
}
