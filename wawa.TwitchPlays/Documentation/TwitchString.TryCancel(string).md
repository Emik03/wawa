#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.TryCancel(string) Method

Yield return this to indicate that this command is allowed to be cancelled at the given time of the yield.

```csharp
public static wawa.TwitchPlays.Domains.TwitchString TryCancel(string message=null);
```
#### Parameters

<a name='wawa.TwitchPlays.Domains.TwitchString.TryCancel(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message to send.

#### Returns
[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')  
A formatted string for Twitch Plays.

### Remarks
  
Just know that you won't be able to clean up if you do your cancel this way,  
and there is a pending `!cancel` or `!stop`.