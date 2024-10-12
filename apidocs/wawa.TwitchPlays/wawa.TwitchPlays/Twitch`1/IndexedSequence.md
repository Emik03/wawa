# IndexedSequence Method

namespace: [wawa\.TwitchPlays](../../wawa.TwitchPlays.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)



## Overloads

| Name | Summary |
|------|---------|
| IndexedSequence\(IList\<KMSelectable\>, float, params int\[\]\) | Presses a sequence of buttons according to `indices` within `selectables`,waiting `duration` seconds in\-between each, and interrupting as soon as[HasStruck](../../../wawa.Modules/wawa.Modules/State/HasStruck.md) is true\. |
| IndexedSequence\(IList\<KMSelectable\>, float, IEnumerable\<int\>\) | Presses a sequence of buttons according to `indices` within `selectables`,waiting `duration` seconds in\-between each, and interrupting as soon as[HasStruck](../../../wawa.Modules/wawa.Modules/State/HasStruck.md) is true\. |

## IndexedSequence\(IList\<KMSelectable\>, float, params int\[\]\)

Presses a sequence of buttons according to `indices` within `selectables`,
waiting `duration` seconds in\-between each, and interrupting as soon as
[HasStruck](../../../wawa.Modules/wawa.Modules/State/HasStruck.md) is true\.

```csharp
public IEnumerable<Instruction> IndexedSequence(IList<KMSelectable> selectables ,float duration ,params int[] indices);
```

### Parameters

__selectables__ : `IList<KMSelectable>`

The array of selectables to interact with\.

__duration__ : `float`

The delay between each button press in seconds\.

__indices__ : `int`

The indices to press within the list `selectables`\.

### Return Value

`IEnumerable<Instruction>`

A sequence of button presses for Twitch Plays to process\.

## IndexedSequence\(IList\<KMSelectable\>, float, IEnumerable\<int\>\)

Presses a sequence of buttons according to `indices` within `selectables`,
waiting `duration` seconds in\-between each, and interrupting as soon as
[HasStruck](../../../wawa.Modules/wawa.Modules/State/HasStruck.md) is true\.

```csharp
public IEnumerable<Instruction> IndexedSequence(IList<KMSelectable> selectables ,float duration ,IEnumerable<int> indices);
```

### Parameters

__selectables__ : `IList<KMSelectable>`

The array of selectables to interact with\.

__duration__ : `float`

The delay between each button press in seconds\.

__indices__ : `IEnumerable<int>`

The indices to press within the list `selectables`\.

### Return Value

`IEnumerable<Instruction>`

A sequence of button presses for Twitch Plays to process\.

