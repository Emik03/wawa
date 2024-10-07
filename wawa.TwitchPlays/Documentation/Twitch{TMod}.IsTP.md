#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays](wawa.TwitchPlays.md 'wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.IsTP Property

Gets a value indicating whether Twitch Plays is currently active.

```csharp
public bool IsTP { get; }
```

Implements [IsTP](https://docs.microsoft.com/en-us/dotnet/api/wawa.Modules.ISolvable.IsTP 'wawa.Modules.ISolvable.IsTP')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

### Remarks
  
This is for modules that need to display different items, or use different rules if Twitch Plays is active.  
  
These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`,  
therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in  
[KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate') or later.