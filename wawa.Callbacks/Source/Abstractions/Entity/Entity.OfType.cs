// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Callbacks;

/// <summary>
/// Encapsulates a solvable or needy module in either its vanilla or modded counterpart,
/// and extends functionality to get or mutate its inner values and events without worrying the kind of module it is.
/// </summary>
public sealed partial class Entity
{
    [CanBeNull]
    PropDef<bool> _requiresTimerVisibility;

    [CanBeNull]
    PropMay<bool> _needyWarnAtFiveSeconds;

    [CanBeNull]
    PropMay<float> _needyStartingTime, _needyMinResetInterval, _needyMaxResetInterval;

    [CanBeNull]
    PropDef<string> _id, _name;

    [CanBeNull]
    HookDef<Action> _activate, _solve, _strike;

    [CanBeNull]
    HookMay<Action> _needyActivate, _needyDeactivate, _needyTimerExpired;

    [CanBeNull]
    HookMay<Action<float>> _needyTimerSet;

    [CanBeNull]
    HookMay<Func<int>> _ruleGeneration;

    [CanBeNull]
    HookMay<Func<float>> _needyTimerGet;

    /// <summary>
    /// Gets a value indicating whether this instance is a non-module;
    /// either <see cref="Modules.Empty"/> or <see cref="Modules.Timer"/>.
    /// </summary>
    [PublicAPI]
    public bool IsEmptyOrTimer
    {
        [Pure] get => Kind is Modules.Empty or Modules.Timer;
    }

    /// <summary>Gets a value indicating whether this instance contains a modded module.</summary>
    [PublicAPI]
    public bool IsModded
    {
        [Pure] get => IsModdedSolvable || IsModdedNeedy;
    }

    /// <summary>Gets a value indicating whether this instance contains a modded needy module.</summary>
    [PublicAPI]
    public bool IsModdedNeedy
    {
        [Pure] get => Value.Core() is KMNeedyModule;
    }

    /// <summary>Gets a value indicating whether this instance contains a modded solvable module.</summary>
    [PublicAPI]
    public bool IsModdedSolvable
    {
        [Pure] get => Value.Core() is KMBombModule;
    }

    /// <summary>
    /// Gets a value indicating whether this instance is a module;
    /// not <see cref="Modules.Empty"/> or <see cref="Modules.Timer"/>.
    /// </summary>
    [PublicAPI]
    public bool IsModule
    {
        [Pure] get => !IsEmptyOrTimer;
    }

    /// <summary>Gets a value indicating whether this instance contains a needy module.</summary>
    [PublicAPI]
    public bool IsNeedy
    {
        [Pure] get => IsModdedNeedy || IsVanillaNeedy;
    }

    /// <summary>Gets a value indicating whether this instance contains a solvable module.</summary>
    [PublicAPI]
    public bool IsSolvable
    {
        [Pure] get => IsModdedSolvable || IsVanillaSolvable;
    }

    /// <summary>Gets a value indicating whether this instance contains a vanilla component.</summary>
    /// <remarks><para>This includes <see cref="Modules.Empty"/> and <see cref="Modules.Timer"/>.</para></remarks>
    [PublicAPI]
    public bool IsVanilla
    {
        [Pure] get => !IsModded;
    }

    /// <summary>Gets a value indicating whether this instance contains a vanilla module.</summary>
    /// <remarks><para>This excludes <see cref="Modules.Empty"/> and <see cref="Modules.Timer"/>.</para></remarks>
    [PublicAPI]
    public bool IsVanillaModule
    {
        [Pure] get => IsVanilla && IsModule;
    }

    /// <summary>Gets a value indicating whether this instance contains a vanilla needy.</summary>
    [PublicAPI]
    public bool IsVanillaNeedy
    {
        [Pure] get => Kind is Modules.NeedyCapacitor or Modules.NeedyKnob or Modules.NeedyVentGas;
    }

    /// <summary>Gets a value indicating whether this instance contains a vanilla solvable.</summary>
    [PublicAPI]
    public bool IsVanillaSolvable
    {
        [Pure]
        get =>
            IsVanilla &&
            Kind is not Modules.Empty and
                not Modules.Timer and
                not Modules.NeedyCapacitor and
                not Modules.NeedyVentGas and
                not Modules.NeedyKnob;
    }

    /// <summary>
    /// Gets the type of component, to differentiate the different kinds of vanilla modules.
    /// Modded modules are grouped as <see cref="Modules.Mod"/> or <see cref="Modules.NeedyMod"/> depending on type.
    /// </summary>
    [PublicAPI]
    public Modules Kind
    {
        [Pure]
        get =>
            Value switch
            {
                KMBombModule => Modules.Mod,
                KMNeedyModule => Modules.NeedyMod,
                _ => VanillaType(Value),
            };
    }

