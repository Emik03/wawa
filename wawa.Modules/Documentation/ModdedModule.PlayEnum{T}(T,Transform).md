### [Wawa.Modules](Wawa.Modules.md 'Wawa.Modules').[ModdedModule](ModdedModule.md 'Wawa.Modules.ModdedModule')

## ModdedModule.PlayEnum<T>(T, Transform) Method

Plays one or more sounds from a specified [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform').

```csharp
public virtual T PlayEnum<T>(T sounds, Transform location=null)
    where T : System.Collections.Generic.IEnumerable<Wawa.Modules.Sound>;
```
#### Type parameters

<a name='Wawa.Modules.ModdedModule.PlayEnum_T_(T,Transform).T'></a>

`T`

The type of iterator.
#### Parameters

<a name='Wawa.Modules.ModdedModule.PlayEnum_T_(T,Transform).sounds'></a>

`sounds` [T](ModdedModule.PlayEnum{T}(T,Transform).md#Wawa.Modules.ModdedModule.PlayEnum_T_(T,Transform).T 'Wawa.Modules.ModdedModule.PlayEnum<T>(T, Transform).T')

The sounds to play.

<a name='Wawa.Modules.ModdedModule.PlayEnum_T_(T,Transform).location'></a>

`location` [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform')

The source of the sound.

#### Returns
[T](ModdedModule.PlayEnum{T}(T,Transform).md#Wawa.Modules.ModdedModule.PlayEnum_T_(T,Transform).T 'Wawa.Modules.ModdedModule.PlayEnum<T>(T, Transform).T')  
The parameter [sounds](ModdedModule.PlayEnum{T}(T,Transform).md#Wawa.Modules.ModdedModule.PlayEnum_T_(T,Transform).sounds 'Wawa.Modules.ModdedModule.PlayEnum<T>(T, Transform).sounds').

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
There isn't exactly 1 [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio')[UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') attached to this [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject').