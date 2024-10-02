### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[Selected](Selected.md 'wawa.Recall.Selected')

## Selected.FromComponent(Component) Method

Gets a new instance of [Selected](Selected.md 'wawa.Recall.Selected') based on  
the first found selectable of the [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component').

```csharp
public static wawa.Optionals.Maybe<wawa.Recall.Selected> FromComponent(Component component);
```
#### Parameters

<a name='wawa.Recall.Selected.FromComponent(Component).component'></a>

`component` [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')

The [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') to find components of using [UnityEngine.Component.GetComponent&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component.GetComponent--1 'UnityEngine.Component.GetComponent``1').

#### Returns
[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[Selected](Selected.md 'wawa.Recall.Selected')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')  
A [wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1'), consisting of either a [Selected](Selected.md 'wawa.Recall.Selected')  
that is attached to this instance, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').