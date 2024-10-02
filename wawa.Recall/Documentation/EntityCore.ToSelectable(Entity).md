### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[EntityCore](EntityCore.md 'wawa.Recall.EntityCore')

## EntityCore.ToSelectable(this Entity) Method

Gets the [Selected](Selected.md 'wawa.Recall.Selected') of this [Entity](Entity.md 'wawa.Recall.Entity').  
An empty value is given if there is no attached [Selected](Selected.md 'wawa.Recall.Selected') on the [Entity](Entity.md 'wawa.Recall.Entity').

```csharp
public static wawa.Optionals.Maybe<wawa.Recall.Selected> ToSelectable(this wawa.Recall.Entity entity);
```
#### Parameters

<a name='wawa.Recall.EntityCore.ToSelectable(thiswawa.Recall.Entity).entity'></a>

`entity` [Entity](Entity.md 'wawa.Recall.Entity')

This instance of [Entity](Entity.md 'wawa.Recall.Entity').

#### Returns
[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[Selected](Selected.md 'wawa.Recall.Selected')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')  
A [wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1'), consisting of either a [Selected](Selected.md 'wawa.Recall.Selected')  
that is attached to this instance, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').