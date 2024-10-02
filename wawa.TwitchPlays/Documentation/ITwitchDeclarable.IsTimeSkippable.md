#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays](wawa.TwitchPlays.md 'wawa.TwitchPlays').[ITwitchDeclarable](ITwitchDeclarable.md 'wawa.TwitchPlays.ITwitchDeclarable')

## ITwitchDeclarable.IsTimeSkippable Property

Gets a value indicating whether it should allow for the timer to be skipped when the module it is in,  
as well as any other modules that would like to skip time, are the only unsolved modules left on the bomb.

```csharp
bool IsTimeSkippable { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

### Remarks
  
These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`,  
therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in  
[KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate') or later.