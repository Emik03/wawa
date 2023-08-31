### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[SelectedCore](SelectedCore.md 'Wawa.Recall.SelectedCore')

## SelectedCore.Log(this IEnumerable<Selected>) Method

Hooks the logger to each instance.

```csharp
public static System.Collections.Generic.IEnumerable<Wawa.Recall.Selected> Log(this System.Collections.Generic.IEnumerable<Wawa.Recall.Selected> that);
```
#### Parameters

<a name='Wawa.Recall.SelectedCore.Log(thisSystem.Collections.Generic.IEnumerable_Wawa.Recall.Selected_).that'></a>

`that` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Selected](Selected.md 'Wawa.Recall.Selected')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

This instance of [Selected](Selected.md 'Wawa.Recall.Selected').

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Selected](Selected.md 'Wawa.Recall.Selected')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The parameter [that](SelectedCore.Log(IEnumerable{Selected}).md#Wawa.Recall.SelectedCore.Log(thisSystem.Collections.Generic.IEnumerable_Wawa.Recall.Selected_).that 'Wawa.Recall.SelectedCore.Log(this System.Collections.Generic.IEnumerable<Wawa.Recall.Selected>).that').

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'Wawa.Recall.Generator.Clear<T>(this Wawa.Recall.Hook<T>)').