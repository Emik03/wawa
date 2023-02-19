#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.AwardPoints(int) Method

Yield return this to award the user that sent the command points directly.

```csharp
public static Wawa.TwitchPlays.Domains.TwitchString AwardPoints(int points);
```
#### Parameters

<a name='Wawa.TwitchPlays.Domains.TwitchString.AwardPoints(int).points'></a>

`points` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The amount of points to award. Negatives supported.

#### Returns
[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')  
A formatted string for Twitch Plays.

### Remarks
  
This is currently used for mods like Souvenir to give points to users that answered the questions equally.