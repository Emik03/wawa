#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.Strike Property

Gets the striking Twitch Plays query.

```csharp
public static Wawa.TwitchPlays.Domains.TwitchString Strike { get; }
```

#### Property Value
[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

### Remarks
  
Yield return this to indicate that this command will cause a strike at some later point;  
all this does is tell Twitch Plays to attribute the strike to the author of this command.