#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays](Wawa.TwitchPlays.md 'Wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch_TMod_.md 'Wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.Split(string, string) Method

Splits a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') into an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') values based on a separator.

```csharp
protected static System.Collections.Generic.IList<string> Split(string instance, string separator=" ");
```
#### Parameters

<a name='Wawa.TwitchPlays.Twitch_TMod_.Split(string,string).instance'></a>

`instance` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') to split.

<a name='Wawa.TwitchPlays.Twitch_TMod_.Split(string,string).separator'></a>

`separator` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The separator to split each [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') with.

#### Returns
[System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
An [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') values which are substrings of [instance](Twitch_TMod_.Split(String,String).md#Wawa.TwitchPlays.Twitch_TMod_.Split(string,string).instance 'Wawa.TwitchPlays.Twitch<TMod>.Split(string, string).instance')  
based on [separator](Twitch_TMod_.Split(String,String).md#Wawa.TwitchPlays.Twitch_TMod_.Split(string,string).separator 'Wawa.TwitchPlays.Twitch<TMod>.Split(string, string).separator'). Empty entries are omitted.