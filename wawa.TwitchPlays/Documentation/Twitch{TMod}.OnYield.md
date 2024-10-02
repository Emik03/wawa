#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays](wawa.TwitchPlays.md 'wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.OnYield Event

Gets or sets an event invoked whenever any command (including [AutoSolve](TwitchString.AutoSolve.md 'wawa.TwitchPlays.Domains.TwitchString.AutoSolve')) yields  
something and is processed. The value that it yielded is passed in.

```csharp
public virtual event EventHandler<YieldEventArgs> OnYield;
```

#### Event Type
[System.EventHandler&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')[YieldEventArgs](YieldEventArgs.md 'wawa.TwitchPlays.Domains.YieldEventArgs')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')