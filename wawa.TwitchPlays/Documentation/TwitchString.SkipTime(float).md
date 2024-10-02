#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.SkipTime(float) Method

Yield return this to try advancing the clock to the specified time.

```csharp
public static wawa.TwitchPlays.Domains.TwitchString SkipTime(float seconds);
```
#### Parameters

<a name='wawa.TwitchPlays.Domains.TwitchString.SkipTime(float).seconds'></a>

`seconds` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The time to skip to in seconds.

#### Returns
[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')  
A formatted string for Twitch Plays.

### Remarks
  
You must put the full time you wish to skip to, and this time either needs to be less than the current time,  
if in normal/time mode, or greater than the current time, if in zen mode.  
Example, if you wanted to set the clock to 5:24, then you do "`SkipTime(324)`".  
You can target partway through the seconds, such as "`SkipTime(45.28f)`",  
which would then set the clock to 45.28, provided that time has NOT gone by already. You must also  
set [IsTimeSkippable](Twitch{TMod}.IsTimeSkippable.md 'wawa.TwitchPlays.Twitch<TMod>.IsTimeSkippable') to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), for this function to work.