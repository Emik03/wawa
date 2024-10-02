#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays](wawa.TwitchPlays.md 'wawa.TwitchPlays').[ITwitchDeclarable](ITwitchDeclarable.md 'wawa.TwitchPlays.ITwitchDeclarable')

## ITwitchDeclarable.Abandons Property

Gets the list that contains modules that it should stop processing.

```csharp
System.Collections.ObjectModel.ReadOnlyCollection<KMBombModule> Abandons { get; }
```

#### Property Value
[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')

### Remarks
  
Currently, the only module that uses this capability is Souvenir.  
  
These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`,  
therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in  
[KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate') or later.