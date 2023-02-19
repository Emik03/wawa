#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays](Wawa.TwitchPlays.md 'Wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch_TMod_.md 'Wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.OnYield Event

Gets or sets an event invoked whenever any command (including [AutoSolve](TwitchString.AutoSolve.md 'Wawa.TwitchPlays.Domains.TwitchString.AutoSolve')) yields  
something and is processed. The value that it yielded is passed in.

```csharp
public virtual event EventHandler<YieldEventArgs> OnYield;
```

#### Event Type
[System.EventHandler&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')[YieldEventArgs](YieldEventArgs.md 'Wawa.TwitchPlays.Domains.YieldEventArgs')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')