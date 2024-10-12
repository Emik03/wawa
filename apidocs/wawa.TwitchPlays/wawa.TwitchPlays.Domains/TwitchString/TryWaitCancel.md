# TryWaitCancel\(float, string\) Method

namespace: [wawa\.TwitchPlays\.Domains](../../wawa.TwitchPlays.Domains.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)

Yield return this to cause Twitch Plays to wait for the given time,
and any time during the entire duration, the command may cancel\.

```csharp
public static TwitchString TryWaitCancel(float time ,string message = null);
```

## Parameters

__time__ : `float`

The amount of time to wait\.

__message__ : `string`

The message to send\.

## Return Value

[TwitchString](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/TwitchString.md)

A formatted string for Twitch Plays\.

