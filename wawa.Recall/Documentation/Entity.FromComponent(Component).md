### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[Entity](Entity.md 'Wawa.Recall.Entity')

## Entity.FromComponent(Component) Method

Gets the [Entity](Entity.md 'Wawa.Recall.Entity') of this [Selected](Selected.md 'Wawa.Recall.Selected').  
An empty value is given if there is no attached [Entity](Entity.md 'Wawa.Recall.Entity') on the [Selected](Selected.md 'Wawa.Recall.Selected').

```csharp
public static Wawa.Optionals.Maybe<Wawa.Recall.Entity> FromComponent(Component component);
```
#### Parameters

<a name='Wawa.Recall.Entity.FromComponent(Component).component'></a>

`component` [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')

The [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') to find components of using [UnityEngine.Component.GetComponent&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component.GetComponent--1 'UnityEngine.Component.GetComponent``1').

#### Returns
[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[Entity](Entity.md 'Wawa.Recall.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')  
A [Wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1'), consisting of either a [Entity](Entity.md 'Wawa.Recall.Entity')  
that is attached to this instance, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').