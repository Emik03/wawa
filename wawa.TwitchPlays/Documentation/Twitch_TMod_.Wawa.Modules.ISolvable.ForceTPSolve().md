#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays](Wawa.TwitchPlays.md 'Wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch_TMod_.md 'Wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.Wawa.Modules.ISolvable.ForceTPSolve() Method

When the module runs into an exception or the module is forced to be solved, it calls this method.

```csharp
virtual System.Collections.IEnumerator Wawa.Modules.ISolvable.ForceTPSolve();
```

Implements [ForceTPSolve()](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Modules.ISolvable.ForceTPSolve 'Wawa.Modules.ISolvable.ForceTPSolve')

### Remarks
  
Make sure that the module is solved before this method closes, otherwise it causes a forced-solve.