#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.UnsubmittablePenalty Property

Gets a Twitch Plays query.

```csharp
public static Wawa.TwitchPlays.Domains.TwitchString UnsubmittablePenalty { get; }
```

#### Property Value
[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

### Remarks
  
Yield return this to indicate that the command couldn't submit an answer and should only be used to prevent  
users from guessing the answer. This should not be used if an answer could never be submittable for a module.