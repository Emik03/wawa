### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[EntityCore](EntityCore.md 'Wawa.Callbacks.EntityCore')

## EntityCore.ToManyEntities(this IEnumerable<KMBomb>) Method

Creates an [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted.

```csharp
public static System.Collections.ObjectModel.ReadOnlyCollection<System.Collections.ObjectModel.ReadOnlyCollection<Wawa.Callbacks.Entity>> ToManyEntities(this System.Collections.Generic.IEnumerable<KMBomb> bombs);
```
#### Parameters

<a name='Wawa.Callbacks.EntityCore.ToManyEntities(thisSystem.Collections.Generic.IEnumerable_KMBomb_).bombs'></a>

`bombs` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection.

#### Returns
[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[Entity](Entity.md 'Wawa.Callbacks.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')  
An immutable array.