### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[SelectedCore](SelectedCore.md 'Wawa.Callbacks.SelectedCore')

## SelectedCore.Log(this IEnumerable<Selected>) Method

Hooks the logger to each instance.

```csharp
public static System.Collections.Generic.IEnumerable<Wawa.Callbacks.Selected> Log(this System.Collections.Generic.IEnumerable<Wawa.Callbacks.Selected> that);
```
#### Parameters

<a name='Wawa.Callbacks.SelectedCore.Log(thisSystem.Collections.Generic.IEnumerable_Wawa.Callbacks.Selected_).that'></a>

`that` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Selected](Selected.md 'Wawa.Callbacks.Selected')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

This instance of [Selected](Selected.md 'Wawa.Callbacks.Selected').

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Selected](Selected.md 'Wawa.Callbacks.Selected')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The parameter [that](SelectedCore.Log(IEnumerable{Selected}).md#Wawa.Callbacks.SelectedCore.Log(thisSystem.Collections.Generic.IEnumerable_Wawa.Callbacks.Selected_).that 'Wawa.Callbacks.SelectedCore.Log(this System.Collections.Generic.IEnumerable<Wawa.Callbacks.Selected>).that').

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'Wawa.Callbacks.Generator.Clear<T>(this Wawa.Callbacks.Hook<T>)').