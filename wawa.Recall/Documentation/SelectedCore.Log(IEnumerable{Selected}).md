### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[SelectedCore](SelectedCore.md 'wawa.Recall.SelectedCore')

## SelectedCore.Log(this IEnumerable<Selected>) Method

Hooks the logger to each instance.

```csharp
public static System.Collections.Generic.IEnumerable<wawa.Recall.Selected> Log(this System.Collections.Generic.IEnumerable<wawa.Recall.Selected> that);
```
#### Parameters

<a name='wawa.Recall.SelectedCore.Log(thisSystem.Collections.Generic.IEnumerable_wawa.Recall.Selected_).that'></a>

`that` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Selected](Selected.md 'wawa.Recall.Selected')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

This instance of [Selected](Selected.md 'wawa.Recall.Selected').

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Selected](Selected.md 'wawa.Recall.Selected')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The parameter [that](SelectedCore.Log(IEnumerable{Selected}).md#wawa.Recall.SelectedCore.Log(thisSystem.Collections.Generic.IEnumerable_wawa.Recall.Selected_).that 'wawa.Recall.SelectedCore.Log(this System.Collections.Generic.IEnumerable<wawa.Recall.Selected>).that').

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'wawa.Recall.Generator.Clear<T>(this wawa.Recall.Hook<T>)').