#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays](wawa.TwitchPlays.md 'wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.Sequence(IEnumerable<KMSelectable>, float) Method

Presses a sequence of buttons in order of [selectables](Twitch{TMod}.Sequence(IEnumerable{KMSelectable},float).md#wawa.TwitchPlays.Twitch_TMod_.Sequence(System.Collections.Generic.IEnumerable_KMSelectable_,float).selectables 'wawa.TwitchPlays.Twitch<TMod>.Sequence(System.Collections.Generic.IEnumerable<KMSelectable>, float).selectables'),  
waiting [duration](Twitch{TMod}.Sequence(IEnumerable{KMSelectable},float).md#wawa.TwitchPlays.Twitch_TMod_.Sequence(System.Collections.Generic.IEnumerable_KMSelectable_,float).duration 'wawa.TwitchPlays.Twitch<TMod>.Sequence(System.Collections.Generic.IEnumerable<KMSelectable>, float).duration') seconds in-between each, and interrupting as soon as  
[wawa.Modules.State.HasStruck](https://docs.microsoft.com/en-us/dotnet/api/wawa.Modules.State.HasStruck 'wawa.Modules.State.HasStruck') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public virtual System.Collections.Generic.IEnumerable<wawa.TwitchPlays.Domains.Instruction> Sequence(System.Collections.Generic.IEnumerable<KMSelectable> selectables, float duration);
```
#### Parameters

<a name='wawa.TwitchPlays.Twitch_TMod_.Sequence(System.Collections.Generic.IEnumerable_KMSelectable_,float).selectables'></a>

`selectables` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The array of selectables to interact with.

<a name='wawa.TwitchPlays.Twitch_TMod_.Sequence(System.Collections.Generic.IEnumerable_KMSelectable_,float).duration'></a>

`duration` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The delay between each button press in seconds.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Instruction](Instruction.md 'wawa.TwitchPlays.Domains.Instruction')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence of button presses for Twitch Plays to process.