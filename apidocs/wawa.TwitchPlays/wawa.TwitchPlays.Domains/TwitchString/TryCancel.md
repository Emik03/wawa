# TryCancel\(string\) Method

namespace: [wawa\.TwitchPlays\.Domains](../../wawa.TwitchPlays.Domains.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)

Yield return this to indicate that this command is allowed to be cancelled at the given time of the yield\.

```csharp
public static TwitchString TryCancel(string message = null);
```

## Parameters

__message__ : `string`

The message to send\.

## Return Value

[TwitchString](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/TwitchString.md)

A formatted string for Twitch Plays\.

