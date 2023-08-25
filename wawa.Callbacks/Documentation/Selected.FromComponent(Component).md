### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[Selected](Selected.md 'Wawa.Callbacks.Selected')

## Selected.FromComponent(Component) Method

Gets a new instance of [Selected](Selected.md 'Wawa.Callbacks.Selected') based on  
the first found selectable of the [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component').

```csharp
public static Wawa.Optionals.Maybe<Wawa.Callbacks.Selected> FromComponent(Component component);
```
#### Parameters

<a name='Wawa.Callbacks.Selected.FromComponent(Component).component'></a>

`component` [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')

The [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') to find components of using [UnityEngine.Component.GetComponent&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component.GetComponent--1 'UnityEngine.Component.GetComponent``1').

#### Returns
[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[Selected](Selected.md 'Wawa.Callbacks.Selected')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')  
A [Wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1'), consisting of either a [Selected](Selected.md 'Wawa.Callbacks.Selected')  
that is attached to this instance, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').