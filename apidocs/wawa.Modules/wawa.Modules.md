# wawa\.Modules Namespace

assembly: [wawa\.Modules](../wawa.Modules.md)



```csharp
namespace wawa.Modules;
```

## Classes

| Name | Summary |
|------|---------|
| [ModdedModule](./wawa.Modules/ModdedModule.md) | The `UnityEngine.Component` that handles general Keep Talking and Nobody Explodes modded module behaviour\. |
| [Sound](./wawa.Modules/Sound.md) | Encapsulates a modded or vanilla sound effect, with methods to play the sound, and allowing you to extendinto the `KMAudio.KMAudioRef` instance that spawns from playing a sound effect\. |
| [SoundCore](./wawa.Modules/SoundCore.md) | Implementations for [Sound](../wawa.Modules/wawa.Modules/Sound.md)\. |
| [State](./wawa.Modules/State.md) | Encapsulation of status conditions for a [ModdedModule](../wawa.Modules/wawa.Modules/ModdedModule.md)\. |

## Interfaces

| Name | Summary |
|------|---------|
| [ISolvable](./wawa.Modules/ISolvable.md) | Interface for Twitch Plays auto\-solvers\. Used by `Module` to abstractly communicatewith Twitch Plays solvers without importing the namespace\. |
