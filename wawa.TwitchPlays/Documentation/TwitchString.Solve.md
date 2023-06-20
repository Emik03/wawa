#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.Solve Property

Gets the solving Twitch Plays query.

```csharp
public static Wawa.TwitchPlays.Domains.TwitchString Solve { get; }
```

#### Property Value
[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

### Remarks
  
Yield return this to indicate that this command will solve the module at some later point;  
all this does is tell Twitch Plays to attribute the solve to the author of this command.