#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays](wawa.TwitchPlays.md 'wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.IndexedSequence(IList<KMSelectable>, float, IEnumerable<int>) Method

Presses a sequence of buttons according to [indices](Twitch{TMod}.IndexedSequence(IList{KMSelectable},float,IEnumerable{int}).md#wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,System.Collections.Generic.IEnumerable_int_).indices 'wawa.TwitchPlays.Twitch<TMod>.IndexedSequence(System.Collections.Generic.IList<KMSelectable>, float, System.Collections.Generic.IEnumerable<int>).indices') within [selectables](Twitch{TMod}.IndexedSequence(IList{KMSelectable},float,IEnumerable{int}).md#wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,System.Collections.Generic.IEnumerable_int_).selectables 'wawa.TwitchPlays.Twitch<TMod>.IndexedSequence(System.Collections.Generic.IList<KMSelectable>, float, System.Collections.Generic.IEnumerable<int>).selectables'),  
waiting [duration](Twitch{TMod}.IndexedSequence(IList{KMSelectable},float,IEnumerable{int}).md#wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,System.Collections.Generic.IEnumerable_int_).duration 'wawa.TwitchPlays.Twitch<TMod>.IndexedSequence(System.Collections.Generic.IList<KMSelectable>, float, System.Collections.Generic.IEnumerable<int>).duration') seconds in-between each, and interrupting as soon as  
[wawa.Modules.State.HasStruck](https://docs.microsoft.com/en-us/dotnet/api/wawa.Modules.State.HasStruck 'wawa.Modules.State.HasStruck') is true.

```csharp
public virtual System.Collections.Generic.IEnumerable<wawa.TwitchPlays.Domains.Instruction> IndexedSequence(System.Collections.Generic.IList<KMSelectable> selectables, float duration, System.Collections.Generic.IEnumerable<int> indices);
```
#### Parameters

<a name='wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,System.Collections.Generic.IEnumerable_int_).selectables'></a>

`selectables` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')

The array of selectables to interact with.

<a name='wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,System.Collections.Generic.IEnumerable_int_).duration'></a>

`duration` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The delay between each button press in seconds.

<a name='wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,System.Collections.Generic.IEnumerable_int_).indices'></a>

`indices` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The indices to press within the list [selectables](Twitch{TMod}.IndexedSequence(IList{KMSelectable},float,IEnumerable{int}).md#wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,System.Collections.Generic.IEnumerable_int_).selectables 'wawa.TwitchPlays.Twitch<TMod>.IndexedSequence(System.Collections.Generic.IList<KMSelectable>, float, System.Collections.Generic.IEnumerable<int>).selectables').

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Instruction](Instruction.md 'wawa.TwitchPlays.Domains.Instruction')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence of button presses for Twitch Plays to process.