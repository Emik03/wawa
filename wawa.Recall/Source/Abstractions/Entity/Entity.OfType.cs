﻿// SPDX-License-Identifier: MPL-2.0
namespace wawa.Recall;

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
    HookDef<Action> _activate;

    [CanBeNull]
    HookDef<Func<bool>> _solve, _strike;

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
        [Pure] get => Value is KMNeedyModule;
    }

    /// <summary>Gets a value indicating whether this instance contains a modded solvable module.</summary>
    [PublicAPI]
    public bool IsModdedSolvable
    {
        [Pure] get => Value is KMBombModule;
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

    /// <summary>Gets the encapsulated <see cref="KMBombModule"/> from this instance, if it exists.</summary>
    [CLSCompliant(false), PublicAPI]
    public Maybe<KMBombModule> Solvable
    {
        [Pure] get => Value as KMBombModule;
    }

    /// <summary>Gets the encapsulated <see cref="KMNeedyModule"/> from this instance, if it exists.</summary>
    [CLSCompliant(false), PublicAPI]
    public Maybe<KMNeedyModule> Needy
    {
        [Pure] get => Value as KMNeedyModule;
    }

    /// <summary>Gets the encapsulated BombComponent from this instance, if it exists.</summary>
    [CLSCompliant(false), PublicAPI]
    public Maybe<MonoBehaviour> Vanilla
    {
        [Pure] get => Value is KMBombModule or KMNeedyModule ? default : Value;
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
    [NotNull, PublicAPI]
    public PropDef<bool> RequiresTimerVisibility
    {
        [Pure] get => _requiresTimerVisibility ??= new(Value, nameof(KMBombModule.RequiresTimerVisibility));
    }

    /// <summary>Gets whether the needy warning sound effect plays when 5 seconds or less remain. Needy Only.</summary>
    // ReSharper disable NullableWarningSuppressionIsUsed
    [NotNull, PublicAPI]
    public PropMay<bool> NeedyWarnAtFiveSeconds
    {
        [Pure] get => _needyWarnAtFiveSeconds ??= new(Value, nameof(KMNeedyModule.WarnAtFiveSeconds), IsVanillaWarn);
    }

    /// <summary>Gets the amount of time on the needy timer whenever this module is activated. Needy Only.</summary>
    [NotNull, PublicAPI]
    public PropMay<float> NeedyStartingTime
    {
        [Pure] get => _needyStartingTime ??= new(Value, nameof(KMNeedyModule.CountdownTime));
    }

    /// <summary>Gets the minimum delay for the needy to activate. Needy Only.</summary>
    [NotNull, PublicAPI]
    public PropMay<float> NeedyMinResetInterval
    {
        [Pure] get => _needyMinResetInterval ??= new(Value, nameof(KMNeedyModule.ResetDelayMin));
    }

    /// <summary>Gets the maximum delay for the needy to activate. Needy Only.</summary>
    [NotNull, PublicAPI]
    public PropMay<float> NeedyMaxResetInterval
    {
        [Pure] get => _needyMaxResetInterval ??= new(Value, nameof(KMNeedyModule.ResetDelayMax));
    }

    /// <summary>
    /// Gets the identifier for the module as referenced in missions. e.g. "BigButton" Also known as a "Module ID".
    /// This value is immutable for vanilla modules.
    /// </summary>
    [NotNull, PublicAPI]
    public PropDef<string> Id
    {
        [Pure] get => _id ??= new(Value, nameof(KMBombModule.ModuleType), Typed);
    }

    /// <summary>
    /// Gets the nice display name shown to players. e.g. "The Button". This value is immutable for vanilla modules.
    /// </summary>
    [NotNull, PublicAPI]
    public PropDef<string> Name
    {
        [Pure] get => _name ??= new(Value, nameof(KMBombModule.ModuleDisplayName), Named);
    }

    /// <summary>
    /// Gets the <see cref="Action"/> that is invoked when the lights turn on.
    /// This value is immutable for vanilla modules.
    /// </summary>
    [NotNull, PublicAPI]
    public HookDef<Action> Activate
    {
        [Pure] get => _activate ??= new(Value, nameof(KMBombModule.OnActivate), Activator);
    }

    /// <summary>Gets the <see cref="Action"/> that is invoked when the needy activates. Modded Needy Only.</summary>
    [NotNull, PublicAPI]
    public HookMay<Action> NeedyActivate
    {
        [Pure] get => _needyActivate ??= new(Value, nameof(KMNeedyModule.OnNeedyActivation));
    }

    /// <summary>Gets the <see cref="Action"/> that is invoked when the needy deactivates. Modded Needy Only.</summary>
    [NotNull, PublicAPI]
    public HookMay<Action> NeedyDeactivate
    {
        [Pure] get => _needyDeactivate ??= new(Value, nameof(KMNeedyModule.OnNeedyActivation));
    }

    /// <summary>
    /// Gets the <see cref="Action"/> that is invoked when the needy timer expires. Modded Needy Only.
    /// </summary>
    [NotNull, PublicAPI]
    public HookMay<Action> NeedyTimerExpired
    {
        [Pure] get => _needyTimerExpired ??= new(Value, nameof(KMNeedyModule.OnTimerExpired));
    }

    /// <summary>Gets the <see cref="Action"/> that is called when the entire module has been solved.</summary>
    [NotNull, PublicAPI]
    public HookDef<Func<bool>> Solve
    {
        [Pure] get => _solve ??= new(Value, nameof(KMBombModule.OnPass), converter: False);
    }

    /// <summary>Gets the <see cref="Action"/> that is called on any mistake that causes a bomb strike.</summary>
    [NotNull, PublicAPI]
    public HookDef<Func<bool>> Strike
    {
        [Pure] get => _strike ??= new(Value, nameof(KMBombModule.OnStrike), converter: False);
    }

    /// <summary>
    /// Gets a <see cref="Action{T}"/> that when called, sets the time remaining to the parameter passed in.
    /// This value is immutable for vanilla modules. Needy Only.
    /// </summary>
    [NotNull, PublicAPI]
    public HookMay<Action<float>> NeedyTimerSet
    {
        [Pure]
        get => _needyTimerSet ??= new(Value, nameof(KMNeedyModule.SetNeedyTimeRemainingHandler), Setter, Invoke<float>);
    }

    /// <summary>
    /// Gets a <see cref="Func{TResult}"/> that when called, gets the random seed
    /// used to generate the rules for this game. Not currently used. Modded Only.
    /// </summary>
    [NotNull, PublicAPI]
    public HookMay<Func<int>> RuleGeneration
    {
        [Pure] get => _ruleGeneration ??= new(Value, nameof(KMBombModule.GetRuleGenerationSeedHandler), converter: One);
    }

    /// <summary>
    /// Gets a <see cref="Func{TResult}"/> that when called, gets the time remaining.
    /// This value is immutable for vanilla modules. Needy Only.
    /// </summary>
    [NotNull, PublicAPI]
    public HookMay<Func<float>> NeedyTimerGet
    {
        [Pure]
        get => _needyTimerGet ??= new(Value, nameof(KMNeedyModule.SetNeedyTimeRemainingHandler), Getter, GetHandler);
    }

    [NonNegativeValue, Pure]
    static float VanillaTime([NotNull] MonoBehaviour value) => (value.Core() as NeedyComponent)?.TimeRemaining ?? 0;

    [NotNull, Pure]
    static string Named([NotNull] object o) => ((BombComponent)o).GetModuleDisplayName();

    [NotNull, Pure]
    static string Typed([NotNull] object o) => $"{((BombComponent)o).ComponentType}";

    [NotNull, Pure]
    static Action Activator([NotNull] object o) => ((BombComponent)o).Activate;

    [NotNull, Pure]
    static Func<int> One([NotNull] Action a) =>
        () =>
        {
            a();
            return 1;
        };

    [Pure]
    static Modules VanillaType([NotNull] MonoBehaviour value) => (Modules)((BombComponent)value.Core()).ComponentType;

    [Pure]
    bool IsVanillaWarn([NotNull] object _) => IsNeedy && ((NeedyTimer)VanillaTimer!.Core()).WarnTime is 5;

    [NotNull, Pure]
    Action<float> Setter([NotNull] object _) =>
        (IsNeedy ? f => ((NeedyTimer)VanillaTimer!.Core()).TimeRemaining = f : null!)!;

    [NotNull, Pure]
    Func<float> GetHandler([NotNull] Action a) =>
        () =>
        {
            a();
            return IsVanilla ? VanillaTime(Value) : 0;
        };

    [NotNull, Pure]
    Func<float> Getter([NotNull] object _) =>
        (IsNeedy ? () => ((NeedyTimer)VanillaTimer!.Core()).TimeRemaining : null)!;
}
