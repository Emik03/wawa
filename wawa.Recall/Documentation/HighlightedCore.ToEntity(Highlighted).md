### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[HighlightedCore](HighlightedCore.md 'wawa.Recall.HighlightedCore')

## HighlightedCore.ToEntity(this Highlighted) Method

Gets the [Entity](Entity.md 'wawa.Recall.Entity') of this [Highlighted](Highlighted.md 'wawa.Recall.Highlighted').  
An empty value is given if there is no attached [Entity](Entity.md 'wawa.Recall.Entity') on the [Highlighted](Highlighted.md 'wawa.Recall.Highlighted').

```csharp
public static wawa.Optionals.Maybe<wawa.Recall.Entity> ToEntity(this wawa.Recall.Highlighted highlighted);
```
#### Parameters

<a name='wawa.Recall.HighlightedCore.ToEntity(thiswawa.Recall.Highlighted).highlighted'></a>

`highlighted` [Highlighted](Highlighted.md 'wawa.Recall.Highlighted')

This instance of [Highlighted](Highlighted.md 'wawa.Recall.Highlighted').

#### Returns
[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[Entity](Entity.md 'wawa.Recall.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')  
A [wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1'), consisting of either a [Entity](Entity.md 'wawa.Recall.Entity')  
that is attached to this instance, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').