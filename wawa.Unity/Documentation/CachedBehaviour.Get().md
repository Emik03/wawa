### [Wawa.Unity](Wawa.Unity.md 'Wawa.Unity').[CachedBehaviour](CachedBehaviour.md 'Wawa.Unity.CachedBehaviour')

## CachedBehaviour.Get<T>() Method

Caches and returns any or all [T](CachedBehaviour.Get().md#Wawa.Unity.CachedBehaviour.Get_T_().T 'Wawa.Unity.CachedBehaviour.Get<T>().T') components in this [UnityEngine.Component.gameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component.gameObject 'UnityEngine.Component.gameObject').

```csharp
public virtual T Get<T>()
    where T : class;
```
#### Type parameters

<a name='Wawa.Unity.CachedBehaviour.Get_T_().T'></a>

`T`

The singular component to locate.  
If this generic is specified as an array, all components are returned.

#### Returns
[T](CachedBehaviour.Get().md#Wawa.Unity.CachedBehaviour.Get_T_().T 'Wawa.Unity.CachedBehaviour.Get<T>().T')  
All components in [T](CachedBehaviour.Get().md#Wawa.Unity.CachedBehaviour.Get_T_().T 'Wawa.Unity.CachedBehaviour.Get<T>().T') if [T](CachedBehaviour.Get().md#Wawa.Unity.CachedBehaviour.Get_T_().T 'Wawa.Unity.CachedBehaviour.Get<T>().T') is an array, otherwise any component.

#### Exceptions

[UnityEngine.MissingComponentException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingComponentException 'UnityEngine.MissingComponentException')  
The component [T](CachedBehaviour.Get().md#Wawa.Unity.CachedBehaviour.Get_T_().T 'Wawa.Unity.CachedBehaviour.Get<T>().T') couldn't be located.