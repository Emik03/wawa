#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays](wawa.TwitchPlays.md 'wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.wawa.Modules.ISolvable.ForceTPSolve() Method

When the module runs into an exception or the module is forced to be solved, it calls this method.

```csharp
System.Collections.IEnumerator wawa.Modules.ISolvable.ForceTPSolve();
```

Implements [ForceTPSolve()](https://docs.microsoft.com/en-us/dotnet/api/wawa.Modules.ISolvable.ForceTPSolve 'wawa.Modules.ISolvable.ForceTPSolve')

### Remarks
  
Make sure that the module is solved before this method closes, otherwise it causes a forced-solve.