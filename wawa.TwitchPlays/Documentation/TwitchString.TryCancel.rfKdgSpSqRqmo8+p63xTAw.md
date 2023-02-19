#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.TryCancel(string) Method

Yield return this to indicate that this command is allowed to be cancelled at the given time of the yield.

```csharp
public static Wawa.TwitchPlays.Domains.TwitchString TryCancel(string message=null);
```
#### Parameters

<a name='Wawa.TwitchPlays.Domains.TwitchString.TryCancel(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message to send.

#### Returns
[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')  
A formatted string for Twitch Plays.

### Remarks
  
Just know that you won't be able to clean up if you do your cancel this way,  
and there is a pending `!cancel` or `!stop`.