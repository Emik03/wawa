### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[EntityCore](EntityCore.md 'Wawa.Callbacks.EntityCore')

## EntityCore.Log(this IEnumerable<Maybe<Entity>>) Method

Hooks the logger to each instance.

```csharp
public static System.Collections.Generic.IEnumerable<Wawa.Optionals.Maybe<Wawa.Callbacks.Entity>> Log(this System.Collections.Generic.IEnumerable<Wawa.Optionals.Maybe<Wawa.Callbacks.Entity>> that);
```
#### Parameters

<a name='Wawa.Callbacks.EntityCore.Log(thisSystem.Collections.Generic.IEnumerable_Wawa.Optionals.Maybe_Wawa.Callbacks.Entity__).that'></a>

`that` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[Entity](Entity.md 'Wawa.Callbacks.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

This instance of [Selected](Selected.md 'Wawa.Callbacks.Selected').

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[Entity](Entity.md 'Wawa.Callbacks.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The parameter [that](EntityCore.Log(IEnumerable{Maybe{Entity}}).md#Wawa.Callbacks.EntityCore.Log(thisSystem.Collections.Generic.IEnumerable_Wawa.Optionals.Maybe_Wawa.Callbacks.Entity__).that 'Wawa.Callbacks.EntityCore.Log(this System.Collections.Generic.IEnumerable<Wawa.Optionals.Maybe<Wawa.Callbacks.Entity>>).that').

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'Wawa.Callbacks.Generator.Clear<T>(this Wawa.Callbacks.Hook<T>)').