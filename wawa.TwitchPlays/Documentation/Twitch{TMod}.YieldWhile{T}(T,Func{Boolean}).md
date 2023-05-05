#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays](Wawa.TwitchPlays.md 'Wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch{TMod}.md 'Wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.YieldWhile<T>(T, Func<bool>) Method

You can [yield](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield')[return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') this to repeatedly  
[yield](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield')[return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') an item until a condition is no longer met.

```csharp
protected static System.Collections.Generic.IEnumerable<T> YieldWhile<T>(T item, System.Func<bool> condition);
```
#### Type parameters

<a name='Wawa.TwitchPlays.Twitch_TMod_.YieldWhile_T_(T,System.Func_bool_).T'></a>

`T`

The [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') of the items that are yielded.
#### Parameters

<a name='Wawa.TwitchPlays.Twitch_TMod_.YieldWhile_T_(T,System.Func_bool_).item'></a>

`item` [T](Twitch{TMod}.YieldWhile{T}(T,Func{Boolean}).md#Wawa.TwitchPlays.Twitch_TMod_.YieldWhile_T_(T,System.Func_bool_).T 'Wawa.TwitchPlays.Twitch<TMod>.YieldWhile<T>(T, System.Func<bool>).T')

The item to yield repeatedly.

<a name='Wawa.TwitchPlays.Twitch_TMod_.YieldWhile_T_(T,System.Func_bool_).condition'></a>

`condition` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The condition to repeatedly check until it returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Twitch{TMod}.YieldWhile{T}(T,Func{Boolean}).md#Wawa.TwitchPlays.Twitch_TMod_.YieldWhile_T_(T,System.Func_bool_).T 'Wawa.TwitchPlays.Twitch<TMod>.YieldWhile<T>(T, System.Func<bool>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
[item](Twitch{TMod}.YieldWhile{T}(T,Func{Boolean}).md#Wawa.TwitchPlays.Twitch_TMod_.YieldWhile_T_(T,System.Func_bool_).item 'Wawa.TwitchPlays.Twitch<TMod>.YieldWhile<T>(T, System.Func<bool>).item') continuously until [condition](Twitch{TMod}.YieldWhile{T}(T,Func{Boolean}).md#Wawa.TwitchPlays.Twitch_TMod_.YieldWhile_T_(T,System.Func_bool_).condition 'Wawa.TwitchPlays.Twitch<TMod>.YieldWhile<T>(T, System.Func<bool>).condition') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').