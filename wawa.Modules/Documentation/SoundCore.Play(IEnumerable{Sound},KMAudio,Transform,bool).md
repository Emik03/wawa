### [wawa.Modules](wawa.Modules.md 'wawa.Modules').[SoundCore](SoundCore.md 'wawa.Modules.SoundCore')

## SoundCore.Play(this IEnumerable<Sound>, KMAudio, Transform, bool) Method

Plays the current sound that is stored.

```csharp
public static System.Collections.Generic.IEnumerable<wawa.Optionals.Maybe<KMAudioRef>> Play(this System.Collections.Generic.IEnumerable<wawa.Modules.Sound> that, KMAudio audio, Transform transform, bool isLooping=false);
```
#### Parameters

<a name='wawa.Modules.SoundCore.Play(thisSystem.Collections.Generic.IEnumerable_wawa.Modules.Sound_,KMAudio,Transform,bool).that'></a>

`that` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Sound](Sound.md 'wawa.Modules.Sound')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

This instance of [Sound](Sound.md 'wawa.Modules.Sound').<p/>`[ItemNotNull]`

<a name='wawa.Modules.SoundCore.Play(thisSystem.Collections.Generic.IEnumerable_wawa.Modules.Sound_,KMAudio,Transform,bool).audio'></a>

`audio` [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio')

The [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to play it from.

<a name='wawa.Modules.SoundCore.Play(thisSystem.Collections.Generic.IEnumerable_wawa.Modules.Sound_,KMAudio,Transform,bool).transform'></a>

`transform` [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform')

The [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform'), which is needed for the location of the sound.

<a name='wawa.Modules.SoundCore.Play(thisSystem.Collections.Generic.IEnumerable_wawa.Modules.Sound_,KMAudio,Transform,bool).isLooping'></a>

`isLooping` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Indicates whether the sound should loop.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudioRef 'KMAudioRef')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A [wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1'), consisting of either a [KMAudio.KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef 'KMAudio.KMAudioRef'),  
or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default') if [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') is unable to play a sound,  
usually caused by playing too many sounds at once.