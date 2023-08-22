### [Wawa.Modules](Wawa.Modules.md 'Wawa.Modules').[ModdedModule](ModdedModule.md 'Wawa.Modules.ModdedModule')

## ModdedModule.Play(Sound[]) Method

Plays one or more sounds from the module [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform').

```csharp
public virtual System.Collections.Generic.IList<Wawa.Modules.Sound> Play(params Wawa.Modules.Sound[] sounds);
```
#### Parameters

<a name='Wawa.Modules.ModdedModule.Play(Wawa.Modules.Sound[]).sounds'></a>

`sounds` [Sound](Sound.md 'Wawa.Modules.Sound')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The sounds to play.

#### Returns
[System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[Sound](Sound.md 'Wawa.Modules.Sound')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
The parameter [sounds](ModdedModule.Play(Sound[]).md#Wawa.Modules.ModdedModule.Play(Wawa.Modules.Sound[]).sounds 'Wawa.Modules.ModdedModule.Play(Wawa.Modules.Sound[]).sounds').

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
There isn't exactly 1 [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio')[UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') attached to this [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject').