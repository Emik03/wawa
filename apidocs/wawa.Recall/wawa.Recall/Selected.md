# Selected Class

namespace: [wawa\.Recall](../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../wawa.Recall.md)

Encapsulates a vanilla or modded selectable, and extends functionality to get or
mutate its inner values and events without worrying the kind of selectable it is\.

```csharp
public sealed class Selected;
```

Inheritance: `ICloneable` > Selected

Implements: `IEquatable<Selected>`, `IEqualityComparer<Selected>`, [IVanilla](../../wawa.Recall/wawa.Recall/IVanilla.md)

## Constructors

| Name | Summary |
|------|---------|
| [Selected\(KMSelectable\)](./Selected/$ctor.md) | Initializes a new instance of the [Selected](../../wawa.Recall/wawa.Recall/Selected.md) class\. This guarantees the selectable kind solvable\. |

## Methods

| Name | Summary |
|------|---------|
| [operator ==\(Selected?, Selected?\)](./Selected/op_Equality.md) | Determines whether both instances point to the same component\. |
| [operator \!=\(Selected?, Selected?\)](./Selected/op_Inequality.md) | Determines whether both instances do not point to the same component\. |
| [implicit operator Selected\(KMSelectable\)](./Selected/op_Implicit.md) | Implicitly calls the constructor\. |
| [FromKMSelectable\(KMSelectable\)](./Selected/FromKMSelectable.md) | Converts the `KMBombModule` to a `new`[Selected](../../wawa.Recall/wawa.Recall/Selected.md)\. |
| [FromComponent\(UnityEngine\.Component\)](./Selected/FromComponent.md) | Gets a new instance of [Selected](../../wawa.Recall/wawa.Recall/Selected.md) based onthe first found selectable of the `UnityEngine.Component`\. |
| [Equals\(Selected\)](./Selected/Equals.md) |  |
| [Equals\(Selected, Selected\)](./Selected/Equals.md) |  |
| [GetHashCode\(Selected\)](./Selected/GetHashCode.md) |  |
| [Clone\(\)](./Selected/Clone.md) |  |
| [Equals\(object\)](./Selected/Equals.md) |  |
| [GetHashCode\(\)](./Selected/GetHashCode.md) |  |
| [ToString\(\)](./Selected/ToString.md) |  |

## Properties

| Name | Summary |
|------|---------|
| [Value](./Selected/Value.md) | Gets the value which is guaranteed to be a `UnityEngine.MonoBehaviour`\. |
| [ChildLength](./Selected/ChildLength.md) | Gets the number of children the selectable has\. Calling [ChildLength](../../wawa.Recall/wawa.Recall/Selected/ChildLength.md) is more efficientthan [Children](../../wawa.Recall/wawa.Recall/Selected/Children.md) then using `ReadOnlyCollection<T>.Count` because[Children](../../wawa.Recall/wawa.Recall/Selected/Children.md) constructs a new `ReadOnlyCollection<T>` every time\. |
| [Highlighted](./Selected/Highlighted.md) | Gets the [Highlighted](../../wawa.Recall/wawa.Recall/Selected/Highlighted.md) for this [Selected](../../wawa.Recall/wawa.Recall/Selected.md)\. |
| [Select](./Selected/Select.md) | Gets the `Action` that is called whenever this selectable becomes the current selectable\. |
| [Deselect](./Selected/Deselect.md) | Gets the `Action` that is called whenever this selectable stops being the current selectable\. |
| [Cancel](./Selected/Cancel.md) | Gets the `Func<TResult>` that is called whenever the player backs out of thisselectable, an example would be zooming out of a module\. Returning `true`backs out of the selectable and makes its parent the current, and `false`does not back out of the selectable and keeps the selectable as the current\. |
| [Interact](./Selected/Interact.md) | Gets the `Func<TResult>` that is called whenever the player interacts withthis selectable\. Done on button down\. Returning `true` makes the selectablebehave as a module with children, and `false` as a button with no children\. |
| [InteractEnded](./Selected/InteractEnded.md) | Gets the `Action` that is called whenever the player is interactingwith this selectable and releases the mouse or controller button\. |
| [Highlight](./Selected/Highlight.md) | Gets the `Action` that is called whenever the highlight is turned on\. |
| [HighlightEnded](./Selected/HighlightEnded.md) | Gets the `Action` that is called whenever the highlight is turned off\. |
| [Focus](./Selected/Focus.md) | Gets the `Action` that is called whenever the module is focused,this is when it is interacted with from the bomb face level and this module's children can be selected\. |
| [Defocus](./Selected/Defocus.md) | Gets the `Action` that is called whenever the module is defocused,this is when a different selectable becomes the focus or the module has been backed out of\. |
| [Left](./Selected/Left.md) | Gets the `Action` that is called whenever the playerpulls selection stick left while this selectable is focused\. |
| [Right](./Selected/Right.md) | Gets the `Action` that is called whenever playerpulls selection stick right while this selectable is focused\. |
| [InteractionPunch](./Selected/InteractionPunch.md) | Gets the `Action` that when called, performs an interaction punchor bomb shake with the impact level based on the parameter passed in\. Modded Only\. |
| [UpdateChildren](./Selected/UpdateChildren.md) | Gets the `Action` that when called, updates the list of children,with the parameter being the `KMSelectable` to select\. Modded Only\. |
| [Modded](./Selected/Modded.md) | Gets the encapsulated `KMSelectable` from this instanceas [Maybe\<T\>](../../wawa.Optionals/wawa.Optionals/Maybe\`1.md) due to ambiguity in this value being set\. |
| [Vanilla](./Selected/Vanilla.md) | Gets the encapsulated `Selectable` from this instance\. |
| [Parent](./Selected/Parent.md) | Gets the parent of this selectable\. |
| [AllowWrapX](./Selected/AllowWrapX.md) | Gets a value indicating whether gamepad selection should wrap around left/right\. |
| [AllowWrapY](./Selected/AllowWrapY.md) | Gets a value indicating whether gamepad selection should wrap around up/down\. |
| [ForceSelectionHighlight](./Selected/ForceSelectionHighlight.md) | Gets a value indicating whether it forces highlight to be selection highlight,this is yellow in game\. Should be used when interaction will drill down to child selectables\. |
| [ForceInteractionHighlight](./Selected/ForceInteractionHighlight.md) | Gets a value indicating whether it forces highlight to be interaction highlight,this is red in game\. Should be used when interaction will trigger a behavior\. |
| [IsPassThrough](./Selected/IsPassThrough.md) | Gets a value indicating whether this selectable is essentially a container, currently used for bomb faces\. |
| [ChildRowLength](./Selected/ChildRowLength.md) | Gets the number of selectables per row for gamepad controls\. |
| [DefaultIndex](./Selected/DefaultIndex.md) | Gets the particular child as the default index for gamepad controls\. |
| [Colliders](./Selected/Colliders.md) | Gets the interaction colliders for mouse other than the highlight\. Modded Only\. |
| [Scale](./Selected/Scale.md) | Gets the scaling\. A non\-zero value for a custom highlight scale\. Otherwise,leave it at `Vector3.zero` for default scaling\. Vanilla Only\. |
| [Children](./Selected/Children.md) | Gets the list of child selectables\. Order is important as it is treatedas a grid with row length defined by [ChildRowLength](../../wawa.Recall/wawa.Recall/Selected/ChildRowLength.md)\. |
| [IsModded](./Selected/IsModded.md) | Gets a value indicating whether this instance contains a modded selectable\. |
| [IsVanilla](./Selected/IsVanilla.md) | Gets a value indicating whether this instance contains a vanilla selectable\. |

