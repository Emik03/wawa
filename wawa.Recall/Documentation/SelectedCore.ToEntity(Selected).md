### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[SelectedCore](SelectedCore.md 'wawa.Recall.SelectedCore')

## SelectedCore.ToEntity(this Selected) Method

Gets the [Entity](Entity.md 'wawa.Recall.Entity') of this [Selected](Selected.md 'wawa.Recall.Selected').  
An empty value is given if there is no attached [Entity](Entity.md 'wawa.Recall.Entity') on the [Selected](Selected.md 'wawa.Recall.Selected').

```csharp
public static wawa.Optionals.Maybe<wawa.Recall.Entity> ToEntity(this wawa.Recall.Selected that);
```
#### Parameters

<a name='wawa.Recall.SelectedCore.ToEntity(thiswawa.Recall.Selected).that'></a>

`that` [Selected](Selected.md 'wawa.Recall.Selected')

This instance of [Selected](Selected.md 'wawa.Recall.Selected').

#### Returns
[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[Entity](Entity.md 'wawa.Recall.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')  
A [wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1'), consisting of either a [Entity](Entity.md 'wawa.Recall.Entity')  
that is attached to this instance, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').