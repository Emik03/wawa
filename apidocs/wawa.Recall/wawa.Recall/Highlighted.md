# Highlighted Class

namespace: [wawa\.Recall](../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../wawa.Recall.md)

Encapsulates a vanilla or modded highlight, and extends functionality to get or
mutate its inner values and events without worrying the kind of highlight it is\.

```csharp
public sealed class Highlighted;
```

Inheritance: `ICloneable` > Highlighted

Implements: `IEquatable<Highlighted>`, `IEqualityComparer<Highlighted>`, [IVanilla](../../wawa.Recall/wawa.Recall/IVanilla.md)

## Constructors

| Name | Summary |
|------|---------|
| [Highlighted\(KMHighlightable\)](./Highlighted/$ctor.md) | Initializes a new instance of the [Highlighted](../../wawa.Recall/wawa.Recall/Highlighted.md) class\.This guarantees the highlightable kind solvable\. |

## Methods

| Name | Summary |
|------|---------|
| [operator ==\(Highlighted, Highlighted\)](./Highlighted/op_Equality.md) | Determines whether both instances point to the same component\. |
| [implicit operator Highlighted\(KMHighlightable\)](./Highlighted/op_Implicit.md) | Implicitly calls the constructor\. |
| [operator \!=\(Highlighted, Highlighted\)](./Highlighted/op_Inequality.md) | Determines whether both instances do not point to the same component\. |
| [FromKMHighlightable\(KMHighlightable\)](./Highlighted/FromKMHighlightable.md) | Converts the `KMBombModule` to a `new`[Selected](../../wawa.Recall/wawa.Recall/Selected.md)\. |
| [FromComponent\(UnityEngine\.Component\)](./Highlighted/FromComponent.md) | Gets a new instance of [Highlighted](../../wawa.Recall/wawa.Recall/Highlighted.md) based on the first found highlightable of the `UnityEngine.Component`\. |
| [Equals\(Highlighted\)](./Highlighted/Equals.md) |  |
| [Equals\(Highlighted, Highlighted\)](./Highlighted/Equals.md) |  |
| [GetHashCode\(Highlighted\)](./Highlighted/GetHashCode.md) |  |
| [Clone\(\)](./Highlighted/Clone.md) |  |
| [Equals\(object?\)](./Highlighted/Equals.md) |  |
| [GetHashCode\(\)](./Highlighted/GetHashCode.md) |  |
| [ToString\(\)](./Highlighted/ToString.md) |  |

## Properties

| Name | Summary |
|------|---------|
| [Value](./Highlighted/Value.md) | Gets the value which is guaranteed to be a `UnityEngine.MonoBehaviour`\. |
| [IsModded](./Highlighted/IsModded.md) | Gets a value indicating whether this instance contains a modded highlightable\. |
| [IsVanilla](./Highlighted/IsVanilla.md) | Gets a value indicating whether this instance contains a vanilla highlightable\. |
| [Modded](./Highlighted/Modded.md) | Gets the encapsulated `KMHighlightable` from this instance\. |
| [Vanilla](./Highlighted/Vanilla.md) | Gets the encapsulated `Highlightable` from this instance\. |
| [Outline](./Highlighted/Outline.md) | Gets the outline thickness amount\. |
| [Scale](./Highlighted/Scale.md) | Gets the scaling\. A non\-zero value for a custom highlight scale\. Otherwise,leave it at `Vector3.zero` for default scaling\. |
| [Ignore](./Highlighted/Ignore.md) | Gets the value that if true, the highlight would only activate directly: itwill not be activated when a parent highlight is activated\. Vanilla Only\. |
| [Override](./Highlighted/Override.md) | Gets the value that if true, the highlight would only activate directly: it will notbe activated when a parent highlight is activated\. Vanilla Only\. |

