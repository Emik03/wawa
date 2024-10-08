#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays](wawa.TwitchPlays.md 'wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.Split(string, string) Method

Splits a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') into an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') values based on a separator.

```csharp
protected static System.Collections.Generic.IList<string> Split(string instance, string separator=" ");
```
#### Parameters

<a name='wawa.TwitchPlays.Twitch_TMod_.Split(string,string).instance'></a>

`instance` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') to split.

<a name='wawa.TwitchPlays.Twitch_TMod_.Split(string,string).separator'></a>

`separator` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The separator to split each [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') with.

#### Returns
[System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
An [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') values which are substrings of [instance](Twitch{TMod}.Split(string,string).md#wawa.TwitchPlays.Twitch_TMod_.Split(string,string).instance 'wawa.TwitchPlays.Twitch<TMod>.Split(string, string).instance')  
based on [separator](Twitch{TMod}.Split(string,string).md#wawa.TwitchPlays.Twitch_TMod_.Split(string,string).separator 'wawa.TwitchPlays.Twitch<TMod>.Split(string, string).separator'). Empty entries are omitted.