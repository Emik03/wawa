### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[SelectedCore](SelectedCore.md 'wawa.Recall.SelectedCore')

## SelectedCore.Log(this Selected) Method

Hooks the logger to each instance.

```csharp
public static wawa.Recall.Selected Log(this wawa.Recall.Selected that);
```
#### Parameters

<a name='wawa.Recall.SelectedCore.Log(thiswawa.Recall.Selected).that'></a>

`that` [Selected](Selected.md 'wawa.Recall.Selected')

This instance of [Selected](Selected.md 'wawa.Recall.Selected').

#### Returns
[Selected](Selected.md 'wawa.Recall.Selected')  
The parameter [that](SelectedCore.Log(Selected).md#wawa.Recall.SelectedCore.Log(thiswawa.Recall.Selected).that 'wawa.Recall.SelectedCore.Log(this wawa.Recall.Selected).that').

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'wawa.Recall.Generator.Clear<T>(this wawa.Recall.Hook<T>)').