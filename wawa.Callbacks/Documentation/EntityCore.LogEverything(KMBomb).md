### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[EntityCore](EntityCore.md 'Wawa.Callbacks.EntityCore')

## EntityCore.LogEverything(this KMBomb) Method

Hooks the logger to all instances.

```csharp
public static System.Collections.ObjectModel.ReadOnlyCollection<Wawa.Callbacks.Entity> LogEverything(this KMBomb that);
```
#### Parameters

<a name='Wawa.Callbacks.EntityCore.LogEverything(thisKMBomb).that'></a>

`that` [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb')

This instance of [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb').

#### Returns
[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[Entity](Entity.md 'Wawa.Callbacks.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')  
All entities of the parameter [that](EntityCore.LogEverything(KMBomb).md#Wawa.Callbacks.EntityCore.LogEverything(thisKMBomb).that 'Wawa.Callbacks.EntityCore.LogEverything(this KMBomb).that').

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'Wawa.Callbacks.Generator.Clear<T>(this Wawa.Callbacks.Hook<T>)').