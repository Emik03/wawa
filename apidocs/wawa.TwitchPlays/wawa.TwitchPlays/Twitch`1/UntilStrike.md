# UntilStrike\(\) Method

namespace: [wawa\.TwitchPlays](../../wawa.TwitchPlays.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)

You can `yield``return` this to
allow interactions of other modules until the module has struck\.

```csharp
public IEnumerable<Instruction> UntilStrike();
```

## Return Value

`IEnumerable<Instruction>`

Repeatedly `true`, halting when [HasStruck](../../../wawa.Modules/wawa.Modules/State/HasStruck.md)
from [Module](../../../wawa.TwitchPlays/wawa.TwitchPlays/Twitch\`1/Module.md) is `true`\.

