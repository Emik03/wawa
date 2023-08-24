### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[EntityCore](EntityCore.md 'Wawa.Callbacks.EntityCore')

## EntityCore.Remove(Entity, Func<float>, Action<float>, Func<int>) Method

Adds the parameter values to the corresponding hooks, when applicable.

```csharp
public static Wawa.Callbacks.Entity Remove(Wawa.Callbacks.Entity that, System.Func<float> needyTimerGet=null, System.Action<float> needyTimerSet=null, System.Func<int> ruleGeneration=null);
```
#### Parameters

<a name='Wawa.Callbacks.EntityCore.Remove(Wawa.Callbacks.Entity,System.Func_float_,System.Action_float_,System.Func_int_).that'></a>

`that` [Entity](Entity.md 'Wawa.Callbacks.Entity')

This instance of [Entity](Entity.md 'Wawa.Callbacks.Entity').

<a name='Wawa.Callbacks.EntityCore.Remove(Wawa.Callbacks.Entity,System.Func_float_,System.Action_float_,System.Func_int_).needyTimerGet'></a>

`needyTimerGet` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Invoked to get the time remaining of the needy timer.

<a name='Wawa.Callbacks.EntityCore.Remove(Wawa.Callbacks.Entity,System.Func_float_,System.Action_float_,System.Func_int_).needyTimerSet'></a>

`needyTimerSet` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Invoked to set the time of the needy timer.

<a name='Wawa.Callbacks.EntityCore.Remove(Wawa.Callbacks.Entity,System.Func_float_,System.Action_float_,System.Func_int_).ruleGeneration'></a>

`ruleGeneration` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Invoked to get the random seed used to generate rules for the game.

#### Returns
[Entity](Entity.md 'Wawa.Callbacks.Entity')  
Itself.