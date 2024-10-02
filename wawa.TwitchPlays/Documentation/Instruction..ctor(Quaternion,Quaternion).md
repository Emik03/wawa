#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[Instruction](Instruction.md 'wawa.TwitchPlays.Domains.Instruction')

## Instruction(Quaternion, Quaternion) Constructor

Initializes a new instance of the [Instruction](Instruction.md 'wawa.TwitchPlays.Domains.Instruction') class.

```csharp
public Instruction(Quaternion first, Quaternion second);
```
#### Parameters

<a name='wawa.TwitchPlays.Domains.Instruction.Instruction(Quaternion,Quaternion).first'></a>

`first` [UnityEngine.Quaternion](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Quaternion 'UnityEngine.Quaternion')

For the Bomb. The form of  
`(Quaternion.Euler(x, 0, 0) * Quaternion.Euler(0, y, 0) * (Quaternion.Euler(0, 0, z))`.

<a name='wawa.TwitchPlays.Domains.Instruction.Instruction(Quaternion,Quaternion).second'></a>

`second` [UnityEngine.Quaternion](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Quaternion 'UnityEngine.Quaternion')

For the camera side view. The second one in the form of `Quaternion.Euler(x, y, z)`.

### Remarks
  
Changes the orientation of the bomb when yielded.