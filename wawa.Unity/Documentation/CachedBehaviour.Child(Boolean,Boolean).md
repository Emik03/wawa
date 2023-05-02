### [Wawa.Unity](Wawa.Unity.md 'Wawa.Unity').[CachedBehaviour](CachedBehaviour.md 'Wawa.Unity.CachedBehaviour')

## CachedBehaviour.Child<T>(bool, bool) Method

Caches and returns any or all [T](CachedBehaviour.Child(Boolean,Boolean).md#Wawa.Unity.CachedBehaviour.Child_T_(bool,bool).T 'Wawa.Unity.CachedBehaviour.Child<T>(bool, bool).T') components  
in this [UnityEngine.Component.gameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component.gameObject 'UnityEngine.Component.gameObject') and all children.

```csharp
public virtual T Child<T>(bool includeInactive=false, bool includeSelf=false)
    where T : class;
```
#### Type parameters

<a name='Wawa.Unity.CachedBehaviour.Child_T_(bool,bool).T'></a>

`T`

The singular component to locate. If this generic is specified as an array,  
all components are returned.
#### Parameters

<a name='Wawa.Unity.CachedBehaviour.Child_T_(bool,bool).includeInactive'></a>

`includeInactive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Determines whether the search should include inactive [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject') instances.

<a name='Wawa.Unity.CachedBehaviour.Child_T_(bool,bool).includeSelf'></a>

`includeSelf` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Determines whether the search should include itself.  
Only takes effect when [T](CachedBehaviour.Child(Boolean,Boolean).md#Wawa.Unity.CachedBehaviour.Child_T_(bool,bool).T 'Wawa.Unity.CachedBehaviour.Child<T>(bool, bool).T') is [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').

#### Returns
[T](CachedBehaviour.Child(Boolean,Boolean).md#Wawa.Unity.CachedBehaviour.Child_T_(bool,bool).T 'Wawa.Unity.CachedBehaviour.Child<T>(bool, bool).T')  
All components in [T](CachedBehaviour.Child(Boolean,Boolean).md#Wawa.Unity.CachedBehaviour.Child_T_(bool,bool).T 'Wawa.Unity.CachedBehaviour.Child<T>(bool, bool).T') if [T](CachedBehaviour.Child(Boolean,Boolean).md#Wawa.Unity.CachedBehaviour.Child_T_(bool,bool).T 'Wawa.Unity.CachedBehaviour.Child<T>(bool, bool).T') is an array, otherwise any component.

#### Exceptions

[UnityEngine.MissingComponentException](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MissingComponentException 'UnityEngine.MissingComponentException')  
The component [T](CachedBehaviour.Child(Boolean,Boolean).md#Wawa.Unity.CachedBehaviour.Child_T_(bool,bool).T 'Wawa.Unity.CachedBehaviour.Child<T>(bool, bool).T') couldn't be located.