#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays](wawa.TwitchPlays.md 'wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.Equal(string, string) Method

Determines whether two strings are equal, without accounting for case.

```csharp
protected static bool Equal(string left, string right);
```
#### Parameters

<a name='wawa.TwitchPlays.Twitch_TMod_.Equal(string,string).left'></a>

`left` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The left-hand side.

<a name='wawa.TwitchPlays.Twitch_TMod_.Equal(string,string).right'></a>

`right` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The right-hand side.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the parameters [left](Twitch{TMod}.Equal(string,string).md#wawa.TwitchPlays.Twitch_TMod_.Equal(string,string).left 'wawa.TwitchPlays.Twitch<TMod>.Equal(string, string).left') and  
[right](Twitch{TMod}.Equal(string,string).md#wawa.TwitchPlays.Twitch_TMod_.Equal(string,string).right 'wawa.TwitchPlays.Twitch<TMod>.Equal(string, string).right') are equal to each other according to the comparison type  
[System.StringComparison.OrdinalIgnoreCase](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison.OrdinalIgnoreCase 'System.StringComparison.OrdinalIgnoreCase'); otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').