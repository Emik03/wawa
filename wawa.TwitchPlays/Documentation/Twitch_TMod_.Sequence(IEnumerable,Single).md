#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays](Wawa.TwitchPlays.md 'Wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch_TMod_.md 'Wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.Sequence(IEnumerable<KMSelectable>, float) Method

Presses a sequence of buttons in order of [selectables](Twitch_TMod_.Sequence(IEnumerable,Single).md#Wawa.TwitchPlays.Twitch_TMod_.Sequence(System.Collections.Generic.IEnumerable_KMSelectable_,float).selectables 'Wawa.TwitchPlays.Twitch<TMod>.Sequence(System.Collections.Generic.IEnumerable<KMSelectable>, float).selectables'),  
waiting [duration](Twitch_TMod_.Sequence(IEnumerable,Single).md#Wawa.TwitchPlays.Twitch_TMod_.Sequence(System.Collections.Generic.IEnumerable_KMSelectable_,float).duration 'Wawa.TwitchPlays.Twitch<TMod>.Sequence(System.Collections.Generic.IEnumerable<KMSelectable>, float).duration') seconds in-between each, and interrupting as soon as  
[Wawa.Modules.State.HasStruck](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Modules.State.HasStruck 'Wawa.Modules.State.HasStruck') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public virtual System.Collections.Generic.IEnumerable<Wawa.TwitchPlays.Domains.Instruction> Sequence(System.Collections.Generic.IEnumerable<KMSelectable> selectables, float duration);
```
#### Parameters

<a name='Wawa.TwitchPlays.Twitch_TMod_.Sequence(System.Collections.Generic.IEnumerable_KMSelectable_,float).selectables'></a>

`selectables` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The array of selectables to interact with.

<a name='Wawa.TwitchPlays.Twitch_TMod_.Sequence(System.Collections.Generic.IEnumerable_KMSelectable_,float).duration'></a>

`duration` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The delay between each button press in seconds.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence of button presses for Twitch Plays to process.