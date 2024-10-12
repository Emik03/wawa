# ITwitchDeclarable Interface

namespace: [wawa\.TwitchPlays](../wawa.TwitchPlays.md)<br />
assembly: [wawa\.TwitchPlays](../../wawa.TwitchPlays.md)

Interface for non\-generic [Twitch\<TMod\>](../../wawa.TwitchPlays/wawa.TwitchPlays/Twitch\`1.md)\.

```csharp
public interface ITwitchDeclarable;
```

Implements: [ISolvable](../../wawa.Modules/wawa.Modules/ISolvable.md), [ITwitchSupportable](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/ITwitchSupportable.md)

## Methods

| Name | Summary |
|------|---------|
| [ForceSolve\(\)](./ITwitchDeclarable/ForceSolve.md) | When the module runs into an exception or the module is forced to be solved, this method is used\. |

## Properties

| Name | Summary |
|------|---------|
| [IsPrintingYields](./ITwitchDeclarable/IsPrintingYields.md) | Gets or sets a value indicating whether values yielded from aTwitch Plays `Coroutine` should be logged\. |
| [IsCancelCommand](./ITwitchDeclarable/IsCancelCommand.md) | Gets a value indicating whether it should cancel command processing\. |
| [IsTime](./ITwitchDeclarable/IsTime.md) | Gets a value indicating whether it is in Time Mode, where solves change the timer\. |
| [IsTimeSkippable](./ITwitchDeclarable/IsTimeSkippable.md) | Gets a value indicating whether it should allow for the timer to be skipped when the module it is in,as well as any other modules that would like to skip time, are the only unsolved modules left on the bomb\. |
| [IsZen](./ITwitchDeclarable/IsZen.md) | Gets a value indicating whether the timer is counting up instead of down, for special cases,such as controlling how to sort button release times, or whether there is a low timer event or not\. |
| [Help](./ITwitchDeclarable/Help.md) | Gets or sets the help message that gets sent when typing `!{id} help`\. |
| [Manual](./ITwitchDeclarable/Manual.md) | Gets or sets the manual that is looked up on The Manual Repository when`!{id} manual` is entered into chat\. |
| [Abandons](./ITwitchDeclarable/Abandons.md) | Gets the list that contains modules that it should stop processing\. |
| [Inner](./ITwitchDeclarable/Inner.md) | Gets the module that is attached to this instance\. |

