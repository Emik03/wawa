# RemoveRaw\(Entity, Func\<float\>, Action\<float\>, Func\<int\>, Func\<bool\>, Func\<bool\>\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Removes the parameter values to the corresponding hooks, when applicable\.

```csharp
public static Entity RemoveRaw(Entity that ,Func<float> needyTimerGet = null ,Action<float> needyTimerSet = null ,Func<int> ruleGeneration = null ,Func<bool> onSolve = null ,Func<bool> onStrike = null);
```

## Parameters

__that__ : [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)



__needyTimerGet__ : `Func<float>`



__needyTimerSet__ : `Action<float>`



__ruleGeneration__ : `Func<int>`



__onSolve__ : `Func<bool>`



__onStrike__ : `Func<bool>`



## Return Value

[Entity](../../../wawa.Recall/wawa.Recall/Entity.md)



