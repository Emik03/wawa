### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[HighlightedCore](HighlightedCore.md 'Wawa.Callbacks.HighlightedCore')

## HighlightedCore.ToEntity(this Highlighted) Method

Gets the [Entity](Entity.md 'Wawa.Callbacks.Entity') of this [Highlighted](Highlighted.md 'Wawa.Callbacks.Highlighted').  
An empty value is given if there is no attached [Entity](Entity.md 'Wawa.Callbacks.Entity') on the [Highlighted](Highlighted.md 'Wawa.Callbacks.Highlighted').

```csharp
public static Wawa.Optionals.Maybe<Wawa.Callbacks.Entity> ToEntity(this Wawa.Callbacks.Highlighted highlighted);
```
#### Parameters

<a name='Wawa.Callbacks.HighlightedCore.ToEntity(thisWawa.Callbacks.Highlighted).highlighted'></a>

`highlighted` [Highlighted](Highlighted.md 'Wawa.Callbacks.Highlighted')

This instance of [Highlighted](Highlighted.md 'Wawa.Callbacks.Highlighted').

#### Returns
[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[Entity](Entity.md 'Wawa.Callbacks.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')  
A [Wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1'), consisting of either a [Entity](Entity.md 'Wawa.Callbacks.Entity')  
that is attached to this instance, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').