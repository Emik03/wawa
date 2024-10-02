### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[Entity](Entity.md 'wawa.Recall.Entity')

## Entity.LogEverything() Method

Hooks the logger to all instances.

```csharp
public static System.Collections.ObjectModel.ReadOnlyCollection<System.Collections.ObjectModel.ReadOnlyCollection<wawa.Recall.Entity>> LogEverything();
```

#### Returns
[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[Entity](Entity.md 'wawa.Recall.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')  
All entities in the current scene, where each collection represents a separate bomb.

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'wawa.Recall.Generator.Clear<T>(this wawa.Recall.Hook<T>)').