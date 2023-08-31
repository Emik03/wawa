### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall')

## HighlightedCore Class

Implementations for [Highlighted](Highlighted.md 'Wawa.Recall.Highlighted').

```csharp
public static class HighlightedCore
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; HighlightedCore

| Methods | |
| :--- | :--- |
| [AsHighlighter(this KMHighlightable)](HighlightedCore.AsHighlighter(KMHighlightable).md 'Wawa.Recall.HighlightedCore.AsHighlighter(this KMHighlightable)') | Creates an instance of [Entity](Entity.md 'Wawa.Recall.Entity') where [Solvable](Entity.Solvable.md 'Wawa.Recall.Entity.Solvable') is set. |
| [ToEntities(this IEnumerable&lt;Highlighted&gt;)](HighlightedCore.ToEntities(IEnumerable{Highlighted}).md 'Wawa.Recall.HighlightedCore.ToEntities(this System.Collections.Generic.IEnumerable<Wawa.Recall.Highlighted>)') | Creates a [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
| [ToEntity(this Highlighted)](HighlightedCore.ToEntity(Highlighted).md 'Wawa.Recall.HighlightedCore.ToEntity(this Wawa.Recall.Highlighted)') | Gets the [Entity](Entity.md 'Wawa.Recall.Entity') of this [Highlighted](Highlighted.md 'Wawa.Recall.Highlighted').<br/>An empty value is given if there is no attached [Entity](Entity.md 'Wawa.Recall.Entity') on the [Highlighted](Highlighted.md 'Wawa.Recall.Highlighted'). |
| [ToHighlighters(this IEnumerable&lt;KMHighlightable&gt;)](HighlightedCore.ToHighlighters(IEnumerable{KMHighlightable}).md 'Wawa.Recall.HighlightedCore.ToHighlighters(this System.Collections.Generic.IEnumerable<KMHighlightable>)') | Creates a [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
