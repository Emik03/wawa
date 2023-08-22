### [Wawa.DDL](Wawa.DDL.md 'Wawa.DDL').[Lookup](Lookup.md 'Wawa.DDL.Lookup')

## Lookup.ModNameOf(Component) Method

Gets the mod name attached to the component.

```csharp
public static Wawa.Optionals.Maybe<string> ModNameOf(Component component);
```
#### Parameters

<a name='Wawa.DDL.Lookup.ModNameOf(Component).component'></a>

`component` [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')

The component to get the mod source from.

#### Returns
[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')  
The mod name attached to the parameter [component](Lookup.ModNameOf(Component).md#Wawa.DDL.Lookup.ModNameOf(Component).component 'Wawa.DDL.Lookup.ModNameOf(Component).component').

### Remarks
  
In the editor, this value returns [Wawa.Optionals.Maybe.None&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe.None--1 'Wawa.Optionals.Maybe.None``1').