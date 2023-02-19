#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.TryCancelSequence Property

Gets a Twitch Plays query.

```csharp
public static Wawa.TwitchPlays.Domains.TwitchString TryCancelSequence { get; }
```

#### Property Value
[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

### Remarks
  
Yield return this to indicate that the `KMSelectable[]` sequence that follows this command should be  
cancelled if a "`!cancel`" or "`!stop`" is issued mid-way through that sequence.