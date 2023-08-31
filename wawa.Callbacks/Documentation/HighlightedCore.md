### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks')

## HighlightedCore Class

Implementations for [Highlighted](Highlighted.md 'Wawa.Callbacks.Highlighted').

```csharp
public static class HighlightedCore
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; HighlightedCore

| Methods | |
| :--- | :--- |
| [AsHighlighter(this KMHighlightable)](HighlightedCore.AsHighlighter(KMHighlightable).md 'Wawa.Callbacks.HighlightedCore.AsHighlighter(this KMHighlightable)') | Creates an instance of [Entity](Entity.md 'Wawa.Callbacks.Entity') where [Solvable](Entity.Solvable.md 'Wawa.Callbacks.Entity.Solvable') is set. |
| [ToEntities(this IEnumerable&lt;Highlighted&gt;)](HighlightedCore.ToEntities(IEnumerable{Highlighted}).md 'Wawa.Callbacks.HighlightedCore.ToEntities(this System.Collections.Generic.IEnumerable<Wawa.Callbacks.Highlighted>)') | Creates a [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
| [ToEntity(this Highlighted)](HighlightedCore.ToEntity(Highlighted).md 'Wawa.Callbacks.HighlightedCore.ToEntity(this Wawa.Callbacks.Highlighted)') | Gets the [Entity](Entity.md 'Wawa.Callbacks.Entity') of this [Highlighted](Highlighted.md 'Wawa.Callbacks.Highlighted').<br/>An empty value is given if there is no attached [Entity](Entity.md 'Wawa.Callbacks.Entity') on the [Highlighted](Highlighted.md 'Wawa.Callbacks.Highlighted'). |
| [ToHighlighters(this IEnumerable&lt;KMHighlightable&gt;)](HighlightedCore.ToHighlighters(IEnumerable{KMHighlightable}).md 'Wawa.Callbacks.HighlightedCore.ToHighlighters(this System.Collections.Generic.IEnumerable<KMHighlightable>)') | Creates a [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
