### [wawa.Modules](wawa.Modules.md 'wawa.Modules').[ModdedModule](ModdedModule.md 'wawa.Modules.ModdedModule')

## ModdedModule.Shake(KMSelectable, float, Sound[]) Method

Plays sounds and shakes the bomb from a selectable.

```csharp
public KMSelectable Shake(KMSelectable selectable, float intensityModifier=0f, params wawa.Modules.Sound[] sounds);
```
#### Parameters

<a name='wawa.Modules.ModdedModule.Shake(KMSelectable,float,wawa.Modules.Sound[]).selectable'></a>

`selectable` [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')

The source of the interaction punch and sound source.

<a name='wawa.Modules.ModdedModule.Shake(KMSelectable,float,wawa.Modules.Sound[]).intensityModifier'></a>

`intensityModifier` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The intensity of the interaction punch.

<a name='wawa.Modules.ModdedModule.Shake(KMSelectable,float,wawa.Modules.Sound[]).sounds'></a>

`sounds` [Sound](Sound.md 'wawa.Modules.Sound')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The sounds to play.<p/>`[ItemCanBeNull]`

#### Returns
[KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')  
The parameter [selectable](ModdedModule.Shake(KMSelectable,float,Sound[]).md#wawa.Modules.ModdedModule.Shake(KMSelectable,float,wawa.Modules.Sound[]).selectable 'wawa.Modules.ModdedModule.Shake(KMSelectable, float, wawa.Modules.Sound[]).selectable').