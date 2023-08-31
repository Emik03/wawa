### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[Generator](Generator.md 'Wawa.Callbacks.Generator')

## Generator.Logger(this IVanilla, string) Method

Gets the logger of the [IVanilla](IVanilla.md 'Wawa.Callbacks.IVanilla').

```csharp
public static System.Action Logger(this Wawa.Callbacks.IVanilla vanilla, string label=null);
```
#### Parameters

<a name='Wawa.Callbacks.Generator.Logger(thisWawa.Callbacks.IVanilla,string).vanilla'></a>

`vanilla` [IVanilla](IVanilla.md 'Wawa.Callbacks.IVanilla')

The current [IVanilla](IVanilla.md 'Wawa.Callbacks.IVanilla').

<a name='Wawa.Callbacks.Generator.Logger(thisWawa.Callbacks.IVanilla,string).label'></a>

`label` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

An additional label to attach to the end.

#### Returns
[System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The callable function that logs the current path of the encapsulated value.