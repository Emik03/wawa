### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[EntityCore](EntityCore.md 'Wawa.Recall.EntityCore')

## EntityCore.AddRaw(Entity, Func<float>, Action<float>, Func<int>, Func<bool>, Func<bool>) Method

Adds the parameter values to the corresponding hooks, when applicable.

```csharp
public static Wawa.Recall.Entity AddRaw(Wawa.Recall.Entity that, System.Func<float> needyTimerGet=null, System.Action<float> needyTimerSet=null, System.Func<int> ruleGeneration=null, System.Func<bool> onSolve=null, System.Func<bool> onStrike=null);
```
#### Parameters

<a name='Wawa.Recall.EntityCore.AddRaw(Wawa.Recall.Entity,System.Func_float_,System.Action_float_,System.Func_int_,System.Func_bool_,System.Func_bool_).that'></a>

`that` [Entity](Entity.md 'Wawa.Recall.Entity')

This instance of [Entity](Entity.md 'Wawa.Recall.Entity').

<a name='Wawa.Recall.EntityCore.AddRaw(Wawa.Recall.Entity,System.Func_float_,System.Action_float_,System.Func_int_,System.Func_bool_,System.Func_bool_).needyTimerGet'></a>

`needyTimerGet` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Invoked to get the time remaining of the needy timer.

<a name='Wawa.Recall.EntityCore.AddRaw(Wawa.Recall.Entity,System.Func_float_,System.Action_float_,System.Func_int_,System.Func_bool_,System.Func_bool_).needyTimerSet'></a>

`needyTimerSet` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Invoked to set the time of the needy timer.

<a name='Wawa.Recall.EntityCore.AddRaw(Wawa.Recall.Entity,System.Func_float_,System.Action_float_,System.Func_int_,System.Func_bool_,System.Func_bool_).ruleGeneration'></a>

`ruleGeneration` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Invoked to get the random seed used to generate rules for the game.

<a name='Wawa.Recall.EntityCore.AddRaw(Wawa.Recall.Entity,System.Func_float_,System.Action_float_,System.Func_int_,System.Func_bool_,System.Func_bool_).onSolve'></a>

`onSolve` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Invoked when the entire module has been solved.

<a name='Wawa.Recall.EntityCore.AddRaw(Wawa.Recall.Entity,System.Func_float_,System.Action_float_,System.Func_int_,System.Func_bool_,System.Func_bool_).onStrike'></a>

`onStrike` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Invoked on any mistake that causes a bomb strike.

#### Returns
[Entity](Entity.md 'Wawa.Recall.Entity')  
Itself.