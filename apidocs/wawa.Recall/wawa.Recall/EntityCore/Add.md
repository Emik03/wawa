# Add\(Entity, Action, Action, Action, Action, Action, Action, Action, Action, Action\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Adds the parameter values to the corresponding hooks, when applicable\.

```csharp
public static Entity Add(this Entity that ,Action onActivate = null ,Action onNeedyActivate = null ,Action onNeedyDeactivate = null ,Action onNeedyTimerExpired = null ,Action onNeedyTimerGet = null ,Action onNeedyTimerSet = null ,Action onRuleGeneration = null ,Action onSolve = null ,Action onStrike = null);
```

## Parameters

__that__ : [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)

This instance of [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)\.

__onActivate__ : `Action`

Invoked when the lights turn on\.

__onNeedyActivate__ : `Action`

Invoked when the needy activates\.

__onNeedyDeactivate__ : `Action`

Invoked when the needy deactivates\.

__onNeedyTimerExpired__ : `Action`

Invoked when the needy timer expires\.

__onNeedyTimerGet__ : `Action`

Invoked to get the time remaining of the needy timer\.

__onNeedyTimerSet__ : `Action`

Invoked to set the time of the needy timer\.

__onRuleGeneration__ : `Action`

Invoked to get the random seed used to generate rules for the game\.

__onSolve__ : `Action`

Invoked when the entire module has been solved\.

__onStrike__ : `Action`

Invoked on any mistake that causes a bomb strike\.

## Return Value

[Entity](../../../wawa.Recall/wawa.Recall/Entity.md)

Itself\.

