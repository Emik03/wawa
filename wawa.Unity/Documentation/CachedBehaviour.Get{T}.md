### [wawa.Unity](wawa.Unity.md 'wawa.Unity').[CachedBehaviour](CachedBehaviour.md 'wawa.Unity.CachedBehaviour')

## CachedBehaviour.Get<T>() Method

Caches and returns any or all [T](CachedBehaviour.Get{T}.md#wawa.Unity.CachedBehaviour.Get_T_().T 'wawa.Unity.CachedBehaviour.Get<T>().T') components in this [UnityEngine.Component.gameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component.gameObject 'UnityEngine.Component.gameObject').

```csharp
public T Get<T>()
    where T : class;
```
#### Type parameters

<a name='wawa.Unity.CachedBehaviour.Get_T_().T'></a>

`T`

The singular component to locate.  
If this generic is specified as an array, all components are returned.

#### Returns
[T](CachedBehaviour.Get{T}.md#wawa.Unity.CachedBehaviour.Get_T_().T 'wawa.Unity.CachedBehaviour.Get<T>().T')  
All components in [T](CachedBehaviour.Get{T}.md#wawa.Unity.CachedBehaviour.Get_T_().T 'wawa.Unity.CachedBehaviour.Get<T>().T') if [T](CachedBehaviour.Get{T}.md#wawa.Unity.CachedBehaviour.Get_T_().T 'wawa.Unity.CachedBehaviour.Get<T>().T') is an array, otherwise any component.

#### Exceptions

[UnityEngine.MissingComponentException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingComponentException 'UnityEngine.MissingComponentException')  
The component [T](CachedBehaviour.Get{T}.md#wawa.Unity.CachedBehaviour.Get_T_().T 'wawa.Unity.CachedBehaviour.Get<T>().T') couldn't be located.