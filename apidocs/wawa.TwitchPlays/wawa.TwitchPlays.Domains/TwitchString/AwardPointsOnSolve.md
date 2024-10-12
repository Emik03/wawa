# AwardPointsOnSolve\(int\) Method

namespace: [wawa\.TwitchPlays\.Domains](../../wawa.TwitchPlays.Domains.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)

Yield return this to award the last user that sent the command points when the module is solved\.

```csharp
public static TwitchString AwardPointsOnSolve(int points);
```

## Parameters

__points__ : `int`

The amount of points to award\. Negatives supported\.

## Return Value

[TwitchString](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/TwitchString.md)

A formatted string for Twitch Plays\.

