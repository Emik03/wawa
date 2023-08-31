### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks')

## Entity Class

Encapsulates a solvable or needy module in either its vanilla or modded counterpart,  
and extends functionality to get or mutate its inner values and events without worrying the kind of module it is.

```csharp
public sealed class Entity :
System.ICloneable,
System.IEquatable<Wawa.Callbacks.Entity>,
System.Collections.Generic.IEqualityComparer<Wawa.Callbacks.Entity>,
Wawa.Callbacks.IVanilla,
System.IEquatable<object>,
Wawa.Callbacks.IValued<MonoBehaviour>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Entity

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Entity](Entity.md 'Wawa.Callbacks.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[Entity](Entity.md 'Wawa.Callbacks.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1'), [IVanilla](IVanilla.md 'Wawa.Callbacks.IVanilla'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [Wawa.Callbacks.IValued&lt;](IValued{T}.md 'Wawa.Callbacks.IValued<T>')[UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour')[&gt;](IValued{T}.md 'Wawa.Callbacks.IValued<T>')

| Constructors | |
| :--- | :--- |
| [Entity(KMBombModule)](Entity..ctor(KMBombModule).md 'Wawa.Callbacks.Entity.Entity(KMBombModule)') | Initializes a new instance of the [Entity](Entity.md 'Wawa.Callbacks.Entity') class.<br/>This guarantees the module kind solvable and modded. |
| [Entity(KMNeedyModule)](Entity..ctor(KMNeedyModule).md 'Wawa.Callbacks.Entity.Entity(KMNeedyModule)') | Initializes a new instance of the [Entity](Entity.md 'Wawa.Callbacks.Entity') class. This guarantees the module kind needy and modded. |

| Properties | |
| :--- | :--- |
| [Activate](Entity.Activate.md 'Wawa.Callbacks.Entity.Activate') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is invoked when the lights turn on.<br/>This value is immutable for vanilla modules. |
| [Id](Entity.Id.md 'Wawa.Callbacks.Entity.Id') | Gets the identifier for the module as referenced in missions. e.g. "BigButton" Also known as a "Module ID".<br/>This value is immutable for vanilla modules. |
| [IsEmptyOrTimer](Entity.IsEmptyOrTimer.md 'Wawa.Callbacks.Entity.IsEmptyOrTimer') | Gets a value indicating whether this instance is a non-module;<br/>either [Empty](Modules.md#Wawa.Callbacks.Modules.Empty 'Wawa.Callbacks.Modules.Empty') or [Timer](Modules.md#Wawa.Callbacks.Modules.Timer 'Wawa.Callbacks.Modules.Timer'). |
| [IsModded](Entity.IsModded.md 'Wawa.Callbacks.Entity.IsModded') | Gets a value indicating whether this instance contains a modded module. |
| [IsModdedNeedy](Entity.IsModdedNeedy.md 'Wawa.Callbacks.Entity.IsModdedNeedy') | Gets a value indicating whether this instance contains a modded needy module. |
| [IsModdedSolvable](Entity.IsModdedSolvable.md 'Wawa.Callbacks.Entity.IsModdedSolvable') | Gets a value indicating whether this instance contains a modded solvable module. |
| [IsModule](Entity.IsModule.md 'Wawa.Callbacks.Entity.IsModule') | Gets a value indicating whether this instance is a module;<br/>not [Empty](Modules.md#Wawa.Callbacks.Modules.Empty 'Wawa.Callbacks.Modules.Empty') or [Timer](Modules.md#Wawa.Callbacks.Modules.Timer 'Wawa.Callbacks.Modules.Timer'). |
| [IsNeedy](Entity.IsNeedy.md 'Wawa.Callbacks.Entity.IsNeedy') | Gets a value indicating whether this instance contains a needy module. |
| [IsSolvable](Entity.IsSolvable.md 'Wawa.Callbacks.Entity.IsSolvable') | Gets a value indicating whether this instance contains a solvable module. |
| [IsVanilla](Entity.IsVanilla.md 'Wawa.Callbacks.Entity.IsVanilla') | Gets a value indicating whether this instance contains a vanilla component. |
| [IsVanillaModule](Entity.IsVanillaModule.md 'Wawa.Callbacks.Entity.IsVanillaModule') | Gets a value indicating whether this instance contains a vanilla module. |
| [IsVanillaNeedy](Entity.IsVanillaNeedy.md 'Wawa.Callbacks.Entity.IsVanillaNeedy') | Gets a value indicating whether this instance contains a vanilla needy. |
| [IsVanillaSolvable](Entity.IsVanillaSolvable.md 'Wawa.Callbacks.Entity.IsVanillaSolvable') | Gets a value indicating whether this instance contains a vanilla solvable. |
| [Kind](Entity.Kind.md 'Wawa.Callbacks.Entity.Kind') | Gets the type of component, to differentiate the different kinds of vanilla modules.<br/>Modded modules are grouped as [Mod](Modules.md#Wawa.Callbacks.Modules.Mod 'Wawa.Callbacks.Modules.Mod') or [NeedyMod](Modules.md#Wawa.Callbacks.Modules.NeedyMod 'Wawa.Callbacks.Modules.NeedyMod') depending on type. |
| [Name](Entity.Name.md 'Wawa.Callbacks.Entity.Name') | Gets the nice display name shown to players. e.g. "The Button". This value is immutable for vanilla modules. |
| [Needy](Entity.Needy.md 'Wawa.Callbacks.Entity.Needy') | Gets the encapsulated [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule') from this instance, if it exists. |
| [NeedyActivate](Entity.NeedyActivate.md 'Wawa.Callbacks.Entity.NeedyActivate') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is invoked when the needy activates. Modded Needy Only. |
| [NeedyDeactivate](Entity.NeedyDeactivate.md 'Wawa.Callbacks.Entity.NeedyDeactivate') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is invoked when the needy deactivates. Modded Needy Only. |
| [NeedyMaxResetInterval](Entity.NeedyMaxResetInterval.md 'Wawa.Callbacks.Entity.NeedyMaxResetInterval') | Gets the maximum delay for the needy to activate. Needy Only. |
| [NeedyMinResetInterval](Entity.NeedyMinResetInterval.md 'Wawa.Callbacks.Entity.NeedyMinResetInterval') | Gets the minimum delay for the needy to activate. Needy Only. |
| [NeedyStartingTime](Entity.NeedyStartingTime.md 'Wawa.Callbacks.Entity.NeedyStartingTime') | Gets the amount of time on the needy timer whenever this module is activated. Needy Only. |
| [NeedyTimerExpired](Entity.NeedyTimerExpired.md 'Wawa.Callbacks.Entity.NeedyTimerExpired') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is invoked when the needy timer expires. Modded Needy Only. |
| [NeedyTimerGet](Entity.NeedyTimerGet.md 'Wawa.Callbacks.Entity.NeedyTimerGet') | Gets a [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1') that when called, gets the time remaining.<br/>This value is immutable for vanilla modules. Needy Only. |
| [NeedyTimerSet](Entity.NeedyTimerSet.md 'Wawa.Callbacks.Entity.NeedyTimerSet') | Gets a [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1') that when called, sets the time remaining to the parameter passed in.<br/>This value is immutable for vanilla modules. Needy Only. |
| [NeedyWarnAtFiveSeconds](Entity.NeedyWarnAtFiveSeconds.md 'Wawa.Callbacks.Entity.NeedyWarnAtFiveSeconds') | Gets whether the needy warning sound effect plays when 5 seconds or less remain. Needy Only. |
| [RequiresTimerVisibility](Entity.RequiresTimerVisibility.md 'Wawa.Callbacks.Entity.RequiresTimerVisibility') | Gets whether to only allow this module to be placed on the same face as the timer.<br/>Useful when the rules involve the timer in some way (like the Big Button),<br/>but should be used sparingly as it limits generation possibilities. |
| [RuleGeneration](Entity.RuleGeneration.md 'Wawa.Callbacks.Entity.RuleGeneration') | Gets a [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1') that when called, gets the random seed<br/>used to generate the rules for this game. Not currently used. Modded Only. |
| [Solvable](Entity.Solvable.md 'Wawa.Callbacks.Entity.Solvable') | Gets the encapsulated [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') from this instance, if it exists. |
| [Solve](Entity.Solve.md 'Wawa.Callbacks.Entity.Solve') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is called when the entire module has been solved. |
| [Strike](Entity.Strike.md 'Wawa.Callbacks.Entity.Strike') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is called on any mistake that causes a bomb strike. |
| [Value](Entity.Value.md 'Wawa.Callbacks.Entity.Value') | Gets the value which is guaranteed to be a [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour'). |
| [Vanilla](Entity.Vanilla.md 'Wawa.Callbacks.Entity.Vanilla') | Gets the encapsulated BombComponent from this instance, if it exists. |

| Methods | |
| :--- | :--- |
| [FromComponent(Component)](Entity.FromComponent(Component).md 'Wawa.Callbacks.Entity.FromComponent(Component)') | Gets the [Entity](Entity.md 'Wawa.Callbacks.Entity') of this [Selected](Selected.md 'Wawa.Callbacks.Selected').<br/>An empty value is given if there is no attached [Entity](Entity.md 'Wawa.Callbacks.Entity') on the [Selected](Selected.md 'Wawa.Callbacks.Selected'). |
| [FromKMBombModule(KMBombModule)](Entity.FromKMBombModule(KMBombModule).md 'Wawa.Callbacks.Entity.FromKMBombModule(KMBombModule)') | Converts the [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Entity](Entity.md 'Wawa.Callbacks.Entity'). |
| [FromKMNeedyModule(KMNeedyModule)](Entity.FromKMNeedyModule(KMNeedyModule).md 'Wawa.Callbacks.Entity.FromKMNeedyModule(KMNeedyModule)') | Converts the [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Entity](Entity.md 'Wawa.Callbacks.Entity'). |
| [GetChildren(GameObject)](Entity.GetChildren(GameObject).md 'Wawa.Callbacks.Entity.GetChildren(GameObject)') | Gets all modules that are children of a provided [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject'), and caches it in a thread-safe manner. |
| [LogEverything()](Entity.LogEverything.md 'Wawa.Callbacks.Entity.LogEverything()') | Hooks the logger to all instances. |

| Operators | |
| :--- | :--- |
| [operator ==(Entity, Entity)](Entity.op_Equality(Entity,Entity).md 'Wawa.Callbacks.Entity.op_Equality(Wawa.Callbacks.Entity, Wawa.Callbacks.Entity)') | Determines whether both instances point to the same component. |
| [implicit operator Entity(KMBombModule)](Entity.Entity(KMBombModule).md 'Wawa.Callbacks.Entity.op_Implicit Wawa.Callbacks.Entity(KMBombModule)') | Implicitly calls the constructor. |
| [implicit operator Entity(KMNeedyModule)](Entity.Entity(KMNeedyModule).md 'Wawa.Callbacks.Entity.op_Implicit Wawa.Callbacks.Entity(KMNeedyModule)') | Implicitly calls the constructor. |
| [operator !=(Entity, Entity)](Entity.op_Inequality(Entity,Entity).md 'Wawa.Callbacks.Entity.op_Inequality(Wawa.Callbacks.Entity, Wawa.Callbacks.Entity)') | Determines whether both instances do not point to the same component. |
