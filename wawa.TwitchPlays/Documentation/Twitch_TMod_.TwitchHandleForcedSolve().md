#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays](Wawa.TwitchPlays.md 'Wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch_TMod_.md 'Wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.TwitchHandleForcedSolve() Method

This method gets grabbed by Twitch Plays which is used whenever a thrown [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
is unhandled, a votesolve/solvebomb is performed, or when an admin forces this module to be solved.

```csharp
public virtual System.Collections.IEnumerator TwitchHandleForcedSolve();
```

Implements [TwitchHandleForcedSolve()](ITwitchSupportable.TwitchHandleForcedSolve().md 'Wawa.TwitchPlays.Domains.ITwitchSupportable.TwitchHandleForcedSolve()')

#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
A series of instructions for the Twitch Plays mod to handle in order to guarantee a solve.