### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks')

## SelectedCore Class

Implementations for [Selected](Selected.md 'Wawa.Callbacks.Selected').

```csharp
public static class SelectedCore
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SelectedCore

| Methods | |
| :--- | :--- |
| [AsSelectable(this KMSelectable)](SelectedCore.AsSelectable(KMSelectable).md 'Wawa.Callbacks.SelectedCore.AsSelectable(this KMSelectable)') | Creates an instance of [Entity](Entity.md 'Wawa.Callbacks.Entity') where [Solvable](Entity.Solvable.md 'Wawa.Callbacks.Entity.Solvable') is set. |
| [ToEntities(this IEnumerable&lt;Selected&gt;)](SelectedCore.ToEntities(IEnumerable{Selected}).md 'Wawa.Callbacks.SelectedCore.ToEntities(this System.Collections.Generic.IEnumerable<Wawa.Callbacks.Selected>)') | Creates an [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
| [ToEntity(this Selected)](SelectedCore.ToEntity(Selected).md 'Wawa.Callbacks.SelectedCore.ToEntity(this Wawa.Callbacks.Selected)') | Gets the [Entity](Entity.md 'Wawa.Callbacks.Entity') of this [Selected](Selected.md 'Wawa.Callbacks.Selected').<br/>An empty value is given if there is no attached [Entity](Entity.md 'Wawa.Callbacks.Entity') on the [Selected](Selected.md 'Wawa.Callbacks.Selected'). |
| [ToSelectables(this IEnumerable&lt;KMSelectable&gt;)](SelectedCore.ToSelectables(IEnumerable{KMSelectable}).md 'Wawa.Callbacks.SelectedCore.ToSelectables(this System.Collections.Generic.IEnumerable<KMSelectable>)') | Creates an [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
