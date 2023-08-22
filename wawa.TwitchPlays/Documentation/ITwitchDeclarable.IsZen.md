#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays](Wawa.TwitchPlays.md 'Wawa.TwitchPlays').[ITwitchDeclarable](ITwitchDeclarable.md 'Wawa.TwitchPlays.ITwitchDeclarable')

## ITwitchDeclarable.IsZen Property

Gets a value indicating whether the timer is counting up instead of down, for special cases,  
such as controlling how to sort button release times, or whether there is a low timer event or not.

```csharp
bool IsZen { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

### Remarks
  
These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`,  
therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in  
[KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate') or later.