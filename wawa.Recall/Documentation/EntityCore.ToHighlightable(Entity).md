### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[EntityCore](EntityCore.md 'wawa.Recall.EntityCore')

## EntityCore.ToHighlightable(this Entity) Method

Gets the [Highlighted](Highlighted.md 'wawa.Recall.Highlighted') of this [Entity](Entity.md 'wawa.Recall.Entity').  
An empty value is given if there is no attached [Selected](Selected.md 'wawa.Recall.Selected') on the [Entity](Entity.md 'wawa.Recall.Entity').

```csharp
public static wawa.Optionals.Maybe<wawa.Recall.Highlighted> ToHighlightable(this wawa.Recall.Entity that);
```
#### Parameters

<a name='wawa.Recall.EntityCore.ToHighlightable(thiswawa.Recall.Entity).that'></a>

`that` [Entity](Entity.md 'wawa.Recall.Entity')

This instance of [Entity](Entity.md 'wawa.Recall.Entity').

#### Returns
[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[Highlighted](Highlighted.md 'wawa.Recall.Highlighted')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')  
A [wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1'), consisting of either a [Selected](Selected.md 'wawa.Recall.Selected')  
that is attached to this instance, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').