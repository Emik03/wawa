### [wawa.Recall](wawa.Recall.md 'wawa.Recall')

## StatusLights Enum

The different kinds of status lights.

```csharp
public enum StatusLights : System.Byte
```
### Fields

<a name='wawa.Recall.StatusLights.None'></a>

`None` 0

No status light.

<a name='wawa.Recall.StatusLights.Off'></a>

`Off` 1

The status light that is off.

<a name='wawa.Recall.StatusLights.Solve'></a>

`Solve` 2

The status light that is green, representing the solve state.

<a name='wawa.Recall.StatusLights.Strike'></a>

`Strike` 4

The status light that is red, representing the strike state.

### Remarks
  
The game uses separate game objects for each status light kind.