### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[Entity](Entity.md 'wawa.Recall.Entity')

## Entity.FromComponent(Component) Method

Gets the [Entity](Entity.md 'wawa.Recall.Entity') of this [Selected](Selected.md 'wawa.Recall.Selected').  
An empty value is given if there is no attached [Entity](Entity.md 'wawa.Recall.Entity') on the [Selected](Selected.md 'wawa.Recall.Selected').

```csharp
public static wawa.Optionals.Maybe<wawa.Recall.Entity> FromComponent(Component component);
```
#### Parameters

<a name='wawa.Recall.Entity.FromComponent(Component).component'></a>

`component` [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')

The [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') to find components of using [UnityEngine.Component.GetComponent&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component.GetComponent--1 'UnityEngine.Component.GetComponent``1').

#### Returns
[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[Entity](Entity.md 'wawa.Recall.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')  
A [wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1'), consisting of either a [Entity](Entity.md 'wawa.Recall.Entity')  
that is attached to this instance, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').