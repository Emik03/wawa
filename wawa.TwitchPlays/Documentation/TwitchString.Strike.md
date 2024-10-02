#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.Strike Property

Gets the striking Twitch Plays query.

```csharp
public static wawa.TwitchPlays.Domains.TwitchString Strike { get; }
```

#### Property Value
[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')

### Remarks
  
Yield return this to indicate that this command will cause a strike at some later point;  
all this does is tell Twitch Plays to attribute the strike to the author of this command.