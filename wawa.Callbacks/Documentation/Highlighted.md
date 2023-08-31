### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks')

## Highlighted Class

Encapsulates a vanilla or modded highlight, and extends functionality to get or  
mutate its inner values and events without worrying the kind of highlight it is.

```csharp
public sealed class Highlighted :
System.ICloneable,
System.IEquatable<Wawa.Callbacks.Highlighted>,
System.Collections.Generic.IEqualityComparer<Wawa.Callbacks.Highlighted>,
Wawa.Callbacks.IVanilla,
System.IEquatable<object>,
Wawa.Callbacks.IValued<MonoBehaviour>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Highlighted

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Highlighted](Highlighted.md 'Wawa.Callbacks.Highlighted')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[Highlighted](Highlighted.md 'Wawa.Callbacks.Highlighted')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1'), [IVanilla](IVanilla.md 'Wawa.Callbacks.IVanilla'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [Wawa.Callbacks.IValued&lt;](IValued{T}.md 'Wawa.Callbacks.IValued<T>')[UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour')[&gt;](IValued{T}.md 'Wawa.Callbacks.IValued<T>')

| Constructors | |
| :--- | :--- |
| [Highlighted(KMHighlightable)](Highlighted..ctor(KMHighlightable).md 'Wawa.Callbacks.Highlighted.Highlighted(KMHighlightable)') | Initializes a new instance of the [Highlighted](Highlighted.md 'Wawa.Callbacks.Highlighted') class.<br/>This guarantees the highlightable kind solvable. |

| Properties | |
| :--- | :--- |
| [Ignore](Highlighted.Ignore.md 'Wawa.Callbacks.Highlighted.Ignore') | Gets the value that if true, the highlight would only activate directly: it<br/>will not be activated when a parent highlight is activated. Vanilla Only. |
| [IsModded](Highlighted.IsModded.md 'Wawa.Callbacks.Highlighted.IsModded') | Gets a value indicating whether this instance contains a modded highlightable. |
| [IsVanilla](Highlighted.IsVanilla.md 'Wawa.Callbacks.Highlighted.IsVanilla') | Gets a value indicating whether this instance contains a vanilla highlightable. |
| [Modded](Highlighted.Modded.md 'Wawa.Callbacks.Highlighted.Modded') | Gets the encapsulated [KMHighlightable](https://docs.microsoft.com/en-us/dotnet/api/KMHighlightable 'KMHighlightable') from this instance. |
| [Outline](Highlighted.Outline.md 'Wawa.Callbacks.Highlighted.Outline') | Gets the outline thickness amount. |
| [Override](Highlighted.Override.md 'Wawa.Callbacks.Highlighted.Override') | Gets the value that if true, the highlight would only activate directly: it will not<br/>be activated when a parent highlight is activated. Vanilla Only. |
| [Scale](Highlighted.Scale.md 'Wawa.Callbacks.Highlighted.Scale') | Gets the scaling. A non-zero value for a custom highlight scale. Otherwise,<br/>leave it at [UnityEngine.Vector3.zero](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Vector3.zero 'UnityEngine.Vector3.zero') for default scaling. |
| [Value](Highlighted.Value.md 'Wawa.Callbacks.Highlighted.Value') | Gets the value which is guaranteed to be a [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour'). |
| [Vanilla](Highlighted.Vanilla.md 'Wawa.Callbacks.Highlighted.Vanilla') | Gets the encapsulated `Highlightable` from this instance. |

| Methods | |
| :--- | :--- |
| [FromComponent(Component)](Highlighted.FromComponent(Component).md 'Wawa.Callbacks.Highlighted.FromComponent(Component)') | Gets a new instance of [Highlighted](Highlighted.md 'Wawa.Callbacks.Highlighted') based on the first found highlightable of the [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component'). |
| [FromKMHighlightable(KMHighlightable)](Highlighted.FromKMHighlightable(KMHighlightable).md 'Wawa.Callbacks.Highlighted.FromKMHighlightable(KMHighlightable)') | Converts the [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Selected](Selected.md 'Wawa.Callbacks.Selected'). |

| Operators | |
| :--- | :--- |
| [operator ==(Highlighted, Highlighted)](Highlighted.op_Equality(Highlighted,Highlighted).md 'Wawa.Callbacks.Highlighted.op_Equality(Wawa.Callbacks.Highlighted, Wawa.Callbacks.Highlighted)') | Determines whether both instances point to the same component. |
| [implicit operator Highlighted(KMHighlightable)](Highlighted.Highlighted(KMHighlightable).md 'Wawa.Callbacks.Highlighted.op_Implicit Wawa.Callbacks.Highlighted(KMHighlightable)') | Implicitly calls the constructor. |
| [operator !=(Highlighted, Highlighted)](Highlighted.op_Inequality(Highlighted,Highlighted).md 'Wawa.Callbacks.Highlighted.op_Inequality(Wawa.Callbacks.Highlighted, Wawa.Callbacks.Highlighted)') | Determines whether both instances do not point to the same component. |
