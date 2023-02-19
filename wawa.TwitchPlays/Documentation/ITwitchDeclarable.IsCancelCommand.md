#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays](Wawa.TwitchPlays.md 'Wawa.TwitchPlays').[ITwitchDeclarable](ITwitchDeclarable.md 'Wawa.TwitchPlays.ITwitchDeclarable')

## ITwitchDeclarable.IsCancelCommand Property

Gets a value indicating whether it should cancel command processing.

```csharp
bool IsCancelCommand { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

### Remarks
  
If this returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'),  
then stop processing the command, clean up, then do a `
            TwitchString.Cancelled;` to acknowledge the cancel.  
  
These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`,  
therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in  
[KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate') or later.