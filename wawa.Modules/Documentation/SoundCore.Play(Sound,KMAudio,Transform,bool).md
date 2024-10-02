### [wawa.Modules](wawa.Modules.md 'wawa.Modules').[SoundCore](SoundCore.md 'wawa.Modules.SoundCore')

## SoundCore.Play(this Sound, KMAudio, Transform, bool) Method

Plays the current sound that is stored.

```csharp
public static wawa.Optionals.Maybe<KMAudioRef> Play(this wawa.Modules.Sound that, KMAudio audio, Transform transform, bool isLooping=false);
```
#### Parameters

<a name='wawa.Modules.SoundCore.Play(thiswawa.Modules.Sound,KMAudio,Transform,bool).that'></a>

`that` [Sound](Sound.md 'wawa.Modules.Sound')

This instance of [Sound](Sound.md 'wawa.Modules.Sound').

<a name='wawa.Modules.SoundCore.Play(thiswawa.Modules.Sound,KMAudio,Transform,bool).audio'></a>

`audio` [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio')

The [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to play it from.

<a name='wawa.Modules.SoundCore.Play(thiswawa.Modules.Sound,KMAudio,Transform,bool).transform'></a>

`transform` [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform')

The [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform'), which is needed for the location of the sound.

<a name='wawa.Modules.SoundCore.Play(thiswawa.Modules.Sound,KMAudio,Transform,bool).isLooping'></a>

`isLooping` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Indicates whether the sound should loop.

#### Returns
[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudioRef 'KMAudioRef')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')  
A [wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1'), consisting of either a [KMAudio.KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef 'KMAudio.KMAudioRef'),  
or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default') if [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') is unable to play a sound,  
usually caused by playing too many sounds at once.