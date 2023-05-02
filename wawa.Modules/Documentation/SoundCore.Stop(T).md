### [Wawa.Modules](Wawa.Modules.md 'Wawa.Modules').[SoundCore](SoundCore.md 'Wawa.Modules.SoundCore')

## SoundCore.Stop<T>(this T) Method

Gets the [Reference](Sound.Reference().md 'Wawa.Modules.Sound.Reference') of a collection of sounds and stops the sound if it is playing.

```csharp
public static T Stop<T>(this T sounds)
    where T : System.Collections.Generic.IEnumerable<Wawa.Modules.Sound>;
```
#### Type parameters

<a name='Wawa.Modules.SoundCore.Stop_T_(thisT).T'></a>

`T`

The type of iterator.
#### Parameters

<a name='Wawa.Modules.SoundCore.Stop_T_(thisT).sounds'></a>

`sounds` [T](SoundCore.Stop(T).md#Wawa.Modules.SoundCore.Stop_T_(thisT).T 'Wawa.Modules.SoundCore.Stop<T>(this T).T')

The multiple [Sound](Sound.md 'Wawa.Modules.Sound') instances to each call [Stop(this Sound)](SoundCore.Stop(Sound).md 'Wawa.Modules.SoundCore.Stop(this Wawa.Modules.Sound)') on.

#### Returns
[T](SoundCore.Stop(T).md#Wawa.Modules.SoundCore.Stop_T_(thisT).T 'Wawa.Modules.SoundCore.Stop<T>(this T).T')  
The parameter [sounds](SoundCore.Stop(T).md#Wawa.Modules.SoundCore.Stop_T_(thisT).sounds 'Wawa.Modules.SoundCore.Stop<T>(this T).sounds').