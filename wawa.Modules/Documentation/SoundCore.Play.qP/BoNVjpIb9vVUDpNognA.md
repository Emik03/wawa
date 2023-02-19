### [Wawa.Modules](Wawa.Modules.md 'Wawa.Modules').[SoundCore](SoundCore.md 'Wawa.Modules.SoundCore')

## SoundCore.Play(this Sound, KMAudio, Transform, bool) Method

Plays the current sound that is stored.

```csharp
public static Wawa.Optionals.Maybe<KMAudioRef> Play(this Wawa.Modules.Sound that, KMAudio audio, Transform transform, bool isLooping=false);
```
#### Parameters

<a name='Wawa.Modules.SoundCore.Play(thisWawa.Modules.Sound,KMAudio,Transform,bool).that'></a>

`that` [Sound](Sound.md 'Wawa.Modules.Sound')

This instance of [Sound](Sound.md 'Wawa.Modules.Sound').

<a name='Wawa.Modules.SoundCore.Play(thisWawa.Modules.Sound,KMAudio,Transform,bool).audio'></a>

`audio` [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio')

The [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') to play it from.

<a name='Wawa.Modules.SoundCore.Play(thisWawa.Modules.Sound,KMAudio,Transform,bool).transform'></a>

`transform` [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform')

The [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform'), which is needed for the location of the sound.

<a name='Wawa.Modules.SoundCore.Play(thisWawa.Modules.Sound,KMAudio,Transform,bool).isLooping'></a>

`isLooping` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Indicates whether the sound should loop.

#### Returns
[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudioRef 'KMAudioRef')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')  
A [Wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1'), consisting of either a [KMAudio.KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef 'KMAudio.KMAudioRef'),  
or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default') if [KMAudio](https://docs.microsoft.com/en-us/dotnet/api/KMAudio 'KMAudio') is unable to play a sound,  
usually caused by playing too many sounds at once.