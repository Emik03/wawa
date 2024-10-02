#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[Instruction](Instruction.md 'wawa.TwitchPlays.Domains.Instruction')

## Instruction.UsableInForcedSolve Property

Gets a value indicating whether this current instance contains a value that can be  
evaluated by both the Twitch Plays command processor for users, and the forced solver,  
or whether it can only be strictly used for the Twitch Plays command processor.

```csharp
public bool UsableInForcedSolve { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

### Remarks
  
Currently supports [Pause](Instruction.Pause.md 'wawa.TwitchPlays.Domains.Instruction.Pause'), and values that Unity already natively supports: [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null')  
/ [FrameAdvance](Instruction.FrameAdvance.md 'wawa.TwitchPlays.Domains.Instruction.FrameAdvance'), [UnityEngine.CustomYieldInstruction](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.CustomYieldInstruction 'UnityEngine.CustomYieldInstruction'), and [UnityEngine.YieldInstruction](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.YieldInstruction 'UnityEngine.YieldInstruction').