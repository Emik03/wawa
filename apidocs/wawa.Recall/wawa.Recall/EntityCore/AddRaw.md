# AddRaw\(Entity, Func\<float\>, Action\<float\>, Func\<int\>, Func\<bool\>, Func\<bool\>\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Adds the parameter values to the corresponding hooks, when applicable\.

```csharp
public static Entity AddRaw(Entity that ,Func<float> needyTimerGet = null ,Action<float> needyTimerSet = null ,Func<int> ruleGeneration = null ,Func<bool> onSolve = null ,Func<bool> onStrike = null);
```

## Parameters

__that__ : [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)

This instance of [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)\.

__needyTimerGet__ : `Func<float>`

Invoked to get the time remaining of the needy timer\.

__needyTimerSet__ : `Action<float>`

Invoked to set the time of the needy timer\.

__ruleGeneration__ : `Func<int>`

Invoked to get the random seed used to generate rules for the game\.

__onSolve__ : `Func<bool>`

Invoked when the entire module has been solved\.

__onStrike__ : `Func<bool>`

Invoked on any mistake that causes a bomb strike\.

## Return Value

[Entity](../../../wawa.Recall/wawa.Recall/Entity.md)

Itself\.

