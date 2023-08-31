### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[HighlightedCore](HighlightedCore.md 'Wawa.Recall.HighlightedCore')

## HighlightedCore.ToEntity(this Highlighted) Method

Gets the [Entity](Entity.md 'Wawa.Recall.Entity') of this [Highlighted](Highlighted.md 'Wawa.Recall.Highlighted').  
An empty value is given if there is no attached [Entity](Entity.md 'Wawa.Recall.Entity') on the [Highlighted](Highlighted.md 'Wawa.Recall.Highlighted').

```csharp
public static Wawa.Optionals.Maybe<Wawa.Recall.Entity> ToEntity(this Wawa.Recall.Highlighted highlighted);
```
#### Parameters

<a name='Wawa.Recall.HighlightedCore.ToEntity(thisWawa.Recall.Highlighted).highlighted'></a>

`highlighted` [Highlighted](Highlighted.md 'Wawa.Recall.Highlighted')

This instance of [Highlighted](Highlighted.md 'Wawa.Recall.Highlighted').

#### Returns
[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[Entity](Entity.md 'Wawa.Recall.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')  
A [Wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1'), consisting of either a [Entity](Entity.md 'Wawa.Recall.Entity')  
that is attached to this instance, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').