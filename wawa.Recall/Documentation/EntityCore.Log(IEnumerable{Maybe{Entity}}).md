### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[EntityCore](EntityCore.md 'wawa.Recall.EntityCore')

## EntityCore.Log(this IEnumerable<Maybe<Entity>>) Method

Hooks the logger to each instance.

```csharp
public static System.Collections.Generic.IEnumerable<wawa.Optionals.Maybe<wawa.Recall.Entity>> Log(this System.Collections.Generic.IEnumerable<wawa.Optionals.Maybe<wawa.Recall.Entity>> that);
```
#### Parameters

<a name='wawa.Recall.EntityCore.Log(thisSystem.Collections.Generic.IEnumerable_wawa.Optionals.Maybe_wawa.Recall.Entity__).that'></a>

`that` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[Entity](Entity.md 'wawa.Recall.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

This instance of [Selected](Selected.md 'wawa.Recall.Selected').

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[Entity](Entity.md 'wawa.Recall.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The parameter [that](EntityCore.Log(IEnumerable{Maybe{Entity}}).md#wawa.Recall.EntityCore.Log(thisSystem.Collections.Generic.IEnumerable_wawa.Optionals.Maybe_wawa.Recall.Entity__).that 'wawa.Recall.EntityCore.Log(this System.Collections.Generic.IEnumerable<wawa.Optionals.Maybe<wawa.Recall.Entity>>).that').

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'wawa.Recall.Generator.Clear<T>(this wawa.Recall.Hook<T>)').