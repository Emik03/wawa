#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[YieldEventArgs](YieldEventArgs.md 'wawa.TwitchPlays.Domains.YieldEventArgs')

## YieldEventArgs.Query Property

Gets the value that was yielded.

```csharp
public wawa.Optionals.Maybe<wawa.TwitchPlays.Domains.Instruction> Query { get; }
```

#### Property Value
[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[Instruction](Instruction.md 'wawa.TwitchPlays.Domains.Instruction')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')

### Remarks
  
A [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null')[Instruction](Instruction.md 'wawa.TwitchPlays.Domains.Instruction') is a completely valid query,  
so this value is therefore around a [wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1').