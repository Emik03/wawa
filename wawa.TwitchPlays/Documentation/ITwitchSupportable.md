#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains')

## ITwitchSupportable Interface

Interface for Twitch Plays support.

```csharp
public interface ITwitchSupportable
```

Derived  
&#8627; [ITwitchDeclarable](ITwitchDeclarable.md 'wawa.TwitchPlays.ITwitchDeclarable')  
&#8627; [Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>')

| Methods | |
| :--- | :--- |
| [ProcessTwitchCommand(string)](ITwitchSupportable.ProcessTwitchCommand(string).md 'wawa.TwitchPlays.Domains.ITwitchSupportable.ProcessTwitchCommand(string)') | This method gets grabbed by Twitch Plays to process a user command. |
| [TwitchHandleForcedSolve()](ITwitchSupportable.TwitchHandleForcedSolve.md 'wawa.TwitchPlays.Domains.ITwitchSupportable.TwitchHandleForcedSolve()') | This method gets grabbed by Twitch Plays which is used whenever a thrown [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')<br/>is unhandled, a votesolve/solvebomb is performed, or when an admin forces this module to be solved. |
