### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[EntityCore](EntityCore.md 'Wawa.Callbacks.EntityCore')

## EntityCore.ToHighlightable(this Entity) Method

Gets the [Highlighted](Highlighted.md 'Wawa.Callbacks.Highlighted') of this [Entity](Entity.md 'Wawa.Callbacks.Entity').  
An empty value is given if there is no attached [Selected](Selected.md 'Wawa.Callbacks.Selected') on the [Entity](Entity.md 'Wawa.Callbacks.Entity').

```csharp
public static Wawa.Optionals.Maybe<Wawa.Callbacks.Highlighted> ToHighlightable(this Wawa.Callbacks.Entity that);
```
#### Parameters

<a name='Wawa.Callbacks.EntityCore.ToHighlightable(thisWawa.Callbacks.Entity).that'></a>

`that` [Entity](Entity.md 'Wawa.Callbacks.Entity')

This instance of [Entity](Entity.md 'Wawa.Callbacks.Entity').

#### Returns
[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[Highlighted](Highlighted.md 'Wawa.Callbacks.Highlighted')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')  
A [Wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1'), consisting of either a [Selected](Selected.md 'Wawa.Callbacks.Selected')  
that is attached to this instance, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').