    /// <summary>
    /// Gets whether to only allow this module to be placed on the same face as the timer.
    /// Useful when the rules involve the timer in some way (like the Big Button),
    /// but should be used sparingly as it limits generation possibilities.
    /// </summary>
    [PublicAPI]
    public PropDef<bool> RequiresTimerVisibility
    {
        [Pure] get => _requiresTimerVisibility ??= new(Value, nameof(RequiresTimerVisibility));
    }

    /// <summary>Gets whether the needy warning sound effect plays when 5 seconds or less remain. Needy Only.</summary>
    // ReSharper disable NullableWarningSuppressionIsUsed
    [PublicAPI]
    public PropMay<bool> NeedyWarnAtFiveSeconds
    {
        [Pure]
        get =>
            _needyWarnAtFiveSeconds ??= new(
                Value,
                nameof(KMNeedyModule.WarnAtFiveSeconds),
                _ => IsNeedy && ((NeedyTimer)VanillaTimer.Core()!).WarnTime is 5
            );
    }

    /// <summary>Gets the amount of time on the needy timer whenever this module is activated. Needy Only.</summary>
    [PublicAPI]
    public PropMay<float> NeedyStartingTime
    {
        [Pure] get => _needyStartingTime ??= new(Value, nameof(KMNeedyModule.CountdownTime));
    }

    /// <summary>Gets the minimum delay for the needy to activate. Needy Only.</summary>
    [PublicAPI]
    public PropMay<float> NeedyMinResetInterval
    {
        [Pure] get => _needyMinResetInterval ??= new(Value, nameof(KMNeedyModule.ResetDelayMin));
    }

    /// <summary>Gets the maximum delay for the needy to activate. Needy Only.</summary>
    [PublicAPI]
    public PropMay<float> NeedyMaxResetInterval
    {
        [Pure] get => _needyMaxResetInterval ??= new(Value, nameof(KMNeedyModule.ResetDelayMax));
    }

    /// <summary>
    /// Gets the identifier for the module as referenced in missions. e.g. "BigButton" Also known as a "Module ID".
    /// This value is immutable for vanilla modules.
    /// </summary>
    [PublicAPI]
    public PropDef<string> Id
    {
        [Pure] get => _id ??= new(Value, nameof(KMBombModule.ModuleType), o => $"{((BombComponent)o).ComponentType}");
    }

    /// <summary>
    /// Gets the nice display name shown to players. e.g. "The Button". This value is immutable for vanilla modules.
    /// </summary>
    [PublicAPI]
    public PropDef<string> Name
    {
        [Pure]
        get =>
            _name ??= new(
                Value,
                nameof(KMBombModule.ModuleDisplayName),
                o => ((BombComponent)o).GetModuleDisplayName()
            );
    }

    /// <summary>
    /// Gets the <see cref="Action"/> that is invoked when the lights turn on.
    /// This value is immutable for vanilla modules.
    /// </summary>
    [PublicAPI]
    public HookDef<Action> Activate
    {
        [Pure] get => _activate ??= new(Value, nameof(KMBombModule.OnActivate), o => ((BombComponent)o).Activate);
    }

    /// <summary>Gets the <see cref="Action"/> that is invoked when the needy activates. Modded Needy Only.</summary>
    [PublicAPI]
    public HookMay<Action> NeedyActivate
    {
        [Pure] get => _needyActivate ??= new(Value, nameof(KMNeedyModule.OnNeedyActivation));
    }

    /// <summary>Gets the <see cref="Action"/> that is invoked when the needy deactivates. Modded Needy Only.</summary>
    [PublicAPI]
    public HookMay<Action> NeedyDeactivate
    {
        [Pure] get => _needyDeactivate ??= new(Value, nameof(KMNeedyModule.OnNeedyActivation));
    }

    /// <summary>
    /// Gets the <see cref="Action"/> that is invoked when the needy timer expires. Modded Needy Only.
    /// </summary>
    [PublicAPI]
    public HookMay<Action> NeedyTimerExpired
    {
        [Pure] get => _needyTimerExpired ??= new(Value, nameof(KMNeedyModule.OnTimerExpired));
    }

    /// <summary>Gets the <see cref="Action"/> that is called when the entire module has been solved.</summary>
    [PublicAPI]
    public HookDef<Action> Solve
    {
        [Pure] get => _solve ??= new(Value, nameof(KMBombModule.OnPass));
    }

