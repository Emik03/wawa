#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays](Wawa.TwitchPlays.md 'Wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch{TMod}.md 'Wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.IndexedSequence(IList<KMSelectable>, float, int[]) Method

Presses a sequence of buttons according to [indices](Twitch{TMod}.IndexedSequence(IList{KMSelectable},float,int[]).md#Wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,int[]).indices 'Wawa.TwitchPlays.Twitch<TMod>.IndexedSequence(System.Collections.Generic.IList<KMSelectable>, float, int[]).indices') within [selectables](Twitch{TMod}.IndexedSequence(IList{KMSelectable},float,int[]).md#Wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,int[]).selectables 'Wawa.TwitchPlays.Twitch<TMod>.IndexedSequence(System.Collections.Generic.IList<KMSelectable>, float, int[]).selectables'),  
waiting [duration](Twitch{TMod}.IndexedSequence(IList{KMSelectable},float,int[]).md#Wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,int[]).duration 'Wawa.TwitchPlays.Twitch<TMod>.IndexedSequence(System.Collections.Generic.IList<KMSelectable>, float, int[]).duration') seconds in-between each, and interrupting as soon as  
[Wawa.Modules.State.HasStruck](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Modules.State.HasStruck 'Wawa.Modules.State.HasStruck') is true.

```csharp
public virtual System.Collections.Generic.IEnumerable<Wawa.TwitchPlays.Domains.Instruction> IndexedSequence(System.Collections.Generic.IList<KMSelectable> selectables, float duration, params int[] indices);
```
#### Parameters

<a name='Wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,int[]).selectables'></a>

`selectables` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')

The array of selectables to interact with.

<a name='Wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,int[]).duration'></a>

`duration` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The delay between each button press in seconds.

<a name='Wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,int[]).indices'></a>

`indices` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The indices to press within the list [selectables](Twitch{TMod}.IndexedSequence(IList{KMSelectable},float,int[]).md#Wawa.TwitchPlays.Twitch_TMod_.IndexedSequence(System.Collections.Generic.IList_KMSelectable_,float,int[]).selectables 'Wawa.TwitchPlays.Twitch<TMod>.IndexedSequence(System.Collections.Generic.IList<KMSelectable>, float, int[]).selectables').

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A sequence of button presses for Twitch Plays to process.