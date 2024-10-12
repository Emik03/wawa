# RequiresTimerVisibility Property

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Gets whether to only allow this module to be placed on the same face as the timer\.
Useful when the rules involve the timer in some way \(like the Big Button\),
but should be used sparingly as it limits generation possibilities\.

```csharp
public PropDef<bool> RequiresTimerVisibility { get; };
```

## Property Value

[PropDef\<bool\>](../../../wawa.Recall/wawa.Recall/PropDef\`1.md)

