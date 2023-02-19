#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains').[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction')

## Instruction(string, string) Constructor

Initializes a new instance of the [Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction') class.

```csharp
public Instruction(string reason=null, string moduleName=null);
```
#### Parameters

<a name='Wawa.TwitchPlays.Domains.Instruction.Instruction(string,string).reason'></a>

`reason` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The optional reason for the explosion.

<a name='Wawa.TwitchPlays.Domains.Instruction.Instruction(string,string).moduleName'></a>

`moduleName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The override of the module name that caused the explosion.

### Remarks
  
Detonates the bomb when yielded.