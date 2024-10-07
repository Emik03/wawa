### [wawa.Recall](wawa.Recall.md 'wawa.Recall')

## Entity Class

Encapsulates a solvable or needy module in either its vanilla or modded counterpart,  
and extends functionality to get or mutate its inner values and events without worrying the kind of module it is.

```csharp
public sealed class Entity :
System.ICloneable,
System.IEquatable<wawa.Recall.Entity>,
System.Collections.Generic.IEqualityComparer<wawa.Recall.Entity>,
wawa.Recall.IVanilla
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Entity

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Entity](Entity.md 'wawa.Recall.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[Entity](Entity.md 'wawa.Recall.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1'), [IVanilla](IVanilla.md 'wawa.Recall.IVanilla')

| Constructors | |
| :--- | :--- |
| [Entity(KMBombModule)](Entity..ctor(KMBombModule).md 'wawa.Recall.Entity.Entity(KMBombModule)') | Initializes a new instance of the [Entity](Entity.md 'wawa.Recall.Entity') class.<br/>This guarantees the module kind solvable and modded. |
| [Entity(KMNeedyModule)](Entity..ctor(KMNeedyModule).md 'wawa.Recall.Entity.Entity(KMNeedyModule)') | Initializes a new instance of the [Entity](Entity.md 'wawa.Recall.Entity') class. This guarantees the module kind needy and modded. |

| Properties | |
| :--- | :--- |
| [Activate](Entity.Activate.md 'wawa.Recall.Entity.Activate') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is invoked when the lights turn on.<br/>This value is immutable for vanilla modules. |
| [Id](Entity.Id.md 'wawa.Recall.Entity.Id') | Gets the identifier for the module as referenced in missions. e.g. "BigButton" Also known as a "Module ID".<br/>This value is immutable for vanilla modules. |
| [IsEmptyOrTimer](Entity.IsEmptyOrTimer.md 'wawa.Recall.Entity.IsEmptyOrTimer') | Gets a value indicating whether this instance is a non-module;<br/>either [Empty](Modules.md#wawa.Recall.Modules.Empty 'wawa.Recall.Modules.Empty') or [Timer](Modules.md#wawa.Recall.Modules.Timer 'wawa.Recall.Modules.Timer'). |
| [IsModded](Entity.IsModded.md 'wawa.Recall.Entity.IsModded') | Gets a value indicating whether this instance contains a modded module. |
| [IsModdedNeedy](Entity.IsModdedNeedy.md 'wawa.Recall.Entity.IsModdedNeedy') | Gets a value indicating whether this instance contains a modded needy module. |
| [IsModdedSolvable](Entity.IsModdedSolvable.md 'wawa.Recall.Entity.IsModdedSolvable') | Gets a value indicating whether this instance contains a modded solvable module. |
| [IsModule](Entity.IsModule.md 'wawa.Recall.Entity.IsModule') | Gets a value indicating whether this instance is a module;<br/>not [Empty](Modules.md#wawa.Recall.Modules.Empty 'wawa.Recall.Modules.Empty') or [Timer](Modules.md#wawa.Recall.Modules.Timer 'wawa.Recall.Modules.Timer'). |
| [IsNeedy](Entity.IsNeedy.md 'wawa.Recall.Entity.IsNeedy') | Gets a value indicating whether this instance contains a needy module. |
| [IsSolvable](Entity.IsSolvable.md 'wawa.Recall.Entity.IsSolvable') | Gets a value indicating whether this instance contains a solvable module. |
| [IsVanilla](Entity.IsVanilla.md 'wawa.Recall.Entity.IsVanilla') | Gets a value indicating whether this instance contains a vanilla component. |
| [IsVanillaModule](Entity.IsVanillaModule.md 'wawa.Recall.Entity.IsVanillaModule') | Gets a value indicating whether this instance contains a vanilla module. |
| [IsVanillaNeedy](Entity.IsVanillaNeedy.md 'wawa.Recall.Entity.IsVanillaNeedy') | Gets a value indicating whether this instance contains a vanilla needy. |
| [IsVanillaSolvable](Entity.IsVanillaSolvable.md 'wawa.Recall.Entity.IsVanillaSolvable') | Gets a value indicating whether this instance contains a vanilla solvable. |
| [Kind](Entity.Kind.md 'wawa.Recall.Entity.Kind') | Gets the type of component, to differentiate the different kinds of vanilla modules.<br/>Modded modules are grouped as [Mod](Modules.md#wawa.Recall.Modules.Mod 'wawa.Recall.Modules.Mod') or [NeedyMod](Modules.md#wawa.Recall.Modules.NeedyMod 'wawa.Recall.Modules.NeedyMod') depending on type. |
| [Name](Entity.Name.md 'wawa.Recall.Entity.Name') | Gets the nice display name shown to players. e.g. "The Button". This value is immutable for vanilla modules. |
| [Needy](Entity.Needy.md 'wawa.Recall.Entity.Needy') | Gets the encapsulated [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule') from this instance, if it exists. |
| [NeedyActivate](Entity.NeedyActivate.md 'wawa.Recall.Entity.NeedyActivate') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is invoked when the needy activates. Modded Needy Only. |
| [NeedyDeactivate](Entity.NeedyDeactivate.md 'wawa.Recall.Entity.NeedyDeactivate') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is invoked when the needy deactivates. Modded Needy Only. |
| [NeedyMaxResetInterval](Entity.NeedyMaxResetInterval.md 'wawa.Recall.Entity.NeedyMaxResetInterval') | Gets the maximum delay for the needy to activate. Needy Only. |
| [NeedyMinResetInterval](Entity.NeedyMinResetInterval.md 'wawa.Recall.Entity.NeedyMinResetInterval') | Gets the minimum delay for the needy to activate. Needy Only. |
| [NeedyStartingTime](Entity.NeedyStartingTime.md 'wawa.Recall.Entity.NeedyStartingTime') | Gets the amount of time on the needy timer whenever this module is activated. Needy Only. |
| [NeedyTimerExpired](Entity.NeedyTimerExpired.md 'wawa.Recall.Entity.NeedyTimerExpired') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is invoked when the needy timer expires. Modded Needy Only. |
| [NeedyTimerGet](Entity.NeedyTimerGet.md 'wawa.Recall.Entity.NeedyTimerGet') | Gets a [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1') that when called, gets the time remaining.<br/>This value is immutable for vanilla modules. Needy Only. |
| [NeedyTimerSet](Entity.NeedyTimerSet.md 'wawa.Recall.Entity.NeedyTimerSet') | Gets a [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1') that when called, sets the time remaining to the parameter passed in.<br/>This value is immutable for vanilla modules. Needy Only. |
| [NeedyWarnAtFiveSeconds](Entity.NeedyWarnAtFiveSeconds.md 'wawa.Recall.Entity.NeedyWarnAtFiveSeconds') | Gets whether the needy warning sound effect plays when 5 seconds or less remain. Needy Only. |
| [RequiresTimerVisibility](Entity.RequiresTimerVisibility.md 'wawa.Recall.Entity.RequiresTimerVisibility') | Gets whether to only allow this module to be placed on the same face as the timer.<br/>Useful when the rules involve the timer in some way (like the Big Button),<br/>but should be used sparingly as it limits generation possibilities. |
| [RuleGeneration](Entity.RuleGeneration.md 'wawa.Recall.Entity.RuleGeneration') | Gets a [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1') that when called, gets the random seed<br/>used to generate the rules for this game. Not currently used. Modded Only. |
| [Solvable](Entity.Solvable.md 'wawa.Recall.Entity.Solvable') | Gets the encapsulated [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') from this instance, if it exists. |
| [Solve](Entity.Solve.md 'wawa.Recall.Entity.Solve') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is called when the entire module has been solved. |
| [Strike](Entity.Strike.md 'wawa.Recall.Entity.Strike') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is called on any mistake that causes a bomb strike. |
| [Value](Entity.Value.md 'wawa.Recall.Entity.Value') | Gets the value which is guaranteed to be a [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour'). |
| [Vanilla](Entity.Vanilla.md 'wawa.Recall.Entity.Vanilla') | Gets the encapsulated BombComponent from this instance, if it exists. |

| Methods | |
| :--- | :--- |
| [FromComponent(Component)](Entity.FromComponent(Component).md 'wawa.Recall.Entity.FromComponent(Component)') | Gets the [Entity](Entity.md 'wawa.Recall.Entity') of this [Selected](Selected.md 'wawa.Recall.Selected').<br/>An empty value is given if there is no attached [Entity](Entity.md 'wawa.Recall.Entity') on the [Selected](Selected.md 'wawa.Recall.Selected').<br/><p/>`[MustUseReturnValue]` |
| [FromKMBombModule(KMBombModule)](Entity.FromKMBombModule(KMBombModule).md 'wawa.Recall.Entity.FromKMBombModule(KMBombModule)') | Converts the [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Entity](Entity.md 'wawa.Recall.Entity'). |
| [FromKMNeedyModule(KMNeedyModule)](Entity.FromKMNeedyModule(KMNeedyModule).md 'wawa.Recall.Entity.FromKMNeedyModule(KMNeedyModule)') | Converts the [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Entity](Entity.md 'wawa.Recall.Entity'). |
| [GetChildren(GameObject)](Entity.GetChildren(GameObject).md 'wawa.Recall.Entity.GetChildren(GameObject)') | Gets all modules that are children of a provided [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject'), and caches it in a thread-safe manner.<br/><p/>`[MustUseReturnValue]` |
| [LogEverything()](Entity.LogEverything.md 'wawa.Recall.Entity.LogEverything()') | Hooks the logger to all instances. |

| Operators | |
| :--- | :--- |
| [operator ==(Entity, Entity)](Entity.op_Equality(Entity,Entity).md 'wawa.Recall.Entity.op_Equality(wawa.Recall.Entity, wawa.Recall.Entity)') | Determines whether both instances point to the same component. |
| [implicit operator Entity(KMBombModule)](Entity.Entity(KMBombModule).md 'wawa.Recall.Entity.op_Implicit wawa.Recall.Entity(KMBombModule)') | Implicitly calls the constructor. |
| [implicit operator Entity(KMNeedyModule)](Entity.Entity(KMNeedyModule).md 'wawa.Recall.Entity.op_Implicit wawa.Recall.Entity(KMNeedyModule)') | Implicitly calls the constructor. |
| [operator !=(Entity, Entity)](Entity.op_Inequality(Entity,Entity).md 'wawa.Recall.Entity.op_Inequality(wawa.Recall.Entity, wawa.Recall.Entity)') | Determines whether both instances do not point to the same component. |
