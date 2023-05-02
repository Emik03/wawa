#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.TryWaitCancel(float, string) Method

Yield return this to cause Twitch Plays to wait for the given time,  
and any time during the entire duration, the command may cancel.

```csharp
public static Wawa.TwitchPlays.Domains.TwitchString TryWaitCancel(float time, string message=null);
```
#### Parameters

<a name='Wawa.TwitchPlays.Domains.TwitchString.TryWaitCancel(float,string).time'></a>

`time` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The amount of time to wait.

<a name='Wawa.TwitchPlays.Domains.TwitchString.TryWaitCancel(float,string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message to send.

#### Returns
[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')  
A formatted string for Twitch Plays.

### Remarks
  
Like [TryCancel(string)](TwitchString.TryCancel(String).md 'Wawa.TwitchPlays.Domains.TwitchString.TryCancel(string)'), you won't be able to clean up if you cancel this way.  
Also like [TryCancel(string)](TwitchString.TryCancel(String).md 'Wawa.TwitchPlays.Domains.TwitchString.TryCancel(string)'), [message](TwitchString.TryWaitCancel(Single,String).md#Wawa.TwitchPlays.Domains.TwitchString.TryWaitCancel(float,string).message 'Wawa.TwitchPlays.Domains.TwitchString.TryWaitCancel(float, string).message') is optional.