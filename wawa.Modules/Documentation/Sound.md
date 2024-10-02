### [wawa.Modules](wawa.Modules.md 'wawa.Modules')

## Sound Class

Encapsulates a modded or vanilla sound effect, with methods to play the sound, and allowing you to extend  
into the [KMAudio.KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef 'KMAudio.KMAudioRef') instance that spawns from playing a sound effect.

```csharp
public sealed class Sound :
System.ICloneable,
System.IEquatable<wawa.Modules.Sound>,
System.Collections.Generic.IEqualityComparer<wawa.Modules.Sound>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Sound

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Sound](Sound.md 'wawa.Modules.Sound')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[Sound](Sound.md 'wawa.Modules.Sound')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

| Constructors | |
| :--- | :--- |
| [Sound(Object)](Sound..ctor(Object).md 'wawa.Modules.Sound.Sound(Object)') | Initializes a new instance of the [Sound](Sound.md 'wawa.Modules.Sound') class. Uses the name of the [UnityEngine.AudioClip](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.AudioClip 'UnityEngine.AudioClip'). |
| [Sound(string)](Sound..ctor(string).md 'wawa.Modules.Sound.Sound(string)') | Initializes a new instance of the [Sound](Sound.md 'wawa.Modules.Sound') class. |

| Properties | |
| :--- | :--- |
| [AlarmClockBeep](Sound.AlarmClockBeep.md 'wawa.Modules.Sound.AlarmClockBeep') | Gets the sound that plays when the alarm clock goes off. This sound loops. |
| [AlarmClockSnooze](Sound.AlarmClockSnooze.md 'wawa.Modules.Sound.AlarmClockSnooze') | Gets the sound that plays when you hit snooze button on the alarm clock. |
| [BigButtonPress](Sound.BigButtonPress.md 'wawa.Modules.Sound.BigButtonPress') | Gets the sound that plays when pressing down the button on the Big Button vanilla module. |
| [BigButtonRelease](Sound.BigButtonRelease.md 'wawa.Modules.Sound.BigButtonRelease') | Gets the sound that plays when releasing the button on the Big Button vanilla module. |
| [BinderDrop](Sound.BinderDrop.md 'wawa.Modules.Sound.BinderDrop') | Gets the sound that plays as the mission binder hits the desk. |
| [BombDefused](Sound.BombDefused.md 'wawa.Modules.Sound.BombDefused') | Gets the sound that plays immediately after a bomb is defused<br/>and before [KMSoundOverride.SoundEffect.GameOverFanfare](https://docs.microsoft.com/en-us/dotnet/api/KMSoundOverride.SoundEffect.GameOverFanfare 'KMSoundOverride.SoundEffect.GameOverFanfare'). |
| [BombDrop](Sound.BombDrop.md 'wawa.Modules.Sound.BombDrop') | Gets the sound that plays when the bomb is set down on the desk. |
| [BombExplode](Sound.BombExplode.md 'wawa.Modules.Sound.BombExplode') | Gets the sound that plays when the bomb explodes. |
| [BriefcaseClose](Sound.BriefcaseClose.md 'wawa.Modules.Sound.BriefcaseClose') | Gets the sound that plays when the freeplay briefcase is closed. |
| [BriefcaseOpen](Sound.BriefcaseOpen.md 'wawa.Modules.Sound.BriefcaseOpen') | Gets the sound that plays when the freeplay briefcase is opened. |
| [ButtonPress](Sound.ButtonPress.md 'wawa.Modules.Sound.ButtonPress') | Gets the sound that plays when pressing down a button. |
| [ButtonRelease](Sound.ButtonRelease.md 'wawa.Modules.Sound.ButtonRelease') | Gets the sound that plays when releasing a button. |
| [CapacitorPop](Sound.CapacitorPop.md 'wawa.Modules.Sound.CapacitorPop') | Gets the sound that plays when Capacitor Discharge fills up completely. |
| [CorrectChime](Sound.CorrectChime.md 'wawa.Modules.Sound.CorrectChime') | Gets the sound that plays in the tutorial for completing a step correctly. |
| [DossierOptionPressed](Sound.DossierOptionPressed.md 'wawa.Modules.Sound.DossierOptionPressed') | Gets the sound that plays when you change a setting in the menu folder. |
| [EmergencyAlarm](Sound.EmergencyAlarm.md 'wawa.Modules.Sound.EmergencyAlarm') | Gets the sound that plays when there is less than a minute left on the bomb, this sound loops. |
| [FastestTimerBeep](Sound.FastestTimerBeep.md 'wawa.Modules.Sound.FastestTimerBeep') | Gets the sound that plays when the bomb has at least 2 or more strikes. |
| [FastTimerBeep](Sound.FastTimerBeep.md 'wawa.Modules.Sound.FastTimerBeep') | Gets the sound that plays when the bomb has 1 strike. |
| [FreeplayDeviceDrop](Sound.FreeplayDeviceDrop.md 'wawa.Modules.Sound.FreeplayDeviceDrop') | Gets the sound that plays as the freeplay briefcase hits the desk. |
| [GameOverFanfare](Sound.GameOverFanfare.md 'wawa.Modules.Sound.GameOverFanfare') | Gets the sound that plays when all bombs are defused. Finishes before the post game screen. |
| [LightBuzz](Sound.LightBuzz.md 'wawa.Modules.Sound.LightBuzz') | Gets the sound that plays when the lights go out. |
| [LightBuzzShort](Sound.LightBuzzShort.md 'wawa.Modules.Sound.LightBuzzShort') | Gets the sound that plays when the lights start to come back on. |
| [MenuButtonPressed](Sound.MenuButtonPressed.md 'wawa.Modules.Sound.MenuButtonPressed') | Gets the sound that plays when you start a mission from the mission binder. |
| [MenuDrop](Sound.MenuDrop.md 'wawa.Modules.Sound.MenuDrop') | Gets the sound that plays as the mission folder hits the desk. |
| [Modded](Sound.Modded.md 'wawa.Modules.Sound.Modded') | Gets the modded sound passed in as [wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1') due to ambiguity in this value being set. |
| [NeedyActivated](Sound.NeedyActivated.md 'wawa.Modules.Sound.NeedyActivated') | Gets the sound that plays when a needy gets activated. |
| [NeedyWarning](Sound.NeedyWarning.md 'wawa.Modules.Sound.NeedyWarning') | Gets the sound that plays when a needy is running out of time. This sound loops. |
| [NormalTimerBeep](Sound.NormalTimerBeep.md 'wawa.Modules.Sound.NormalTimerBeep') | Gets the sound that plays when the bomb has no strikes. |
| [PageTurn](Sound.PageTurn.md 'wawa.Modules.Sound.PageTurn') | Gets the sound that plays when a page is turned in the Missions binder. |
| [Reference](Sound.Reference.md 'wawa.Modules.Sound.Reference') | Gets the instance of the [KMAudio.KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef 'KMAudio.KMAudioRef') created from playing a sound. |
| [SelectionTick](Sound.SelectionTick.md 'wawa.Modules.Sound.SelectionTick') | Gets the sound that plays as you hover over something that can be interacted with. |
| [Stamp](Sound.Stamp.md 'wawa.Modules.Sound.Stamp') | Gets the sound that plays during the post game screen, when either the defused<br/>or exploded text is stamped onto the binder. |
| [Strike](Sound.Strike.md 'wawa.Modules.Sound.Strike') | Gets the sound that plays when you get a strike. |
| [Switch](Sound.Switch.md 'wawa.Modules.Sound.Switch') | Gets the sound that plays when a switch is toggled. |
| [TitleMenuPressed](Sound.TitleMenuPressed.md 'wawa.Modules.Sound.TitleMenuPressed') | Gets the sound that plays when pressing a button in one of the tutorials. |
| [TypewriterKey](Sound.TypewriterKey.md 'wawa.Modules.Sound.TypewriterKey') | Gets the sound that plays during the post game screen as the mission information gets typed out. |
| [Vanilla](Sound.Vanilla.md 'wawa.Modules.Sound.Vanilla') | Gets the vanilla sound passed in as [wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1') due to ambiguity in this value being set. |
| [Vanillas](Sound.Vanillas.md 'wawa.Modules.Sound.Vanillas') | Gets all vanilla sounds from the base game. |
| [WireSequenceMechanism](Sound.WireSequenceMechanism.md 'wawa.Modules.Sound.WireSequenceMechanism') | Gets the sound that plays when switching between sets of wires in Wire Sequence. |
| [WireSnip](Sound.WireSnip.md 'wawa.Modules.Sound.WireSnip') | Gets the sound that plays when a wire is cut on a module like Complicated Wires. |

| Methods | |
| :--- | :--- |
| [FromObject(Object)](Sound.FromObject(Object).md 'wawa.Modules.Sound.FromObject(Object)') | Converts the [UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Sound](Sound.md 'wawa.Modules.Sound'). |
| [FromString(string)](Sound.FromString(string).md 'wawa.Modules.Sound.FromString(string)') | Converts the [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Sound](Sound.md 'wawa.Modules.Sound'). |

| Operators | |
| :--- | :--- |
| [operator ==(Sound, Sound)](Sound.op_Equality(Sound,Sound).md 'wawa.Modules.Sound.op_Equality(wawa.Modules.Sound, wawa.Modules.Sound)') | Determines whether both instances contain the same values. |
| [explicit operator Sound(Object)](Sound.Sound(Object).md 'wawa.Modules.Sound.op_Explicit wawa.Modules.Sound(Object)') | Explicitly calls the constructor. |
| [implicit operator Sound(string)](Sound.Sound(string).md 'wawa.Modules.Sound.op_Implicit wawa.Modules.Sound(string)') | Implicitly calls the constructor. |
| [operator !=(Sound, Sound)](Sound.op_Inequality(Sound,Sound).md 'wawa.Modules.Sound.op_Inequality(wawa.Modules.Sound, wawa.Modules.Sound)') | Determines whether both instances do not contain the same values. |
