#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays](wawa.TwitchPlays.md 'wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.TwitchHandleForcedSolve() Method

This method gets grabbed by Twitch Plays which is used whenever a thrown [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
is unhandled, a votesolve/solvebomb is performed, or when an admin forces this module to be solved.

```csharp
public virtual System.Collections.IEnumerator TwitchHandleForcedSolve();
```

Implements [TwitchHandleForcedSolve()](ITwitchSupportable.TwitchHandleForcedSolve.md 'wawa.TwitchPlays.Domains.ITwitchSupportable.TwitchHandleForcedSolve()')

#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
A series of instructions for the Twitch Plays mod to handle in order to guarantee a solve.