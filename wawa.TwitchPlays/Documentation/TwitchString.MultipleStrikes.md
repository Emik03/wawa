#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains').[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

## TwitchString.MultipleStrikes Property

Gets the strike disabler Twitch Plays query.

```csharp
public static Wawa.TwitchPlays.Domains.TwitchString MultipleStrikes { get; }
```

#### Property Value
[TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString')

### Remarks
  
Yield return this to indicate that the issued command is going to cause more than one strike,  
so should disable the internal strike tracker in order to avoid flooding the chat with  
"`VoteNay Mod {id} got a strike! +1 strike to {Nickname}`" for as many strikes as will be awarded.  
This also disables the internal solve tracker as well. This allows for sending  
additional messages or continue processing commands regardless of the solve/strike state.