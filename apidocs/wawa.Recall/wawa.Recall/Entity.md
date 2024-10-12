# Entity Class

namespace: [wawa\.Recall](../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../wawa.Recall.md)

Encapsulates a solvable or needy module in either its vanilla or modded counterpart,
and extends functionality to get or mutate its inner values and events without worrying the kind of module it is\.

```csharp
public sealed class Entity;
```

Inheritance: `ICloneable` > Entity

Implements: `IEquatable<Entity>`, `IEqualityComparer<Entity>`, [IVanilla](../../wawa.Recall/wawa.Recall/IVanilla.md)

## Remarks



This class has a different definition of what it means to be modded or vanilla than [Highlighted](../../wawa.Recall/wawa.Recall/Highlighted.md) and
[Selected](../../wawa.Recall/wawa.Recall/Selected.md)\. Specifically, if the game is played within the bounds of [IsRewritten](../../wawa.DDL/wawa.DDL/Access/IsRewritten.md), then
`KMBombModule` and `KMNeedyModule` instances that use any reserved name for vanilla modules
are considered vanilla despite their underlying type being modded\. Therefore, you can run into a situation where
[IsVanilla](../../wawa.Recall/wawa.Recall/Entity/IsVanilla.md) is `true` but converting the instance to a [Selected](../../wawa.Recall/wawa.Recall/Selected.md), such as
with the [ToSelectable\(Entity\)](../../wawa.Recall/wawa.Recall/EntityCore/ToSelectable.md) method, will result in its [IsVanilla](../../wawa.Recall/wawa.Recall/Selected/IsVanilla.md) being
`false`\. As counter\-intuitive as this may seem, it must be done for forwards\-compatibility\.
If the other definition is truly required, then accessing [Value](../../wawa.Recall/wawa.Recall/Entity/Value.md) and type\-checking with
`KMBombModule` and/or `KMNeedyModule` will work regardless of which type of game is running\.



## Constructors

| Name | Summary |
|------|---------|
| [Entity\(KMBombModule\)](./Entity/$ctor.md) | Initializes a new instance of the [Entity](../../wawa.Recall/wawa.Recall/Entity.md) class\.This guarantees the module kind solvable and modded\. |
| [Entity\(KMNeedyModule\)](./Entity/$ctor.md) | Initializes a new instance of the [Entity](../../wawa.Recall/wawa.Recall/Entity.md) class\. This guarantees the module kind needy and modded\. |

## Methods

| Name | Summary |
|------|---------|
| [operator ==\(Entity?, Entity?\)](./Entity/op_Equality.md) | Determines whether both instances point to the same component\. |
| [operator \!=\(Entity?, Entity?\)](./Entity/op_Inequality.md) | Determines whether both instances do not point to the same component\. |
| [implicit operator Entity\(KMBombModule\)](./Entity/op_Implicit.md) | Implicitly calls the constructor\. |
| [implicit operator Entity\(KMNeedyModule\)](./Entity/op_Implicit.md) | Implicitly calls the constructor\. |
| [FromKMBombModule\(KMBombModule\)](./Entity/FromKMBombModule.md) | Converts the `KMBombModule` to a `new`[Entity](../../wawa.Recall/wawa.Recall/Entity.md)\. |
| [FromKMNeedyModule\(KMNeedyModule\)](./Entity/FromKMNeedyModule.md) | Converts the `KMNeedyModule` to a `new`[Entity](../../wawa.Recall/wawa.Recall/Entity.md)\. |
| [GetChildren\(GameObject\)](./Entity/GetChildren.md) | Gets all modules that are children of a provided `GameObject`, and caches it in a thread\-safe manner\. |
| [LogEverything\(\)](./Entity/LogEverything.md) | Hooks the logger to all instances\. |
| [FromComponent\(UnityEngine\.Component\)](./Entity/FromComponent.md) | Gets the [Entity](../../wawa.Recall/wawa.Recall/Entity.md) of this `UnityEngine.Component`\.An empty value is given if there is no attached [Entity](../../wawa.Recall/wawa.Recall/Entity.md) on the `UnityEngine.Component`\. |
| [Equals\(Entity?\)](./Entity/Equals.md) |  |
| [Equals\(Entity, Entity\)](./Entity/Equals.md) |  |
| [GetHashCode\(Entity\)](./Entity/GetHashCode.md) |  |
| [Clone\(\)](./Entity/Clone.md) |  |
| [Equals\(object\)](./Entity/Equals.md) |  |
| [GetHashCode\(\)](./Entity/GetHashCode.md) |  |
| [ToString\(\)](./Entity/ToString.md) |  |

## Properties

