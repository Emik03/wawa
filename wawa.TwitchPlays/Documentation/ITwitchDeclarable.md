#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays](wawa.TwitchPlays.md 'wawa.TwitchPlays')

## ITwitchDeclarable Interface

Interface for non-generic [Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>').

```csharp
public interface ITwitchDeclarable :
wawa.Modules.ISolvable,
wawa.TwitchPlays.Domains.ITwitchSupportable
```

Derived  
&#8627; [Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>')

Implements [wawa.Modules.ISolvable](https://docs.microsoft.com/en-us/dotnet/api/wawa.Modules.ISolvable 'wawa.Modules.ISolvable'), [ITwitchSupportable](ITwitchSupportable.md 'wawa.TwitchPlays.Domains.ITwitchSupportable')

| Properties | |
| :--- | :--- |
| [Abandons](ITwitchDeclarable.Abandons.md 'wawa.TwitchPlays.ITwitchDeclarable.Abandons') | Gets the list that contains modules that it should stop processing. |
| [Help](ITwitchDeclarable.Help.md 'wawa.TwitchPlays.ITwitchDeclarable.Help') | Gets or sets the help message that gets sent when typing `!{id} help`. |
| [Inner](ITwitchDeclarable.Inner.md 'wawa.TwitchPlays.ITwitchDeclarable.Inner') | Gets the module that is attached to this instance. |
| [IsCancelCommand](ITwitchDeclarable.IsCancelCommand.md 'wawa.TwitchPlays.ITwitchDeclarable.IsCancelCommand') | Gets a value indicating whether it should cancel command processing. |
| [IsPrintingYields](ITwitchDeclarable.IsPrintingYields.md 'wawa.TwitchPlays.ITwitchDeclarable.IsPrintingYields') | Gets or sets a value indicating whether values yielded from a<br/>Twitch Plays [UnityEngine.Coroutine](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Coroutine 'UnityEngine.Coroutine') should be logged. |
| [IsTime](ITwitchDeclarable.IsTime.md 'wawa.TwitchPlays.ITwitchDeclarable.IsTime') | Gets a value indicating whether it is in Time Mode, where solves change the timer. |
| [IsTimeSkippable](ITwitchDeclarable.IsTimeSkippable.md 'wawa.TwitchPlays.ITwitchDeclarable.IsTimeSkippable') | Gets a value indicating whether it should allow for the timer to be skipped when the module it is in,<br/>as well as any other modules that would like to skip time, are the only unsolved modules left on the bomb. |
| [IsZen](ITwitchDeclarable.IsZen.md 'wawa.TwitchPlays.ITwitchDeclarable.IsZen') | Gets a value indicating whether the timer is counting up instead of down, for special cases,<br/>such as controlling how to sort button release times, or whether there is a low timer event or not. |
| [Manual](ITwitchDeclarable.Manual.md 'wawa.TwitchPlays.ITwitchDeclarable.Manual') | Gets or sets the manual that is looked up on The Manual Repository when<br/>`!{id} manual` is entered into chat. |

| Methods | |
| :--- | :--- |
| [ForceSolve()](ITwitchDeclarable.ForceSolve.md 'wawa.TwitchPlays.ITwitchDeclarable.ForceSolve()') | When the module runs into an exception or the module is forced to be solved, this method is used. |
