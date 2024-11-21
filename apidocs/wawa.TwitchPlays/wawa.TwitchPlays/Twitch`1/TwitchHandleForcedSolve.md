# TwitchHandleForcedSolve\(\) Method

namespace: [wawa\.TwitchPlays](../../wawa.TwitchPlays.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)

This method gets grabbed by Twitch Plays which is used whenever a thrown `Exception`
is unhandled, a votesolve/solvebomb is performed, or when an admin forces this module to be solved\.

```csharp
public IEnumerator TwitchHandleForcedSolve();
```

## Return Value

`IEnumerator`

A series of instructions for the Twitch Plays mod to handle in order to guarantee the module being solved\.

