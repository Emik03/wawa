#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays](Wawa.TwitchPlays.md 'Wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch{TMod}.md 'Wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.UntilSolve() Method

You can [yield](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield')[return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') this to  
allow interactions of other modules until the module is solved.

```csharp
public virtual System.Collections.Generic.IEnumerable<Wawa.TwitchPlays.Domains.Instruction> UntilSolve();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Repeatedly [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), halting when [Wawa.Modules.State.IsSolved](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Modules.State.IsSolved 'Wawa.Modules.State.IsSolved')  
from [Module](Twitch{TMod}.Module.md 'Wawa.TwitchPlays.Twitch<TMod>.Module') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').