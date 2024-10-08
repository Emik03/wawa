#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.AwardPointsOnSolve(int) Method

Yield return this to award the last user that sent the command points when the module is solved.

```csharp
public static wawa.TwitchPlays.Domains.TwitchString AwardPointsOnSolve(int points);
```
#### Parameters

<a name='wawa.TwitchPlays.Domains.TwitchString.AwardPointsOnSolve(int).points'></a>

`points` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The amount of points to award. Negatives supported.

#### Returns
[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')  
A formatted string for Twitch Plays.

### Remarks
  
The module must prevent any user from sending commands afterward in order for Twitch Plays  
to award points to the correct user. This is currently used by the Twin module  
when extra points must be given but the module is not solved immediately.