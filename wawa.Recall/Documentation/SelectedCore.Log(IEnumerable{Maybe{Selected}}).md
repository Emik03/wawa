### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[SelectedCore](SelectedCore.md 'wawa.Recall.SelectedCore')

## SelectedCore.Log(this IEnumerable<Maybe<Selected>>) Method

Hooks the logger to each instance.

```csharp
public static System.Collections.Generic.IEnumerable<wawa.Optionals.Maybe<wawa.Recall.Selected>> Log(this System.Collections.Generic.IEnumerable<wawa.Optionals.Maybe<wawa.Recall.Selected>> that);
```
#### Parameters

<a name='wawa.Recall.SelectedCore.Log(thisSystem.Collections.Generic.IEnumerable_wawa.Optionals.Maybe_wawa.Recall.Selected__).that'></a>

`that` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[Selected](Selected.md 'wawa.Recall.Selected')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

This instance of [Selected](Selected.md 'wawa.Recall.Selected').

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[Selected](Selected.md 'wawa.Recall.Selected')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The parameter [that](SelectedCore.Log(IEnumerable{Maybe{Selected}}).md#wawa.Recall.SelectedCore.Log(thisSystem.Collections.Generic.IEnumerable_wawa.Optionals.Maybe_wawa.Recall.Selected__).that 'wawa.Recall.SelectedCore.Log(this System.Collections.Generic.IEnumerable<wawa.Optionals.Maybe<wawa.Recall.Selected>>).that').

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'wawa.Recall.Generator.Clear<T>(this wawa.Recall.Hook<T>)').