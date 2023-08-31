### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[EntityCore](EntityCore.md 'Wawa.Recall.EntityCore')

## EntityCore.GetChildren(this GameObject) Method

Gets all modules that are children of a provided [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject').

```csharp
public static System.Collections.ObjectModel.ReadOnlyCollection<Wawa.Recall.Entity> GetChildren(this GameObject gameObject);
```
#### Parameters

<a name='Wawa.Recall.EntityCore.GetChildren(thisGameObject).gameObject'></a>

`gameObject` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')

The [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject') to get the modules from.

#### Returns
[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[Entity](Entity.md 'Wawa.Recall.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')  
A [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') of type [Entity](Entity.md 'Wawa.Recall.Entity')  
which contains every module from [gameObject](EntityCore.GetChildren(GameObject).md#Wawa.Recall.EntityCore.GetChildren(thisGameObject).gameObject 'Wawa.Recall.EntityCore.GetChildren(this GameObject).gameObject').