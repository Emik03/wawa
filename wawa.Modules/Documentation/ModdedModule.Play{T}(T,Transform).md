### [wawa.Modules](wawa.Modules.md 'wawa.Modules').[ModdedModule](ModdedModule.md 'wawa.Modules.ModdedModule')

## ModdedModule.Play<T>(T, Transform) Method

Plays one or more sounds from a specified [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform').<p/>`[ItemCanBeNull]`

```csharp
public T Play<T>(T sounds, Transform location=null)
    where T : System.Collections.Generic.IEnumerable<wawa.Modules.Sound>;
```
#### Type parameters

<a name='wawa.Modules.ModdedModule.Play_T_(T,Transform).T'></a>

`T`

The type of iterator.
#### Parameters

<a name='wawa.Modules.ModdedModule.Play_T_(T,Transform).sounds'></a>

`sounds` [T](ModdedModule.Play{T}(T,Transform).md#wawa.Modules.ModdedModule.Play_T_(T,Transform).T 'wawa.Modules.ModdedModule.Play<T>(T, Transform).T')

The sounds to play.<p/>`[ItemCanBeNull]`

<a name='wawa.Modules.ModdedModule.Play_T_(T,Transform).location'></a>

`location` [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform')

The source of the sound.

#### Returns
[T](ModdedModule.Play{T}(T,Transform).md#wawa.Modules.ModdedModule.Play_T_(T,Transform).T 'wawa.Modules.ModdedModule.Play<T>(T, Transform).T')  
The parameter [sounds](ModdedModule.Play{T}(T,Transform).md#wawa.Modules.ModdedModule.Play_T_(T,Transform).sounds 'wawa.Modules.ModdedModule.Play<T>(T, Transform).sounds').