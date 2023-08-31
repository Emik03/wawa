### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[Entity](Entity.md 'Wawa.Callbacks.Entity')

## Entity.FromComponent(Component) Method

Gets the [Entity](Entity.md 'Wawa.Callbacks.Entity') of this [Selected](Selected.md 'Wawa.Callbacks.Selected').  
An empty value is given if there is no attached [Entity](Entity.md 'Wawa.Callbacks.Entity') on the [Selected](Selected.md 'Wawa.Callbacks.Selected').

```csharp
public static Wawa.Optionals.Maybe<Wawa.Callbacks.Entity> FromComponent(Component component);
```
#### Parameters

<a name='Wawa.Callbacks.Entity.FromComponent(Component).component'></a>

`component` [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')

The [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') to find components of using [UnityEngine.Component.GetComponent&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component.GetComponent--1 'UnityEngine.Component.GetComponent``1').

#### Returns
[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[Entity](Entity.md 'Wawa.Callbacks.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')  
A [Wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1'), consisting of either a [Entity](Entity.md 'Wawa.Callbacks.Entity')  
that is attached to this instance, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').