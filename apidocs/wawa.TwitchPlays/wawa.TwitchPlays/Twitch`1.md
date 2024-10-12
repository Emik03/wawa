# Twitch\<TMod\> Class

namespace: [wawa\.TwitchPlays](../wawa.TwitchPlays.md)<br />
assembly: [wawa\.TwitchPlays](../../wawa.TwitchPlays.md)

Base class for TwitchPlays support for solvable and needy modded modules in Keep Talking and Nobody Explodes\.

```csharp
public abstract class Twitch<TMod>;
```

## Type Parameters

__TMod__ : [ModdedModule](../../wawa.Modules/wawa.Modules/ModdedModule.md)

The `Type` of `Mod` to implement Twitch Plays support for\.


Inheritance: `MonoBehaviour` > [CachedBehaviour](../../wawa.Unity/wawa.Unity/CachedBehaviour.md) > Twitch<TMod>

Implements: `ITwitchMutable`

## Methods

| Name | Summary |
|------|---------|
| [Awake\(\)](./Twitch\`1/Awake.md) | Logs version numbers and automatically sets [Help](../../wawa.TwitchPlays/wawa.TwitchPlays/Twitch\`1/Help.md)\.Be sure to call this method if you are implementing Awake\. |
| [ProcessTwitchCommand\(string\)](./Twitch\`1/ProcessTwitchCommand.md) | This method gets grabbed by Twitch Plays to process a user command\. |
| [TwitchHandleForcedSolve\(\)](./Twitch\`1/TwitchHandleForcedSolve.md) | This method gets grabbed by Twitch Plays which is used whenever a thrown `Exception`is unhandled, a votesolve/solvebomb is performed, or when an admin forces this module to be solved\. |
| [ForceSolve\(\)](./Twitch\`1/ForceSolve.md) | When the module runs into an exception or the module is forced to be solved, this method is used\. |
| [ToString\(\)](./Twitch\`1/ToString.md) |  |
| [UntilSolve\(\)](./Twitch\`1/UntilSolve.md) | You can `yield``return` this toallow interactions of other modules until the module is solved\. |
| [UntilStrike\(\)](./Twitch\`1/UntilStrike.md) | You can `yield``return` this toallow interactions of other modules until the module has struck\. |
| [Sequence\(IEnumerable\<KMSelectable\>, float\)](./Twitch\`1/Sequence.md) | Presses a sequence of buttons in order of `selectables`,waiting `duration` seconds in\-between each, and interrupting as soon as[HasStruck](../../wawa.Modules/wawa.Modules/State/HasStruck.md) is `true`\. |
| [IndexedSequence\(IList\<KMSelectable\>, float, params int\[\]\)](./Twitch\`1/IndexedSequence.md) | Presses a sequence of buttons according to `indices` within `selectables`,waiting `duration` seconds in\-between each, and interrupting as soon as[HasStruck](../../wawa.Modules/wawa.Modules/State/HasStruck.md) is true\. |
| [IndexedSequence\(IList\<KMSelectable\>, float, IEnumerable\<int\>\)](./Twitch\`1/IndexedSequence.md) | Presses a sequence of buttons according to `indices` within `selectables`,waiting `duration` seconds in\-between each, and interrupting as soon as[HasStruck](../../wawa.Modules/wawa.Modules/State/HasStruck.md) is true\. |
| [Equal\(string, string\)](./Twitch\`1/Equal.md) | Determines whether two strings are equal, without accounting for case\. |
| [YieldWhile\<T\>\(T, Func\<bool\>\)](./Twitch\`1/YieldWhile.md) | You can `yield``return` this to repeatedly`yield``return` an item until a condition is no longer met\. |
| [YieldUntil\<T\>\(T, Func\<bool\>\)](./Twitch\`1/YieldUntil.md) | You can `yield``return` this to repeatedly`yield``return` an item until a condition is met\. |
| [Split\(string, string\)](./Twitch\`1/Split.md) | Splits a `System.String` into an `Array` of `System.String` values based on a separator\. |

## Properties

| Name | Summary |
|------|---------|
| [AutoImplementedHelp](./Twitch\`1/AutoImplementedHelp.md) | Gets the suggested help command\. This is a fallback value used when one isn't specified\. |
| [Module](./Twitch\`1/Module.md) | Gets the instance of the module\. |
| [IsPrintingYields](./Twitch\`1/IsPrintingYields.md) | Gets or sets a value indicating whether values yielded from aTwitch Plays `Coroutine` should be logged\. |
| [IsCancelCommand](./Twitch\`1/IsCancelCommand.md) | Gets a value indicating whether it should cancel command processing\. |
| [IsTime](./Twitch\`1/IsTime.md) | Gets a value indicating whether it is in Time Mode, where solves change the timer\. |
| [IsTimeSkippable](./Twitch\`1/IsTimeSkippable.md) | Gets a value indicating whether it should allow for the timer to be skipped when the module it is in,as well as any other modules that would like to skip time, are the only unsolved modules left on the bomb\. |
| [IsTP](./Twitch\`1/IsTP.md) | Gets a value indicating whether Twitch Plays is currently active\. |
| [IsZen](./Twitch\`1/IsZen.md) | Gets a value indicating whether the timer is counting up instead of down, for special cases,such as controlling how to sort button release times, or whether there is a low timer event or not\. |
| [Help](./Twitch\`1/Help.md) | Gets or sets the help message that gets sent when typing `!{id} help`\. |
| [Manual](./Twitch\`1/Manual.md) | Gets or sets the manual that is looked up on The Manual Repository when`!{id} manual` is entered into chat\. |
| [Abandons](./Twitch\`1/Abandons.md) | Gets the list that contains modules that it should stop processing\. |

## Events

| Name | Summary |
|------|---------|
| [OnYield](./Twitch\`1/OnYield.md) | Gets or sets an event invoked whenever any command \(including [AutoSolve](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/TwitchString/AutoSolve.md)\) yieldssomething and is processed\. The value that it yielded is passed in\. |

