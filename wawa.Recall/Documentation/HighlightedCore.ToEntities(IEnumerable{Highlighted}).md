### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[HighlightedCore](HighlightedCore.md 'Wawa.Callbacks.HighlightedCore')

## HighlightedCore.ToEntities(this IEnumerable<Highlighted>) Method

Creates a [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted.

```csharp
public static System.Collections.ObjectModel.ReadOnlyCollection<Wawa.Optionals.Maybe<Wawa.Callbacks.Entity>> ToEntities(this System.Collections.Generic.IEnumerable<Wawa.Callbacks.Highlighted> highlighters);
```
#### Parameters

<a name='Wawa.Callbacks.HighlightedCore.ToEntities(thisSystem.Collections.Generic.IEnumerable_Wawa.Callbacks.Highlighted_).highlighters'></a>

`highlighters` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Highlighted](Highlighted.md 'Wawa.Callbacks.Highlighted')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection.

#### Returns
[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[Entity](Entity.md 'Wawa.Callbacks.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')  
An immutable array.