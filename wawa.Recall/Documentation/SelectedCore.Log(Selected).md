### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[SelectedCore](SelectedCore.md 'Wawa.Recall.SelectedCore')

## SelectedCore.Log(this Selected) Method

Hooks the logger to each instance.

```csharp
public static Wawa.Recall.Selected Log(this Wawa.Recall.Selected that);
```
#### Parameters

<a name='Wawa.Recall.SelectedCore.Log(thisWawa.Recall.Selected).that'></a>

`that` [Selected](Selected.md 'Wawa.Recall.Selected')

This instance of [Selected](Selected.md 'Wawa.Recall.Selected').

#### Returns
[Selected](Selected.md 'Wawa.Recall.Selected')  
The parameter [that](SelectedCore.Log(Selected).md#Wawa.Recall.SelectedCore.Log(thisWawa.Recall.Selected).that 'Wawa.Recall.SelectedCore.Log(this Wawa.Recall.Selected).that').

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'Wawa.Recall.Generator.Clear<T>(this Wawa.Recall.Hook<T>)').