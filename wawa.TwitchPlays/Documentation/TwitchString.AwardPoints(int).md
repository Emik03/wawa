#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.AwardPoints(int) Method

Yield return this to award the user that sent the command points directly.

```csharp
public static wawa.TwitchPlays.Domains.TwitchString AwardPoints(int points);
```
#### Parameters

<a name='wawa.TwitchPlays.Domains.TwitchString.AwardPoints(int).points'></a>

`points` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The amount of points to award. Negatives supported.

#### Returns
[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')  
A formatted string for Twitch Plays.

### Remarks
  
This is currently used for mods like Souvenir to give points to users that answered the questions equally.