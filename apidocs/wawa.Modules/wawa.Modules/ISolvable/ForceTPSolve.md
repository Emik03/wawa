# ForceTPSolve\(\) Method

namespace: [wawa\.Modules](../../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../../wawa.Modules.md)

When the module runs into an exception or the module is forced to be solved, it calls this method\.

```csharp
public abstract IEnumerator ForceTPSolve();
```

## Return Value

`IEnumerator`

A series of instructions for the Twitch Plays mod to handle in order to guarantee a solve\.

