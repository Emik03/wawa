### [wawa.Modules](wawa.Modules.md 'wawa.Modules').[SoundCore](SoundCore.md 'wawa.Modules.SoundCore')

## SoundCore.Stop<T>(this T) Method

Gets the [Reference](Sound.Reference.md 'wawa.Modules.Sound.Reference') of a collection of sounds and stops the sound if it is playing.

```csharp
public static T Stop<T>(this T sounds)
    where T : System.Collections.Generic.IEnumerable<wawa.Modules.Sound>;
```
#### Type parameters

<a name='wawa.Modules.SoundCore.Stop_T_(thisT).T'></a>

`T`

The type of iterator.
#### Parameters

<a name='wawa.Modules.SoundCore.Stop_T_(thisT).sounds'></a>

`sounds` [T](SoundCore.Stop{T}(T).md#wawa.Modules.SoundCore.Stop_T_(thisT).T 'wawa.Modules.SoundCore.Stop<T>(this T).T')

The multiple [Sound](Sound.md 'wawa.Modules.Sound') instances to each call [Stop(this Sound)](SoundCore.Stop(Sound).md 'wawa.Modules.SoundCore.Stop(this wawa.Modules.Sound)') on.

#### Returns
[T](SoundCore.Stop{T}(T).md#wawa.Modules.SoundCore.Stop_T_(thisT).T 'wawa.Modules.SoundCore.Stop<T>(this T).T')  
The parameter [sounds](SoundCore.Stop{T}(T).md#wawa.Modules.SoundCore.Stop_T_(thisT).sounds 'wawa.Modules.SoundCore.Stop<T>(this T).sounds').