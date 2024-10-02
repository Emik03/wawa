#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.SendDelayedMessage(float, string, bool, bool) Method

Yield return this to send a message to chat after [time](TwitchString.SendDelayedMessage(float,string,bool,bool).md#wawa.TwitchPlays.Domains.TwitchString.SendDelayedMessage(float,string,bool,bool).time 'wawa.TwitchPlays.Domains.TwitchString.SendDelayedMessage(float, string, bool, bool).time') seconds.

```csharp
public static wawa.TwitchPlays.Domains.TwitchString SendDelayedMessage(float time, string message, bool format=true, bool halt=false);
```
#### Parameters

<a name='wawa.TwitchPlays.Domains.TwitchString.SendDelayedMessage(float,string,bool,bool).time'></a>

`time` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The amount of time to wait before the message gets sent.

<a name='wawa.TwitchPlays.Domains.TwitchString.SendDelayedMessage(float,string,bool,bool).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message to send.

<a name='wawa.TwitchPlays.Domains.TwitchString.SendDelayedMessage(float,string,bool,bool).format'></a>

`format` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

When [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), treats `{` and `}` as plaintext.

<a name='wawa.TwitchPlays.Domains.TwitchString.SendDelayedMessage(float,string,bool,bool).halt'></a>

`halt` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), halts the command processing after the message is sent.

#### Returns
[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')  
A formatted string for Twitch Plays.

### Remarks
  
By default, the parameter [message](TwitchString.SendDelayedMessage(float,string,bool,bool).md#wawa.TwitchPlays.Domains.TwitchString.SendDelayedMessage(float,string,bool,bool).message 'wawa.TwitchPlays.Domains.TwitchString.SendDelayedMessage(float, string, bool, bool).message') is considered  
to be a message template in accordance to the following table:  
  
|  
  
If you wish to have `{` or `}` as part of your message directly, refer to [format](TwitchString.SendDelayedMessage(float,string,bool,bool).md#wawa.TwitchPlays.Domains.TwitchString.SendDelayedMessage(float,string,bool,bool).format 'wawa.TwitchPlays.Domains.TwitchString.SendDelayedMessage(float, string, bool, bool).format').