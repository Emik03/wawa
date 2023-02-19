#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.Cancelled Property

Gets a Twitch Plays query.

```csharp
public static Wawa.TwitchPlays.Domains.TwitchString Cancelled { get; }
```

#### Property Value
[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

### Remarks
  
Yield return this to indicate that you have stopped processing the command in response to the  
[Wawa.TwitchPlays.Twitch&lt;&gt;.TwitchShouldCancelCommand](https://docs.microsoft.com/en-us/dotnet/api/Wawa.TwitchPlays.Twitch-1.TwitchShouldCancelCommand 'Wawa.TwitchPlays.Twitch`1.TwitchShouldCancelCommand') bool being set to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').