    /// <summary>Gets the <see cref="Action"/> that is called on any mistake that causes a bomb strike.</summary>
    [PublicAPI]
    public HookDef<Action> Strike
    {
        [Pure] get => _strike ??= new(Value, nameof(KMBombModule.OnStrike));
    }

    /// <summary>
    /// Gets a <see cref="Action{T}"/> that when called, sets the time remaining to the parameter passed in.
    /// This value is immutable for vanilla modules. Needy Only.
    /// </summary>
    [PublicAPI]
    public HookMay<Action<float>> NeedyTimerSet
    {
        [Pure]
        get =>
            _needyTimerSet ??= new(
                Value,
                nameof(KMNeedyModule.SetNeedyTimeRemainingHandler),
                _ => IsNeedy ? f => ((NeedyTimer)VanillaTimer.Core()!).TimeRemaining = f : null!,
                a => _ => a()
            );
    }

    /// <summary>
    /// Gets a <see cref="Func{TResult}"/> that when called,
    /// gets the random seed used to generate the rules for this game.
    /// Not currently used. Modded Only.
    /// </summary>
    [PublicAPI]
    public HookMay<Func<int>> RuleGeneration
    {
        [Pure]
        get =>
            _ruleGeneration ??= new(
                Value,
                nameof(KMBombModule.GetRuleGenerationSeedHandler),
                converter: a => () =>
                {
                    a();
                    return 1;
                }
            );
    }

    /// <summary>
    /// Gets a <see cref="Func{TResult}"/> that when called, gets the time remaining.
    /// This value is immutable for vanilla modules. Needy Only.
    /// </summary>
    [PublicAPI]
    public HookMay<Func<float>> NeedyTimerGet
    {
        [Pure]
        get =>
            _needyTimerGet ??= new(
                Value,
                nameof(KMNeedyModule.SetNeedyTimeRemainingHandler),
                _ => IsNeedy ? () => ((NeedyTimer)VanillaTimer.Core()!).TimeRemaining : null!,
                a => () =>
                {
                    a();
                    return IsVanilla ? VanillaTime(Value) : 0;
                }
            );
    } // ReSharper restore NullableWarningSuppressionIsUsed

    /// <summary>Adds the parameter values to the corresponding hooks, when applicable.</summary>
    /// <param name="activate">Invoked when the lights turn on.</param>
    /// <param name="solve">Invoked when the entire module has been solved.</param>
    /// <param name="strike">Invoked on any mistake that causes a bomb strike.</param>
    /// <param name="needyActivate">Invoked when the needy activates.</param>
    /// <param name="needyDeactivate">Invoked when the needy deactivates.</param>
    /// <param name="needyTimerExpired">Invoked when the needy timer expires.</param>
    /// <param name="needyTimerSet">Invoked to set the time of the needy timer.</param>
    /// <param name="ruleGeneration">Invoked to get the random seed used to generate rules for the game.</param>
    /// <param name="needyTimerGet">Invoked to get the time remaining of the needy timer.</param>
    /// <returns>Itself.</returns>
    // ReSharper disable MethodOverloadWithOptionalParameter
    public Entity Add(
        [AllowNull, CanBeNull] Action activate = null,
        [AllowNull, CanBeNull] Action solve = null,
        [AllowNull, CanBeNull] Action strike = null,
        [AllowNull, CanBeNull] Action needyActivate = null,
        [AllowNull, CanBeNull] Action needyDeactivate = null,
        [AllowNull, CanBeNull] Action needyTimerExpired = null,
        [AllowNull, CanBeNull] Action needyTimerSet = null,
        [AllowNull, CanBeNull] Action ruleGeneration = null,
        [AllowNull, CanBeNull] Action needyTimerGet = null
    )
    {
        Solve.Add(solve);
        Strike.Add(strike);
        Activate.Add(activate);
        NeedyActivate.TryAdd(needyActivate);
        NeedyTimerGet.TryAdd(needyTimerGet);
        NeedyTimerSet.TryAdd(needyTimerSet);
        RuleGeneration.TryAdd(ruleGeneration);
        NeedyDeactivate.TryAdd(needyDeactivate);
        NeedyTimerExpired.TryAdd(needyTimerExpired);
        return this;
    }

