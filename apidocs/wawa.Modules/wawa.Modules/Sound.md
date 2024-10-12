# Sound Class

namespace: [wawa\.Modules](../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../wawa.Modules.md)

Encapsulates a modded or vanilla sound effect, with methods to play the sound, and allowing you to extend
into the `KMAudio.KMAudioRef` instance that spawns from playing a sound effect\.

```csharp
public sealed class Sound;
```

Inheritance: `ICloneable` > Sound

Implements: `IEquatable<Sound>`, `IEqualityComparer<Sound>`

## Constructors

| Name | Summary |
|------|---------|
| [Sound\(string\)](./Sound/$ctor.md) | Initializes a new instance of the [Sound](../../wawa.Modules/wawa.Modules/Sound.md) class\. |
| [Sound\(UnityEngine\.Object\)](./Sound/$ctor.md) | Initializes a new instance of the [Sound](../../wawa.Modules/wawa.Modules/Sound.md) class\. Uses the name of the `AudioClip`\. |
| [Sound\(SoundEffect\)](./Sound/$ctor.md) | Initializes a new instance of the [Sound](../../wawa.Modules/wawa.Modules/Sound.md) class\. |

## Methods

| Name | Summary |
|------|---------|
| [Clone\(\)](./Sound/Clone.md) |  |
| [Equals\(Sound, Sound\)](./Sound/Equals.md) |  |
| [GetHashCode\(Sound\)](./Sound/GetHashCode.md) |  |
| [Equals\(Sound\)](./Sound/Equals.md) |  |
| [implicit operator Sound\(string\)](./Sound/op_Implicit.md) | Implicitly calls the constructor\. |
| [explicit operator Sound\(UnityEngine\.Object\)](./Sound/op_Explicit.md) | Explicitly calls the constructor\. |
| [implicit operator Sound\(SoundEffect\)](./Sound/op_Implicit.md) | Implicitly calls the constructor\. |
| [operator ==\(Sound, Sound\)](./Sound/op_Equality.md) | Determines whether both instances contain the same values\. |
| [operator \!=\(Sound, Sound\)](./Sound/op_Inequality.md) | Determines whether both instances do not contain the same values\. |
| [FromString\(string\)](./Sound/FromString.md) | Converts the `System.String` to a `new`[Sound](../../wawa.Modules/wawa.Modules/Sound.md)\. |
| [FromObject\(UnityEngine\.Object\)](./Sound/FromObject.md) | Converts the `UnityEngine.Object` to a `new`[Sound](../../wawa.Modules/wawa.Modules/Sound.md)\. |
| [FromSoundEffect\(SoundEffect\)](./Sound/FromSoundEffect.md) | Converts the `SoundEffect` to a `new`[Sound](../../wawa.Modules/wawa.Modules/Sound.md)\. |
| [Equals\(object\)](./Sound/Equals.md) |  |
| [GetHashCode\(\)](./Sound/GetHashCode.md) |  |
| [ToString\(\)](./Sound/ToString.md) |  |

## Properties

