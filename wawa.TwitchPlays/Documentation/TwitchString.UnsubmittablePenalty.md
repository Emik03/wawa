#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.UnsubmittablePenalty Property

Gets the unsubmittable penalty Twitch Plays query.

```csharp
public static wawa.TwitchPlays.Domains.TwitchString UnsubmittablePenalty { get; }
```

#### Property Value
[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')

### Remarks
  
Yield return this to indicate that the command couldn't submit an answer and should only be used to prevent  
users from guessing the answer. This should not be used if an answer could never be submittable for a module.