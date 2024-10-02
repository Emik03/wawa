### [wawa.Modules](wawa.Modules.md 'wawa.Modules').[SoundCore](SoundCore.md 'wawa.Modules.SoundCore')

## SoundCore.ToSounds(this IEnumerable<AudioClip>) Method

Creates a [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')  
where each element has been converted.

```csharp
public static System.Collections.ObjectModel.ReadOnlyCollection<wawa.Modules.Sound> ToSounds(this System.Collections.Generic.IEnumerable<AudioClip> sounds);
```
#### Parameters

<a name='wawa.Modules.SoundCore.ToSounds(thisSystem.Collections.Generic.IEnumerable_AudioClip_).sounds'></a>

`sounds` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[UnityEngine.AudioClip](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.AudioClip 'UnityEngine.AudioClip')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection.

#### Returns
[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[Sound](Sound.md 'wawa.Modules.Sound')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')  
An immutable array.