### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[EntityCore](EntityCore.md 'Wawa.Recall.EntityCore')

## EntityCore.Log(this IEnumerable<Maybe<Entity>>) Method

Hooks the logger to each instance.

```csharp
public static System.Collections.Generic.IEnumerable<Wawa.Optionals.Maybe<Wawa.Recall.Entity>> Log(this System.Collections.Generic.IEnumerable<Wawa.Optionals.Maybe<Wawa.Recall.Entity>> that);
```
#### Parameters

<a name='Wawa.Recall.EntityCore.Log(thisSystem.Collections.Generic.IEnumerable_Wawa.Optionals.Maybe_Wawa.Recall.Entity__).that'></a>

`that` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[Entity](Entity.md 'Wawa.Recall.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

This instance of [Selected](Selected.md 'Wawa.Recall.Selected').

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[Entity](Entity.md 'Wawa.Recall.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The parameter [that](EntityCore.Log(IEnumerable{Maybe{Entity}}).md#Wawa.Recall.EntityCore.Log(thisSystem.Collections.Generic.IEnumerable_Wawa.Optionals.Maybe_Wawa.Recall.Entity__).that 'Wawa.Recall.EntityCore.Log(this System.Collections.Generic.IEnumerable<Wawa.Optionals.Maybe<Wawa.Recall.Entity>>).that').

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'Wawa.Recall.Generator.Clear<T>(this Wawa.Recall.Hook<T>)').