### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[Entity](Entity.md 'Wawa.Callbacks.Entity')

## Entity.LogEverything() Method

Hooks the logger to all instances.

```csharp
public static System.Collections.ObjectModel.ReadOnlyCollection<System.Collections.ObjectModel.ReadOnlyCollection<Wawa.Callbacks.Entity>> LogEverything();
```

#### Returns
[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[Entity](Entity.md 'Wawa.Callbacks.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')  
All entities in the current scene.

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'Wawa.Callbacks.Generator.Clear<T>(this Wawa.Callbacks.Hook<T>)').