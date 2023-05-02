#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays](Wawa.TwitchPlays.md 'Wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch_TMod_.md 'Wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.IsTimeSkippable Property

Gets a value indicating whether it should allow for the timer to be skipped when the module it is in,  
as well as any other modules that would like to skip time, are the only unsolved modules left on the bomb.

```csharp
public virtual bool IsTimeSkippable { get; }
```

Implements [IsTimeSkippable](ITwitchDeclarable.IsTimeSkippable().md 'Wawa.TwitchPlays.ITwitchDeclarable.IsTimeSkippable')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

### Remarks
  
These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`,  
therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in  
[KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate') or later.