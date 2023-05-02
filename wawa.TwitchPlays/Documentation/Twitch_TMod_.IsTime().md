#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays](Wawa.TwitchPlays.md 'Wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch_TMod_.md 'Wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.IsTime Property

Gets a value indicating whether it is in Time Mode, where solves change the timer.

```csharp
public virtual bool IsTime { get; }
```

Implements [IsTime](ITwitchDeclarable.IsTime().md 'Wawa.TwitchPlays.ITwitchDeclarable.IsTime')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

### Remarks
  
This is useful for modules that use the timer's value.  
  
These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`,  
therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in  
[KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate') or later.