| Name | Summary |
|------|---------|
| [Value](./Entity/Value.md) | Gets the value which is guaranteed to be a `UnityEngine.MonoBehaviour`\. |
| [IsEmptyOrTimer](./Entity/IsEmptyOrTimer.md) | Gets a value indicating whether this instance is a non\-module;either [Empty](../../wawa.Recall/wawa.Recall/Modules/Empty.md) or [Timer](../../wawa.Recall/wawa.Recall/Modules/Timer.md)\. |
| [IsModded](./Entity/IsModded.md) | Gets a value indicating whether this instance contains a modded module\. |
| [IsModdedNeedy](./Entity/IsModdedNeedy.md) | Gets a value indicating whether this instance contains a modded needy module\. |
| [IsModdedSolvable](./Entity/IsModdedSolvable.md) | Gets a value indicating whether this instance contains a modded solvable module\. |
| [IsModule](./Entity/IsModule.md) | Gets a value indicating whether this instance is a module;not [Empty](../../wawa.Recall/wawa.Recall/Modules/Empty.md) or [Timer](../../wawa.Recall/wawa.Recall/Modules/Timer.md)\. |
| [IsNeedy](./Entity/IsNeedy.md) | Gets a value indicating whether this instance contains a needy module\. |
| [IsSolvable](./Entity/IsSolvable.md) | Gets a value indicating whether this instance contains a solvable module\. |
| [IsVanilla](./Entity/IsVanilla.md) | Gets a value indicating whether this instance contains a vanilla component\. |
| [IsVanillaModule](./Entity/IsVanillaModule.md) | Gets a value indicating whether this instance contains a vanilla module\. |
| [IsVanillaNeedy](./Entity/IsVanillaNeedy.md) | Gets a value indicating whether this instance contains a vanilla needy\. |
| [IsVanillaSolvable](./Entity/IsVanillaSolvable.md) | Gets a value indicating whether this instance contains a vanilla solvable\. |
| [Solvable](./Entity/Solvable.md) | Gets the encapsulated `KMBombModule` from this instance, if it exists\. |
| [Needy](./Entity/Needy.md) | Gets the encapsulated `KMNeedyModule` from this instance, if it exists\. |
| [Vanilla](./Entity/Vanilla.md) | Gets the encapsulated `BombComponent` from this instance, if it exists\. |
| [Kind](./Entity/Kind.md) | Gets the type of component, to differentiate the different kinds of vanilla modules\.Modded modules are grouped as [Mod](../../wawa.Recall/wawa.Recall/Modules/Mod.md) or [NeedyMod](../../wawa.Recall/wawa.Recall/Modules/NeedyMod.md) depending on type\. |
| [RequiresTimerVisibility](./Entity/RequiresTimerVisibility.md) | Gets whether to only allow this module to be placed on the same face as the timer\.Useful when the rules involve the timer in some way \(like the Big Button\),but should be used sparingly as it limits generation possibilities\. |
| [NeedyWarnAtFiveSeconds](./Entity/NeedyWarnAtFiveSeconds.md) | Gets whether the needy warning sound effect plays when 5 seconds or less remain\. Needy Only\. |
| [NeedyStartingTime](./Entity/NeedyStartingTime.md) | Gets the amount of time on the needy timer whenever this module is activated\. Needy Only\. |
| [NeedyMinResetInterval](./Entity/NeedyMinResetInterval.md) | Gets the minimum delay for the needy to activate\. Needy Only\. |
| [NeedyMaxResetInterval](./Entity/NeedyMaxResetInterval.md) | Gets the maximum delay for the needy to activate\. Needy Only\. |
| [Id](./Entity/Id.md) | Gets the identifier for the module as referenced in missions\. e\.g\. "BigButton" Also known as a "Module ID"\.This value is immutable for vanilla modules\. |
| [Name](./Entity/Name.md) | Gets the nice display name shown to players\. e\.g\. "The Button"\. This value is immutable for vanilla modules\. |
| [Activate](./Entity/Activate.md) | Gets the `Action` that is invoked when the lights turn on\.This value is immutable for vanilla modules\. |
| [NeedyActivate](./Entity/NeedyActivate.md) | Gets the `Action` that is invoked when the needy activates\. Modded Needy Only\. |
| [NeedyDeactivate](./Entity/NeedyDeactivate.md) | Gets the `Action` that is invoked when the needy deactivates\. Modded Needy Only\. |
| [NeedyTimerExpired](./Entity/NeedyTimerExpired.md) | Gets the `Action` that is invoked when the needy timer expires\. Modded Needy Only\. |
| [Solve](./Entity/Solve.md) | Gets the `Action` that is called when the entire module has been solved\. |
| [Strike](./Entity/Strike.md) | Gets the `Action` that is called on any mistake that causes a bomb strike\. |
| [NeedyTimerSet](./Entity/NeedyTimerSet.md) | Gets a `Action<T>` that when called, sets the time remaining to the parameter passed in\.This value is immutable for vanilla modules\. Needy Only\. |
| [RuleGeneration](./Entity/RuleGeneration.md) | Gets a `Func<TResult>` that when called, gets the random seedused to generate the rules for this game\. Not currently used\. Modded Only\. |
| [NeedyTimerGet](./Entity/NeedyTimerGet.md) | Gets a `Func<TResult>` that when called, gets the time remaining\.This value is immutable for vanilla modules\. Needy Only\. |