| Name | Summary |
|------|---------|
| [Modded](./Sound/Modded.md) | Gets the modded sound passed in as [Maybe\<T\>](../../wawa.Optionals/wawa.Optionals/Maybe\`1.md) due to ambiguity in this value being set\. |
| [Vanilla](./Sound/Vanilla.md) | Gets the vanilla sound passed in as [Maybe\<T\>](../../wawa.Optionals/wawa.Optionals/Maybe\`1.md) due to ambiguity in this value being set\. |
| [Reference](./Sound/Reference.md) | Gets the instance of the `KMAudio.KMAudioRef` created from playing a sound\. |
| [Vanillas](./Sound/Vanillas.md) | Gets all vanilla sounds from the base game\. |
| [AlarmClockBeep](./Sound/AlarmClockBeep.md) | Gets the sound that plays when the alarm clock goes off\. This sound loops\. |
| [AlarmClockSnooze](./Sound/AlarmClockSnooze.md) | Gets the sound that plays when you hit snooze button on the alarm clock\. |
| [BigButtonPress](./Sound/BigButtonPress.md) | Gets the sound that plays when pressing down the button on the Big Button vanilla module\. |
| [BigButtonRelease](./Sound/BigButtonRelease.md) | Gets the sound that plays when releasing the button on the Big Button vanilla module\. |
| [BinderDrop](./Sound/BinderDrop.md) | Gets the sound that plays as the mission binder hits the desk\. |
| [BombDefused](./Sound/BombDefused.md) | Gets the sound that plays immediately after a bomb is defusedand before `SoundEffect.GameOverFanfare`\. |
| [BombDrop](./Sound/BombDrop.md) | Gets the sound that plays when the bomb is set down on the desk\. |
| [BombExplode](./Sound/BombExplode.md) | Gets the sound that plays when the bomb explodes\. |
| [BriefcaseClose](./Sound/BriefcaseClose.md) | Gets the sound that plays when the freeplay briefcase is closed\. |
| [BriefcaseOpen](./Sound/BriefcaseOpen.md) | Gets the sound that plays when the freeplay briefcase is opened\. |
| [ButtonPress](./Sound/ButtonPress.md) | Gets the sound that plays when pressing down a button\. |
| [ButtonRelease](./Sound/ButtonRelease.md) | Gets the sound that plays when releasing a button\. |
| [CapacitorPop](./Sound/CapacitorPop.md) | Gets the sound that plays when Capacitor Discharge fills up completely\. |
| [CorrectChime](./Sound/CorrectChime.md) | Gets the sound that plays in the tutorial for completing a step correctly\. |
| [DossierOptionPressed](./Sound/DossierOptionPressed.md) | Gets the sound that plays when you change a setting in the menu folder\. |
| [EmergencyAlarm](./Sound/EmergencyAlarm.md) | Gets the sound that plays when there is less than a minute left on the bomb, this sound loops\. |
| [FastestTimerBeep](./Sound/FastestTimerBeep.md) | Gets the sound that plays when the bomb has at least 2 or more strikes\. |
| [FastTimerBeep](./Sound/FastTimerBeep.md) | Gets the sound that plays when the bomb has 1 strike\. |
| [FreeplayDeviceDrop](./Sound/FreeplayDeviceDrop.md) | Gets the sound that plays as the freeplay briefcase hits the desk\. |
| [GameOverFanfare](./Sound/GameOverFanfare.md) | Gets the sound that plays when all bombs are defused\. Finishes before the post game screen\. |
| [LightBuzz](./Sound/LightBuzz.md) | Gets the sound that plays when the lights go out\. |
| [LightBuzzShort](./Sound/LightBuzzShort.md) | Gets the sound that plays when the lights start to come back on\. |
| [MenuButtonPressed](./Sound/MenuButtonPressed.md) | Gets the sound that plays when you start a mission from the mission binder\. |
| [MenuDrop](./Sound/MenuDrop.md) | Gets the sound that plays as the mission folder hits the desk\. |
| [NeedyActivated](./Sound/NeedyActivated.md) | Gets the sound that plays when a needy gets activated\. |
| [NeedyWarning](./Sound/NeedyWarning.md) | Gets the sound that plays when a needy is running out of time\. This sound loops\. |
| [NormalTimerBeep](./Sound/NormalTimerBeep.md) | Gets the sound that plays when the bomb has no strikes\. |
| [PageTurn](./Sound/PageTurn.md) | Gets the sound that plays when a page is turned in the Missions binder\. |
| [SelectionTick](./Sound/SelectionTick.md) | Gets the sound that plays as you hover over something that can be interacted with\. |
| [Stamp](./Sound/Stamp.md) | Gets the sound that plays during the post game screen, when either the defusedor exploded text is stamped onto the binder\. |
| [Strike](./Sound/Strike.md) | Gets the sound that plays when you get a strike\. |
| [Switch](./Sound/Switch.md) | Gets the sound that plays when a switch is toggled\. |
| [TitleMenuPressed](./Sound/TitleMenuPressed.md) | Gets the sound that plays when pressing a button in one of the tutorials\. |
| [TypewriterKey](./Sound/TypewriterKey.md) | Gets the sound that plays during the post game screen as the mission information gets typed out\. |
| [WireSequenceMechanism](./Sound/WireSequenceMechanism.md) | Gets the sound that plays when switching between sets of wires in Wire Sequence\. |
| [WireSnip](./Sound/WireSnip.md) | Gets the sound that plays when a wire is cut on a module like Complicated Wires\. |

