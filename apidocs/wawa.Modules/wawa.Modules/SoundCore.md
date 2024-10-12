# SoundCore Class

namespace: [wawa\.Modules](../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../wawa.Modules.md)

Implementations for [Sound](../../wawa.Modules/wawa.Modules/Sound.md)\.

```csharp
public static class SoundCore;
```

Inheritance: `object` > SoundCore

## Methods

| Name | Summary |
|------|---------|
| [Play\(Sound, KMAudio, Transform, bool\)](./SoundCore/Play.md) | Plays the current sound that is stored\. |
| [AsSound\(string\)](./SoundCore/AsSound.md) | Creates an instance of [Sound](../../wawa.Modules/wawa.Modules/Sound.md) where [Modded](../../wawa.Modules/wawa.Modules/Sound/Modded.md) is set\. |
| [AsSound\(SoundEffect\)](./SoundCore/AsSound.md) | Creates an instance of [Sound](../../wawa.Modules/wawa.Modules/Sound.md) where [Vanilla](../../wawa.Modules/wawa.Modules/Sound/Vanilla.md) is set\. |
| [Stop\(Sound\)](./SoundCore/Stop.md) | Gets the [Reference](../../wawa.Modules/wawa.Modules/Sound/Reference.md) and stops the sound if it is playing\. |
| [ToSound\(AudioClip\)](./SoundCore/ToSound.md) | Creates an instance of [Sound](../../wawa.Modules/wawa.Modules/Sound.md) where [Modded](../../wawa.Modules/wawa.Modules/Sound/Modded.md) is set\. |
| [ToSounds\(IEnumerable\<string\>\)](./SoundCore/ToSounds.md) | Creates a `System.Collections.ObjectModel.ReadOnlyCollection<T>`where each element has been converted\. |
| [ToSounds\(IEnumerable\<SoundEffect\>\)](./SoundCore/ToSounds.md) | Creates a `System.Collections.ObjectModel.ReadOnlyCollection<T>`where each element has been converted\. |
| [ToSounds\(IEnumerable\<AudioClip\>\)](./SoundCore/ToSounds.md) | Creates a `System.Collections.ObjectModel.ReadOnlyCollection<T>`where each element has been converted\. |
| [Stop\<T\>\(T\)](./SoundCore/Stop.md) | Gets the [Reference](../../wawa.Modules/wawa.Modules/Sound/Reference.md) of a collection of sounds and stops the sound if it is playing\. |
| [Play\(IEnumerable\<Sound\>, KMAudio, Transform, bool\)](./SoundCore/Play.md) | Plays the current sound that is stored\. |

