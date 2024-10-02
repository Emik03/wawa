#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.Detonate(Nullable<float>, string) Method

Yield return this to explode the bomb instantly.

```csharp
public static wawa.TwitchPlays.Domains.TwitchString Detonate(System.Nullable<float> time=null, string message=null);
```
#### Parameters

<a name='wawa.TwitchPlays.Domains.TwitchString.Detonate(System.Nullable_float_,string).time'></a>

`time` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The amount of time before the bomb blows up.

<a name='wawa.TwitchPlays.Domains.TwitchString.Detonate(System.Nullable_float_,string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message to send.

#### Returns
[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')  
A formatted string for Twitch Plays.

### Remarks
  
[time](TwitchString.Detonate(float+,string).md#wawa.TwitchPlays.Domains.TwitchString.Detonate(System.Nullable_float_,string).time 'wawa.TwitchPlays.Domains.TwitchString.Detonate(System.Nullable<float>, string).time') is specified in number of seconds before the bomb explodes.  
            (Note, sending another detonate command will auto-cancel the previous one on  
            the same module if it hasn't happened already.).  
            [message](TwitchString.Detonate(float+,string).md#wawa.TwitchPlays.Domains.TwitchString.Detonate(System.Nullable_float_,string).message 'wawa.TwitchPlays.Domains.TwitchString.Detonate(System.Nullable<float>, string).message') is the message to send to chat upon detonation.  
            Both of the parameters are optional.