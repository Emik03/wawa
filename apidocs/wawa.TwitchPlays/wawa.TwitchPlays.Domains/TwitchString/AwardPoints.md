# AwardPoints\(int\) Method

namespace: [wawa\.TwitchPlays\.Domains](../../wawa.TwitchPlays.Domains.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)

Yield return this to award the user that sent the command points directly\.

```csharp
public static TwitchString AwardPoints(int points);
```

## Parameters

__points__ : `int`

The amount of points to award\. Negatives supported\.

## Return Value

[TwitchString](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/TwitchString.md)

A formatted string for Twitch Plays\.

