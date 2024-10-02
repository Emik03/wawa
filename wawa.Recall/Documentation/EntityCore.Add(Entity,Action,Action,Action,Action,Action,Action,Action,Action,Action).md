### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[EntityCore](EntityCore.md 'wawa.Recall.EntityCore')

## EntityCore.Add(this Entity, Action, Action, Action, Action, Action, Action, Action, Action, Action) Method

Adds the parameter values to the corresponding hooks, when applicable.

```csharp
public static wawa.Recall.Entity Add(this wawa.Recall.Entity that, System.Action onActivate=null, System.Action onNeedyActivate=null, System.Action onNeedyDeactivate=null, System.Action onNeedyTimerExpired=null, System.Action onNeedyTimerGet=null, System.Action onNeedyTimerSet=null, System.Action onRuleGeneration=null, System.Action onSolve=null, System.Action onStrike=null);
```
#### Parameters

<a name='wawa.Recall.EntityCore.Add(thiswawa.Recall.Entity,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).that'></a>

`that` [Entity](Entity.md 'wawa.Recall.Entity')

This instance of [Entity](Entity.md 'wawa.Recall.Entity').

<a name='wawa.Recall.EntityCore.Add(thiswawa.Recall.Entity,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onActivate'></a>

`onActivate` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked when the lights turn on.

<a name='wawa.Recall.EntityCore.Add(thiswawa.Recall.Entity,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onNeedyActivate'></a>

`onNeedyActivate` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked when the needy activates.

<a name='wawa.Recall.EntityCore.Add(thiswawa.Recall.Entity,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onNeedyDeactivate'></a>

`onNeedyDeactivate` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked when the needy deactivates.

<a name='wawa.Recall.EntityCore.Add(thiswawa.Recall.Entity,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onNeedyTimerExpired'></a>

`onNeedyTimerExpired` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked when the needy timer expires.

<a name='wawa.Recall.EntityCore.Add(thiswawa.Recall.Entity,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onNeedyTimerGet'></a>

`onNeedyTimerGet` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked to get the time remaining of the needy timer.

<a name='wawa.Recall.EntityCore.Add(thiswawa.Recall.Entity,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onNeedyTimerSet'></a>

`onNeedyTimerSet` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked to set the time of the needy timer.

<a name='wawa.Recall.EntityCore.Add(thiswawa.Recall.Entity,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onRuleGeneration'></a>

`onRuleGeneration` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked to get the random seed used to generate rules for the game.

<a name='wawa.Recall.EntityCore.Add(thiswawa.Recall.Entity,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onSolve'></a>

`onSolve` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked when the entire module has been solved.

<a name='wawa.Recall.EntityCore.Add(thiswawa.Recall.Entity,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onStrike'></a>

`onStrike` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked on any mistake that causes a bomb strike.

#### Returns
[Entity](Entity.md 'wawa.Recall.Entity')  
Itself.