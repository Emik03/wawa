### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[EntityCore](EntityCore.md 'wawa.Recall.EntityCore')

## EntityCore.ToHighlighters(this IEnumerable<Entity>) Method

Creates an [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted.

```csharp
public static System.Collections.ObjectModel.ReadOnlyCollection<wawa.Optionals.Maybe<wawa.Recall.Highlighted>> ToHighlighters(this System.Collections.Generic.IEnumerable<wawa.Recall.Entity> entities);
```
#### Parameters

<a name='wawa.Recall.EntityCore.ToHighlighters(thisSystem.Collections.Generic.IEnumerable_wawa.Recall.Entity_).entities'></a>

`entities` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Entity](Entity.md 'wawa.Recall.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection.

#### Returns
[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[Highlighted](Highlighted.md 'wawa.Recall.Highlighted')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')  
An immutable array.