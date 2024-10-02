### [wawa.Recall](wawa.Recall.md 'wawa.Recall')

## HighlightedCore Class

Implementations for [Highlighted](Highlighted.md 'wawa.Recall.Highlighted').

```csharp
public static class HighlightedCore
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; HighlightedCore

| Methods | |
| :--- | :--- |
| [AsHighlighter(this KMHighlightable)](HighlightedCore.AsHighlighter(KMHighlightable).md 'wawa.Recall.HighlightedCore.AsHighlighter(this KMHighlightable)') | Creates an instance of [Entity](Entity.md 'wawa.Recall.Entity') where [Solvable](Entity.Solvable.md 'wawa.Recall.Entity.Solvable') is set. |
| [ToEntities(this IEnumerable&lt;Highlighted&gt;)](HighlightedCore.ToEntities(IEnumerable{Highlighted}).md 'wawa.Recall.HighlightedCore.ToEntities(this System.Collections.Generic.IEnumerable<wawa.Recall.Highlighted>)') | Creates a [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
| [ToEntity(this Highlighted)](HighlightedCore.ToEntity(Highlighted).md 'wawa.Recall.HighlightedCore.ToEntity(this wawa.Recall.Highlighted)') | Gets the [Entity](Entity.md 'wawa.Recall.Entity') of this [Highlighted](Highlighted.md 'wawa.Recall.Highlighted').<br/>An empty value is given if there is no attached [Entity](Entity.md 'wawa.Recall.Entity') on the [Highlighted](Highlighted.md 'wawa.Recall.Highlighted'). |
| [ToHighlighters(this IEnumerable&lt;KMHighlightable&gt;)](HighlightedCore.ToHighlighters(IEnumerable{KMHighlightable}).md 'wawa.Recall.HighlightedCore.ToHighlighters(this System.Collections.Generic.IEnumerable<KMHighlightable>)') | Creates a [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
