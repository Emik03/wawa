### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[Generator](Generator.md 'Wawa.Recall.Generator')

## Generator.Logger(this IVanilla, string) Method

Gets the logger of the [IVanilla](IVanilla.md 'Wawa.Recall.IVanilla').

```csharp
public static System.Action Logger(this Wawa.Recall.IVanilla vanilla, string label=null);
```
#### Parameters

<a name='Wawa.Recall.Generator.Logger(thisWawa.Recall.IVanilla,string).vanilla'></a>

`vanilla` [IVanilla](IVanilla.md 'Wawa.Recall.IVanilla')

The current [IVanilla](IVanilla.md 'Wawa.Recall.IVanilla').

<a name='Wawa.Recall.Generator.Logger(thisWawa.Recall.IVanilla,string).label'></a>

`label` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

An additional label to attach to the end.

#### Returns
[System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The callable function that logs the current path of the encapsulated value.