    /// <summary>Sets the parameter values to the corresponding hooks, when applicable.</summary>
    /// <inheritdoc cref="Add(Action, Action, Action, Action, Action, Action, Action, Action, Action"/>
    public Entity Set(
        [AllowNull, CanBeNull] Action activate = null,
        [AllowNull, CanBeNull] Action solve = null,
        [AllowNull, CanBeNull] Action strike = null,
        [AllowNull, CanBeNull] Action needyActivate = null,
        [AllowNull, CanBeNull] Action needyDeactivate = null,
        [AllowNull, CanBeNull] Action needyTimerExpired = null,
        [AllowNull, CanBeNull] Action needyTimerSet = null,
        [AllowNull, CanBeNull] Action ruleGeneration = null,
        [AllowNull, CanBeNull] Action needyTimerGet = null
    )
    {
        Solve.Set(solve);
        Strike.Set(strike);
        Activate.Set(activate);
        NeedyActivate.TrySet(needyActivate);
        NeedyTimerGet.TrySet(needyTimerGet);
        NeedyTimerSet.TrySet(needyTimerSet);
        RuleGeneration.TrySet(ruleGeneration);
        NeedyDeactivate.TrySet(needyDeactivate);
        NeedyTimerExpired.TrySet(needyTimerExpired);
        return this;
    }

    /// <summary>Removes the parameter values to the corresponding hooks, when applicable.</summary>
    /// <inheritdoc cref="Add(Action, Action, Action, Action, Action, Action, Action, Action, Action)"/>
    public Entity Remove(
        [AllowNull, CanBeNull] Action activate = null,
        [AllowNull, CanBeNull] Action solve = null,
        [AllowNull, CanBeNull] Action strike = null,
        [AllowNull, CanBeNull] Action needyActivate = null,
        [AllowNull, CanBeNull] Action needyDeactivate = null,
        [AllowNull, CanBeNull] Action needyTimerExpired = null,
        [AllowNull, CanBeNull] Action needyTimerSet = null,
        [AllowNull, CanBeNull] Action ruleGeneration = null,
        [AllowNull, CanBeNull] Action needyTimerGet = null
    )
    {
        Solve.Remove(solve);
        Strike.Remove(strike);
        Activate.Remove(activate);
        NeedyActivate.TryRemove(needyActivate);
        NeedyTimerGet.TryRemove(needyTimerGet);
        NeedyTimerSet.TryRemove(needyTimerSet);
        RuleGeneration.TryRemove(ruleGeneration);
        NeedyDeactivate.TryRemove(needyDeactivate);
        NeedyTimerExpired.TryRemove(needyTimerExpired);
        return this;
    }

    /// <summary>Adds the parameter values to the corresponding hooks, when applicable.</summary>
    /// <param name="needyTimerSet">Invoked to set the time of the needy timer.</param>
    /// <param name="ruleGeneration">Invoked to get the random seed used to generate rules for the game.</param>
    /// <param name="needyTimerGet">Invoked to get the time remaining of the needy timer.</param>
    /// <returns>Itself.</returns>
    public Entity Add(
        [AllowNull, CanBeNull] Action<float> needyTimerSet = null,
        [AllowNull, CanBeNull] Func<int> ruleGeneration = null,
        [AllowNull, CanBeNull] Func<float> needyTimerGet = null
    )
    {
        NeedyTimerSet.TryAdd(needyTimerSet);
        RuleGeneration.TryAdd(ruleGeneration);
        NeedyTimerGet.TryAdd(needyTimerGet);
        return this;
    }

    /// <summary>Removes the parameter values to the corresponding hooks, when applicable.</summary>
    /// <inheritdoc cref="Add(Action{float}, Func{int}, Func{float})"/>
    public Entity Remove(
        [AllowNull, CanBeNull] Action<float> needyTimerSet = null,
        [AllowNull, CanBeNull] Func<int> ruleGeneration = null,
        [AllowNull, CanBeNull] Func<float> needyTimerGet = null
    )
    {
        NeedyTimerSet.TryRemove(needyTimerSet);
        RuleGeneration.TryRemove(ruleGeneration);
        NeedyTimerGet.TryRemove(needyTimerGet);
        return this;
    }

    /// <summary>Sets the parameter values to the corresponding hooks, when applicable.</summary>
    /// <inheritdoc cref="Add(Action{float}, Func{int}, Func{float})"/>
    public Entity Set(
        [AllowNull, CanBeNull] Action needyTimerSet = null,
        [AllowNull, CanBeNull] Action ruleGeneration = null,
        [AllowNull, CanBeNull] Action needyTimerGet = null
    )
    {
        NeedyTimerSet.TrySet(needyTimerSet);
        RuleGeneration.TrySet(ruleGeneration);
        NeedyTimerGet.TrySet(needyTimerGet);
        return this;
    }

    [NonNegativeValue]
    static float VanillaTime([NotNull] MonoBehaviour value) => (value.Core() as NeedyComponent)?.TimeRemaining ?? 0;

    static Modules VanillaType([NotNull] MonoBehaviour value) => (Modules)((BombComponent)value.Core()).ComponentType;
}
