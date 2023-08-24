### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[HighlightedCore](HighlightedCore.md 'Wawa.Callbacks.HighlightedCore')

## HighlightedCore.ToHighlighters(this IEnumerable<KMHighlightable>) Method

Creates a [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted.

```csharp
public static System.Collections.ObjectModel.ReadOnlyCollection<Wawa.Callbacks.Highlighted> ToHighlighters(this System.Collections.Generic.IEnumerable<KMHighlightable> highlightables);
```
#### Parameters

<a name='Wawa.Callbacks.HighlightedCore.ToHighlighters(thisSystem.Collections.Generic.IEnumerable_KMHighlightable_).highlightables'></a>

`highlightables` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[KMHighlightable](https://docs.microsoft.com/en-us/dotnet/api/KMHighlightable 'KMHighlightable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection.

#### Returns
[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[Highlighted](Highlighted.md 'Wawa.Callbacks.Highlighted')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')  
An immutable array.