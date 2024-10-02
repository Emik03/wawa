#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[ITwitchSupportable](ITwitchSupportable.md 'wawa.TwitchPlays.Domains.ITwitchSupportable')

## ITwitchSupportable.TwitchHandleForcedSolve() Method

This method gets grabbed by Twitch Plays which is used whenever a thrown [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
is unhandled, a votesolve/solvebomb is performed, or when an admin forces this module to be solved.

```csharp
System.Collections.IEnumerator TwitchHandleForcedSolve();
```

#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
A series of instructions for the Twitch Plays mod to handle in order to guarantee a solve.