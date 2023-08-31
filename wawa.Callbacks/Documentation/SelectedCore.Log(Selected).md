### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[SelectedCore](SelectedCore.md 'Wawa.Callbacks.SelectedCore')

## SelectedCore.Log(this Selected) Method

Hooks the logger to each instance.

```csharp
public static Wawa.Callbacks.Selected Log(this Wawa.Callbacks.Selected that);
```
#### Parameters

<a name='Wawa.Callbacks.SelectedCore.Log(thisWawa.Callbacks.Selected).that'></a>

`that` [Selected](Selected.md 'Wawa.Callbacks.Selected')

This instance of [Selected](Selected.md 'Wawa.Callbacks.Selected').

#### Returns
[Selected](Selected.md 'Wawa.Callbacks.Selected')  
The parameter [that](SelectedCore.Log(Selected).md#Wawa.Callbacks.SelectedCore.Log(thisWawa.Callbacks.Selected).that 'Wawa.Callbacks.SelectedCore.Log(this Wawa.Callbacks.Selected).that').

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'Wawa.Callbacks.Generator.Clear<T>(this Wawa.Callbacks.Hook<T>)').