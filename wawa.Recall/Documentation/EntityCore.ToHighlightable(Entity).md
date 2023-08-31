### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[EntityCore](EntityCore.md 'Wawa.Recall.EntityCore')

## EntityCore.ToHighlightable(this Entity) Method

Gets the [Highlighted](Highlighted.md 'Wawa.Recall.Highlighted') of this [Entity](Entity.md 'Wawa.Recall.Entity').  
An empty value is given if there is no attached [Selected](Selected.md 'Wawa.Recall.Selected') on the [Entity](Entity.md 'Wawa.Recall.Entity').

```csharp
public static Wawa.Optionals.Maybe<Wawa.Recall.Highlighted> ToHighlightable(this Wawa.Recall.Entity that);
```
#### Parameters

<a name='Wawa.Recall.EntityCore.ToHighlightable(thisWawa.Recall.Entity).that'></a>

`that` [Entity](Entity.md 'Wawa.Recall.Entity')

This instance of [Entity](Entity.md 'Wawa.Recall.Entity').

#### Returns
[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[Highlighted](Highlighted.md 'Wawa.Recall.Highlighted')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')  
A [Wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1'), consisting of either a [Selected](Selected.md 'Wawa.Recall.Selected')  
that is attached to this instance, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').