#### [wawa.TwitchPlays](index.md 'index')

## wawa.TwitchPlays.Domains Namespace

Contains domain objects used within [Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>').

| Classes | |
| :--- | :--- |
| [AliasAttribute](AliasAttribute.md 'wawa.TwitchPlays.Domains.AliasAttribute') | An [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') to attach to a field to signify alternative ways to spell it. |
| [CommandAttribute](CommandAttribute.md 'wawa.TwitchPlays.Domains.CommandAttribute') | An [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') to attach to methods to signify that<br/>the command should be processed by [Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>'). |
| [Instruction](Instruction.md 'wawa.TwitchPlays.Domains.Instruction') | Defines an instruction for Twitch Plays to process. |
| [InstructionCore](InstructionCore.md 'wawa.TwitchPlays.Domains.InstructionCore') | Implementations for [Instruction](Instruction.md 'wawa.TwitchPlays.Domains.Instruction'). |
| [YieldEventArgs](YieldEventArgs.md 'wawa.TwitchPlays.Domains.YieldEventArgs') | An [System.EventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.EventArgs 'System.EventArgs') for yielded items. |

| Structs | |
| :--- | :--- |
| [TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString') | Represents a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') query to send to Twitch Plays. |

| Interfaces | |
| :--- | :--- |
| [ITwitchSupportable](ITwitchSupportable.md 'wawa.TwitchPlays.Domains.ITwitchSupportable') | Interface for Twitch Plays support. |
