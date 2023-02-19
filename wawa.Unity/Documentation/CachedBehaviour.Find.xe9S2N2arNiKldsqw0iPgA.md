### [Wawa.Unity](Wawa.Unity.md 'Wawa.Unity').[CachedBehaviour](CachedBehaviour.md 'Wawa.Unity.CachedBehaviour')

## CachedBehaviour.Find<T>(bool) Method

Caches and returns any or all [T](CachedBehaviour.Find.xe9S2N2arNiKldsqw0iPgA.md#Wawa.Unity.CachedBehaviour.Find_T_(bool).T 'Wawa.Unity.CachedBehaviour.Find<T>(bool).T') components in the current scene.

```csharp
public virtual T Find<T>(bool includeSelf=false)
    where T : class;
```
#### Type parameters

<a name='Wawa.Unity.CachedBehaviour.Find_T_(bool).T'></a>

`T`

The singular component to locate.  
If this generic is specified as an array, all components are returned.
#### Parameters

<a name='Wawa.Unity.CachedBehaviour.Find_T_(bool).includeSelf'></a>

`includeSelf` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Determines whether the search should include itself.  
Only takes effect when [T](CachedBehaviour.Find.xe9S2N2arNiKldsqw0iPgA.md#Wawa.Unity.CachedBehaviour.Find_T_(bool).T 'Wawa.Unity.CachedBehaviour.Find<T>(bool).T') is [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').

#### Returns
[T](CachedBehaviour.Find.xe9S2N2arNiKldsqw0iPgA.md#Wawa.Unity.CachedBehaviour.Find_T_(bool).T 'Wawa.Unity.CachedBehaviour.Find<T>(bool).T')  
All components in [T](CachedBehaviour.Find.xe9S2N2arNiKldsqw0iPgA.md#Wawa.Unity.CachedBehaviour.Find_T_(bool).T 'Wawa.Unity.CachedBehaviour.Find<T>(bool).T') if [T](CachedBehaviour.Find.xe9S2N2arNiKldsqw0iPgA.md#Wawa.Unity.CachedBehaviour.Find_T_(bool).T 'Wawa.Unity.CachedBehaviour.Find<T>(bool).T') is an array, otherwise any component.

#### Exceptions

[UnityEngine.MissingComponentException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingComponentException 'UnityEngine.MissingComponentException')  
The component [T](CachedBehaviour.Find.xe9S2N2arNiKldsqw0iPgA.md#Wawa.Unity.CachedBehaviour.Find_T_(bool).T 'Wawa.Unity.CachedBehaviour.Find<T>(bool).T') couldn't be located.