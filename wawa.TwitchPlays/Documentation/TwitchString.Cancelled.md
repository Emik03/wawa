#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.Cancelled Property

Gets the cancellation-of-processing Twitch Plays query.

```csharp
public static wawa.TwitchPlays.Domains.TwitchString Cancelled { get; }
```

#### Property Value
[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')

### Remarks
  
Yield return this to indicate that you have stopped processing the command in response to the  
[wawa.TwitchPlays.Twitch&lt;&gt;.TwitchShouldCancelCommand](https://docs.microsoft.com/en-us/dotnet/api/wawa.TwitchPlays.Twitch-1.TwitchShouldCancelCommand 'wawa.TwitchPlays.Twitch`1.TwitchShouldCancelCommand') bool being set to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').