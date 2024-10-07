#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays](wawa.TwitchPlays.md 'wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.IndexedSequence(IList<KMSelectable>, float, int[]) Method

Presses a sequence of buttons according to [indices](Twitch{TMod}.IndexedSequence(IList{KMSelectable},float,int[]).md#wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,int[]).indices 'wawa.TwitchPlays.Twitch<TMod>.IndexedSequence(System.Collections.Generic.IList<KMSelectable>, float, int[]).indices') within [selectables](Twitch{TMod}.IndexedSequence(IList{KMSelectable},float,int[]).md#wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,int[]).selectables 'wawa.TwitchPlays.Twitch<TMod>.IndexedSequence(System.Collections.Generic.IList<KMSelectable>, float, int[]).selectables'),  
waiting [duration](Twitch{TMod}.IndexedSequence(IList{KMSelectable},float,int[]).md#wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,int[]).duration 'wawa.TwitchPlays.Twitch<TMod>.IndexedSequence(System.Collections.Generic.IList<KMSelectable>, float, int[]).duration') seconds in-between each, and interrupting as soon as  
[wawa.Modules.State.HasStruck](https://docs.microsoft.com/en-us/dotnet/api/wawa.Modules.State.HasStruck 'wawa.Modules.State.HasStruck') is true.  
<p/>`[ItemNotNull]`

```csharp
public System.Collections.Generic.IEnumerable<wawa.TwitchPlays.Domains.Instruction> IndexedSequence(System.Collections.Generic.IList<KMSelectable> selectables, float duration, params int[] indices);
```
#### Parameters

<a name='wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,int[]).selectables'></a>

`selectables` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')

The array of selectables to interact with.<p/>`[ItemCanBeNull]`

<a name='wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,int[]).duration'></a>

`duration` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The delay between each button press in seconds.

<a name='wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,int[]).indices'></a>

`indices` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The indices to press within the list [selectables](Twitch{TMod}.IndexedSequence(IList{KMSelectable},float,int[]).md#wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,int[]).selectables 'wawa.TwitchPlays.Twitch<TMod>.IndexedSequence(System.Collections.Generic.IList<KMSelectable>, float, int[]).selectables').

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Instruction](Instruction.md 'wawa.TwitchPlays.Domains.Instruction')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence of button presses for Twitch Plays to process.