# UntilSolve\(\) Method

namespace: [wawa\.TwitchPlays](../../wawa.TwitchPlays.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)

You can `yield``return` this to
allow interactions of other modules until the module is solved\.

```csharp
public IEnumerable<Instruction> UntilSolve();
```

## Return Value

`IEnumerable<Instruction>`

Repeatedly `true`, halting when [IsSolved](../../../wawa.Modules/wawa.Modules/State/IsSolved.md)
from [Module](../../../wawa.TwitchPlays/wawa.TwitchPlays/Twitch\`1/Module.md) is `true`\.

