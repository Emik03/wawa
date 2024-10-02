#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.Solve Property

Gets the solving Twitch Plays query.

```csharp
public static wawa.TwitchPlays.Domains.TwitchString Solve { get; }
```

#### Property Value
[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')

### Remarks
  
Yield return this to indicate that this command will solve the module at some later point;  
all this does is tell Twitch Plays to attribute the solve to the author of this command.