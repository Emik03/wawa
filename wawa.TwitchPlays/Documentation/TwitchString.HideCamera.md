#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.HideCamera Property

Gets the camera hider Twitch Plays query.

```csharp
public static Wawa.TwitchPlays.Domains.TwitchString HideCamera { get; }
```

#### Property Value
[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

### Remarks
  
Yield return this to hide the heads-up display and cameras while doing quaternion rotations,  
if it is expected that the camera/hud will get in the way.