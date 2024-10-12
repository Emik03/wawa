# wawa\.TwitchPlays\.Domains Namespace

assembly: [wawa\.TwitchPlays](../wawa.TwitchPlays.md)

Contains domain objects used within [Twitch\<TMod\>](../wawa.TwitchPlays/wawa.TwitchPlays/Twitch\`1.md)\.

```csharp
namespace wawa.TwitchPlays.Domains;
```

## Classes

| Name | Summary |
|------|---------|
| [AliasAttribute](./wawa.TwitchPlays.Domains/AliasAttribute.md) | An `System.Attribute` to attach to a field to signify alternative ways to spell it\. |
| [CommandAttribute](./wawa.TwitchPlays.Domains/CommandAttribute.md) | An `System.Attribute` to attach to methods to signify thatthe command should be processed by [Twitch\<TMod\>](../wawa.TwitchPlays/wawa.TwitchPlays/Twitch\`1.md)\. |
| [Instruction](./wawa.TwitchPlays.Domains/Instruction.md) | Defines an instruction for Twitch Plays to process\. |
| [InstructionCore](./wawa.TwitchPlays.Domains/InstructionCore.md) | Implementations for [Instruction](../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)\. |
| [YieldEventArgs](./wawa.TwitchPlays.Domains/YieldEventArgs.md) | An `EventArgs` for yielded items\. |

## Structs

| Name | Summary |
|------|---------|
| [TwitchString](./wawa.TwitchPlays.Domains/TwitchString.md) | Represents a `System.String` query to send to Twitch Plays\. |

## Interfaces

| Name | Summary |
|------|---------|
| [ITwitchSupportable](./wawa.TwitchPlays.Domains/ITwitchSupportable.md) | Interface for Twitch Plays support\. |

