### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[SelectedCore](SelectedCore.md 'Wawa.Callbacks.SelectedCore')

## SelectedCore.ToEntity(this Selected) Method

Gets the [Entity](Entity.md 'Wawa.Callbacks.Entity') of this [Selected](Selected.md 'Wawa.Callbacks.Selected').  
An empty value is given if there is no attached [Entity](Entity.md 'Wawa.Callbacks.Entity') on the [Selected](Selected.md 'Wawa.Callbacks.Selected').

```csharp
public static Wawa.Optionals.Maybe<Wawa.Callbacks.Entity> ToEntity(this Wawa.Callbacks.Selected that);
```
#### Parameters

<a name='Wawa.Callbacks.SelectedCore.ToEntity(thisWawa.Callbacks.Selected).that'></a>

`that` [Selected](Selected.md 'Wawa.Callbacks.Selected')

This instance of [Selected](Selected.md 'Wawa.Callbacks.Selected').

#### Returns
[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[Entity](Entity.md 'Wawa.Callbacks.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')  
A [Wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1'), consisting of either a [Entity](Entity.md 'Wawa.Callbacks.Entity')  
that is attached to this instance, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').