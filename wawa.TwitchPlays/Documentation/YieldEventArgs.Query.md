#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains').[YieldEventArgs](YieldEventArgs.md 'Wawa.TwitchPlays.Domains.YieldEventArgs')

## YieldEventArgs.Query Property

Gets the value that was yielded.

```csharp
public Wawa.Optionals.Maybe<Wawa.TwitchPlays.Domains.Instruction> Query { get; }
```

#### Property Value
[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')

### Remarks
  
A [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction') is a completely valid query,  
so this value is therefore around a [Wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1').