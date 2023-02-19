#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays](Wawa.TwitchPlays.md 'Wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch_TMod_.md 'Wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.IsTP Property

Gets a value indicating whether Twitch Plays is currently active.

```csharp
public virtual bool IsTP { get; }
```

Implements [IsTP](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Modules.ISolvable.IsTP 'Wawa.Modules.ISolvable.IsTP')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

### Remarks
  
This is for modules that need to display different items, or use different rules if Twitch Plays is active.  
  
These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`,  
therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in  
[KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate') or later.