### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[EntityCore](EntityCore.md 'Wawa.Callbacks.EntityCore')

## EntityCore.ToEntities(this KMBomb) Method

Gets all modules that are children of a provided [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb').

```csharp
public static System.Collections.ObjectModel.ReadOnlyCollection<Wawa.Callbacks.Entity> ToEntities(this KMBomb bomb);
```
#### Parameters

<a name='Wawa.Callbacks.EntityCore.ToEntities(thisKMBomb).bomb'></a>

`bomb` [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb')

The [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb') to get the modules from.

#### Returns
[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[Entity](Entity.md 'Wawa.Callbacks.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')  
A [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') of type [Entity](Entity.md 'Wawa.Callbacks.Entity') which contains every module from [bomb](EntityCore.ToEntities(KMBomb).md#Wawa.Callbacks.EntityCore.ToEntities(thisKMBomb).bomb 'Wawa.Callbacks.EntityCore.ToEntities(this KMBomb).bomb').