### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[HighlightedCore](HighlightedCore.md 'wawa.Recall.HighlightedCore')

## HighlightedCore.ToEntities(this IEnumerable<Highlighted>) Method

Creates a [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted.

```csharp
public static System.Collections.ObjectModel.ReadOnlyCollection<wawa.Optionals.Maybe<wawa.Recall.Entity>> ToEntities(this System.Collections.Generic.IEnumerable<wawa.Recall.Highlighted> highlighters);
```
#### Parameters

<a name='wawa.Recall.HighlightedCore.ToEntities(thisSystem.Collections.Generic.IEnumerable_wawa.Recall.Highlighted_).highlighters'></a>

`highlighters` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Highlighted](Highlighted.md 'wawa.Recall.Highlighted')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection.

#### Returns
[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[Entity](Entity.md 'wawa.Recall.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')  
An immutable array.