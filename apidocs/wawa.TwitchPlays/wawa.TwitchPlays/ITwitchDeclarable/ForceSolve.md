# ForceSolve\(\) Method

namespace: [wawa\.TwitchPlays](../../wawa.TwitchPlays.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)

When the module runs into an exception or the module is forced to be solved, this method is used\.

```csharp
public abstract IEnumerable<Instruction> ForceSolve();
```

## Return Value

`IEnumerable<Instruction>`

A series of instructions for the Twitch Plays mod to handle in order to guarantee solving\.

