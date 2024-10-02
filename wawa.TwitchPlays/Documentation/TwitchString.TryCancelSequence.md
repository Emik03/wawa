#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.TryCancelSequence Property

Gets the allow cancel Twitch Plays query.

```csharp
public static wawa.TwitchPlays.Domains.TwitchString TryCancelSequence { get; }
```

#### Property Value
[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')

### Remarks
  
Yield return this to indicate that the `KMSelectable[]` sequence that follows this command should be  
cancelled if a "`!cancel`" or "`!stop`" is issued mid-way through that sequence.