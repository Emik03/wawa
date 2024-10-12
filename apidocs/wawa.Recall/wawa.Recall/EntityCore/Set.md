# Set\(Entity, Action, Action, Action, Action, Action, Action, Action, Action, Action\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Sets the parameter values to the corresponding hooks, when applicable\.

```csharp
public static Entity Set(this Entity that ,Action onActivate = null ,Action onNeedyActivate = null ,Action onNeedyDeactivate = null ,Action onNeedyTimerExpired = null ,Action onNeedyTimerGet = null ,Action onNeedyTimerSet = null ,Action onRuleGeneration = null ,Action onSolve = null ,Action onStrike = null);
```

## Parameters

__that__ : [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)



__onActivate__ : `Action`



__onNeedyActivate__ : `Action`



__onNeedyDeactivate__ : `Action`



__onNeedyTimerExpired__ : `Action`



__onNeedyTimerGet__ : `Action`



__onNeedyTimerSet__ : `Action`



__onRuleGeneration__ : `Action`



__onSolve__ : `Action`



__onStrike__ : `Action`



## Return Value

[Entity](../../../wawa.Recall/wawa.Recall/Entity.md)



