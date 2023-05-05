### [Wawa.Modules](Wawa.Modules.md 'Wawa.Modules')

## SoundCore Class

Implementations for [Sound](Sound.md 'Wawa.Modules.Sound').

```csharp
public static class SoundCore
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SoundCore

| Methods | |
| :--- | :--- |
| [AsSound(this string)](SoundCore.AsSound(String).md 'Wawa.Modules.SoundCore.AsSound(this string)') | Creates an instance of [Sound](Sound.md 'Wawa.Modules.Sound') where [Modded](Sound.Modded.md 'Wawa.Modules.Sound.Modded') is set. |
| [Play(this IEnumerable&lt;Sound&gt;, KMAudio, Transform, bool)](SoundCore.Play(IEnumerable{Sound},KMAudio,Transform,Boolean).md 'Wawa.Modules.SoundCore.Play(this System.Collections.Generic.IEnumerable<Wawa.Modules.Sound>, KMAudio, Transform, bool)') | Plays the current sound that is stored. |
| [Play(this Sound, KMAudio, Transform, bool)](SoundCore.Play(Sound,KMAudio,Transform,Boolean).md 'Wawa.Modules.SoundCore.Play(this Wawa.Modules.Sound, KMAudio, Transform, bool)') | Plays the current sound that is stored. |
| [Stop(this Sound)](SoundCore.Stop(Sound).md 'Wawa.Modules.SoundCore.Stop(this Wawa.Modules.Sound)') | Gets the [Reference](Sound.Reference.md 'Wawa.Modules.Sound.Reference') and stops the sound if it is playing. |
| [Stop&lt;T&gt;(this T)](SoundCore.Stop{T}(T).md 'Wawa.Modules.SoundCore.Stop<T>(this T)') | Gets the [Reference](Sound.Reference.md 'Wawa.Modules.Sound.Reference') of a collection of sounds and stops the sound if it is playing. |
| [ToSound(this AudioClip)](SoundCore.ToSound(AudioClip).md 'Wawa.Modules.SoundCore.ToSound(this AudioClip)') | Creates an instance of [Sound](Sound.md 'Wawa.Modules.Sound') where [Modded](Sound.Modded.md 'Wawa.Modules.Sound.Modded') is set. |
| [ToSounds(this IEnumerable&lt;AudioClip&gt;)](SoundCore.ToSounds(IEnumerable{AudioClip}).md 'Wawa.Modules.SoundCore.ToSounds(this System.Collections.Generic.IEnumerable<AudioClip>)') | Creates a [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')<br/>where each element has been converted. |
| [ToSounds(this IEnumerable&lt;string&gt;)](SoundCore.ToSounds(IEnumerable{String}).md 'Wawa.Modules.SoundCore.ToSounds(this System.Collections.Generic.IEnumerable<string>)') | Creates a [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')<br/>where each element has been converted. |
