# Sequence\(IEnumerable\<KMSelectable\>, float\) Method

namespace: [wawa\.TwitchPlays](../../wawa.TwitchPlays.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)

Presses a sequence of buttons in order of `selectables`,
waiting `duration` seconds in\-between each, and interrupting as soon as
[HasStruck](../../../wawa.Modules/wawa.Modules/State/HasStruck.md) is `true`\.

```csharp
public IEnumerable<Instruction> Sequence(IEnumerable<KMSelectable> selectables ,float duration);
```

## Parameters

__selectables__ : `IEnumerable<KMSelectable>`

The array of selectables to interact with\.

__duration__ : `float`

The delay between each button press in seconds\.

## Return Value

`IEnumerable<Instruction>`

A sequence of button presses for Twitch Plays to process\.

