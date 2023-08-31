### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks')

## Selected Class

Encapsulates a vanilla or modded selectable, and extends functionality to get or  
mutate its inner values and events without worrying the kind of selectable it is.

```csharp
public sealed class Selected :
System.ICloneable,
System.IEquatable<Wawa.Callbacks.Selected>,
System.Collections.Generic.IEqualityComparer<Wawa.Callbacks.Selected>,
Wawa.Callbacks.IVanilla,
System.IEquatable<object>,
Wawa.Callbacks.IValued<MonoBehaviour>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Selected

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Selected](Selected.md 'Wawa.Callbacks.Selected')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[Selected](Selected.md 'Wawa.Callbacks.Selected')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1'), [IVanilla](IVanilla.md 'Wawa.Callbacks.IVanilla'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [Wawa.Callbacks.IValued&lt;](IValued{T}.md 'Wawa.Callbacks.IValued<T>')[UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour')[&gt;](IValued{T}.md 'Wawa.Callbacks.IValued<T>')

| Constructors | |
| :--- | :--- |
| [Selected(KMSelectable)](Selected..ctor(KMSelectable).md 'Wawa.Callbacks.Selected.Selected(KMSelectable)') | Initializes a new instance of the [Selected](Selected.md 'Wawa.Callbacks.Selected') class. This guarantees the selectable kind solvable. |

| Properties | |
| :--- | :--- |
| [AllowWrapX](Selected.AllowWrapX.md 'Wawa.Callbacks.Selected.AllowWrapX') | Gets a value indicating whether gamepad selection should wrap around left/right. |
| [AllowWrapY](Selected.AllowWrapY.md 'Wawa.Callbacks.Selected.AllowWrapY') | Gets a value indicating whether gamepad selection should wrap around up/down. |
| [Cancel](Selected.Cancel.md 'Wawa.Callbacks.Selected.Cancel') | Gets the [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1') that is called whenever the player backs out of this<br/>selectable, an example would be zooming out of a module. Returning [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')<br/>backs out of the selectable and makes its parent the current, and [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')<br/>does not back out of the selectable and keeps the selectable as the current. |
| [ChildLength](Selected.ChildLength.md 'Wawa.Callbacks.Selected.ChildLength') | Gets the number of children the selectable has. Calling [ChildLength](Selected.ChildLength.md 'Wawa.Callbacks.Selected.ChildLength') is more efficient<br/>than [Children](Selected.Children.md 'Wawa.Callbacks.Selected.Children') then using [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;.Count](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1.Count 'System.Collections.ObjectModel.ReadOnlyCollection`1.Count') because<br/>[Children](Selected.Children.md 'Wawa.Callbacks.Selected.Children') constructs a new [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') when called. |
| [Children](Selected.Children.md 'Wawa.Callbacks.Selected.Children') | Gets the list of child selectables. Order is important as it is treated<br/>as a grid with row length defined by [ChildRowLength](Selected.ChildRowLength.md 'Wawa.Callbacks.Selected.ChildRowLength'). |
| [ChildRowLength](Selected.ChildRowLength.md 'Wawa.Callbacks.Selected.ChildRowLength') | Gets the number of selectables per row for gamepad controls. |
| [Colliders](Selected.Colliders.md 'Wawa.Callbacks.Selected.Colliders') | Gets the interaction colliders for mouse other than the highlight. Modded Only. |
| [DefaultIndex](Selected.DefaultIndex.md 'Wawa.Callbacks.Selected.DefaultIndex') | Gets the particular child as the default index for gamepad controls. |
| [Defocus](Selected.Defocus.md 'Wawa.Callbacks.Selected.Defocus') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is called whenever the module is defocused,<br/>this is when a different selectable becomes the focus or the module has been backed out of. |
| [Deselect](Selected.Deselect.md 'Wawa.Callbacks.Selected.Deselect') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is called whenever this selectable stops being the current selectable. |
| [Focus](Selected.Focus.md 'Wawa.Callbacks.Selected.Focus') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is called whenever the module is focused,<br/>this is when it is interacted with from the bomb face level and this module's children can be selected. |
| [ForceInteractionHighlight](Selected.ForceInteractionHighlight.md 'Wawa.Callbacks.Selected.ForceInteractionHighlight') | Gets a value indicating whether it forces highlight to be interaction highlight,<br/>this is red in game. Should be used when interaction will trigger a behavior. |
| [ForceSelectionHighlight](Selected.ForceSelectionHighlight.md 'Wawa.Callbacks.Selected.ForceSelectionHighlight') | Gets a value indicating whether it forces highlight to be selection highlight,<br/>this is yellow in game. Should be used when interaction will drill down to child selectables. |
| [Highlight](Selected.Highlight.md 'Wawa.Callbacks.Selected.Highlight') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is called whenever the highlight is turned on. |
| [Highlighted](Selected.Highlighted.md 'Wawa.Callbacks.Selected.Highlighted') | Gets the [Highlighted](Selected.Highlighted.md 'Wawa.Callbacks.Selected.Highlighted') for this [Selected](Selected.md 'Wawa.Callbacks.Selected'). |
| [HighlightEnded](Selected.HighlightEnded.md 'Wawa.Callbacks.Selected.HighlightEnded') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is called whenever the highlight is turned off. |
| [Interact](Selected.Interact.md 'Wawa.Callbacks.Selected.Interact') | Gets the [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1') that is called whenever the player interacts with<br/>this selectable. Done on button down. Returning [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') makes the selectable<br/>behave as a module with children, and [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') as a button with no children. |
| [InteractEnded](Selected.InteractEnded.md 'Wawa.Callbacks.Selected.InteractEnded') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is called whenever the player is interacting<br/>with this selectable and releases the mouse or controller button. |
| [InteractionPunch](Selected.InteractionPunch.md 'Wawa.Callbacks.Selected.InteractionPunch') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that when called, performs an interaction punch<br/>or bomb shake with the impact level based on the parameter passed in. Modded Only. |
| [IsModded](Selected.IsModded.md 'Wawa.Callbacks.Selected.IsModded') | Gets a value indicating whether this instance contains a modded selectable. |
| [IsPassThrough](Selected.IsPassThrough.md 'Wawa.Callbacks.Selected.IsPassThrough') | Gets a value indicating whether this selectable is essentially a container, currently used for bomb faces. |
| [IsVanilla](Selected.IsVanilla.md 'Wawa.Callbacks.Selected.IsVanilla') | Gets a value indicating whether this instance contains a vanilla selectable. |
| [Left](Selected.Left.md 'Wawa.Callbacks.Selected.Left') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is called whenever the player<br/>pulls selection stick left while this selectable is focused. |
| [Modded](Selected.Modded.md 'Wawa.Callbacks.Selected.Modded') | Gets the encapsulated [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') from this instance<br/>as [Wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1') due to ambiguity in this value being set. |
| [Parent](Selected.Parent.md 'Wawa.Callbacks.Selected.Parent') | Gets the parent of this selectable. |
| [Right](Selected.Right.md 'Wawa.Callbacks.Selected.Right') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is called whenever player<br/>pulls selection stick right while this selectable is focused. |
| [Scale](Selected.Scale.md 'Wawa.Callbacks.Selected.Scale') | Gets the scaling. A non-zero value for a custom highlight scale. Otherwise,<br/>leave it at [UnityEngine.Vector3.zero](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Vector3.zero 'UnityEngine.Vector3.zero') for default scaling. Vanilla Only. |
| [Select](Selected.Select.md 'Wawa.Callbacks.Selected.Select') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that is called whenever this selectable becomes the current selectable. |
| [UpdateChildren](Selected.UpdateChildren.md 'Wawa.Callbacks.Selected.UpdateChildren') | Gets the [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') that when called, updates the list of children,<br/>with the parameter being the [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') to select. Modded Only. |
| [Value](Selected.Value.md 'Wawa.Callbacks.Selected.Value') | Gets the value which is guaranteed to be a [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour'). |
| [Vanilla](Selected.Vanilla.md 'Wawa.Callbacks.Selected.Vanilla') | Gets the encapsulated `Selectable` from this instance. |

| Methods | |
| :--- | :--- |
| [FromComponent(Component)](Selected.FromComponent(Component).md 'Wawa.Callbacks.Selected.FromComponent(Component)') | Gets a new instance of [Selected](Selected.md 'Wawa.Callbacks.Selected') based on<br/>the first found selectable of the [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component'). |
| [FromKMSelectable(KMSelectable)](Selected.FromKMSelectable(KMSelectable).md 'Wawa.Callbacks.Selected.FromKMSelectable(KMSelectable)') | Converts the [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Selected](Selected.md 'Wawa.Callbacks.Selected'). |

| Operators | |
| :--- | :--- |
| [operator ==(Selected, Selected)](Selected.op_Equality(Selected,Selected).md 'Wawa.Callbacks.Selected.op_Equality(Wawa.Callbacks.Selected, Wawa.Callbacks.Selected)') | Determines whether both instances point to the same component. |
| [implicit operator Selected(KMSelectable)](Selected.Selected(KMSelectable).md 'Wawa.Callbacks.Selected.op_Implicit Wawa.Callbacks.Selected(KMSelectable)') | Implicitly calls the constructor. |
| [operator !=(Selected, Selected)](Selected.op_Inequality(Selected,Selected).md 'Wawa.Callbacks.Selected.op_Inequality(Wawa.Callbacks.Selected, Wawa.Callbacks.Selected)') | Determines whether both instances do not point to the same component. |
