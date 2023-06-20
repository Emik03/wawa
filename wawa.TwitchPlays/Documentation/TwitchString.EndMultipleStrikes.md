#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.EndMultipleStrikes Property

Gets the strike enabler Twitch Plays query.

```csharp
public static Wawa.TwitchPlays.Domains.TwitchString EndMultipleStrikes { get; }
```

#### Property Value
[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

### Remarks
  
Yield return this to indicate that the strike tracker should be enabled.  
If any strikes were issued during the time it was disabled,  
they will be awarded and the routine stopped at that point,  
otherwise, it will just cancel the "`VoteNay Mod {id} got 0 strikes! +0 strike to {Nickname}`"  
message that would otherwise be posted.  
Likewise, if the module was solved at the time this command is issued,  
the processing will be stopped as of that point as well.