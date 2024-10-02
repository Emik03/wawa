### [wawa.DDL](wawa.DDL.md 'wawa.DDL').[Lookup](Lookup.md 'wawa.DDL.Lookup')

## Lookup.ModNameOf(Component) Method

Gets the mod name attached to the component.

```csharp
public static wawa.Optionals.Maybe<string> ModNameOf(Component component);
```
#### Parameters

<a name='wawa.DDL.Lookup.ModNameOf(Component).component'></a>

`component` [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')

The component to get the mod source from.

#### Returns
[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')  
The mod name attached to the parameter [component](Lookup.ModNameOf(Component).md#wawa.DDL.Lookup.ModNameOf(Component).component 'wawa.DDL.Lookup.ModNameOf(Component).component').

### Remarks
  
In the editor, this value returns [wawa.Optionals.Maybe.None&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe.None--1 'wawa.Optionals.Maybe.None``1').