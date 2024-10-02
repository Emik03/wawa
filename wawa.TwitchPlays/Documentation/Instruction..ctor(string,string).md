#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[Instruction](Instruction.md 'wawa.TwitchPlays.Domains.Instruction')

## Instruction(string, string) Constructor

Initializes a new instance of the [Instruction](Instruction.md 'wawa.TwitchPlays.Domains.Instruction') class.

```csharp
public Instruction(string reason=null, string moduleName=null);
```
#### Parameters

<a name='wawa.TwitchPlays.Domains.Instruction.Instruction(string,string).reason'></a>

`reason` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The optional reason for the explosion.

<a name='wawa.TwitchPlays.Domains.Instruction.Instruction(string,string).moduleName'></a>

`moduleName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The override of the module name that caused the explosion.

### Remarks
  
Detonates the bomb when yielded.