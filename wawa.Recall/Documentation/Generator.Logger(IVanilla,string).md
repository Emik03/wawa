### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[Generator](Generator.md 'wawa.Recall.Generator')

## Generator.Logger(this IVanilla, string) Method

Gets the logger of the [IVanilla](IVanilla.md 'wawa.Recall.IVanilla').

```csharp
public static System.Action Logger(this wawa.Recall.IVanilla vanilla, string label=null);
```
#### Parameters

<a name='wawa.Recall.Generator.Logger(thiswawa.Recall.IVanilla,string).vanilla'></a>

`vanilla` [IVanilla](IVanilla.md 'wawa.Recall.IVanilla')

The current [IVanilla](IVanilla.md 'wawa.Recall.IVanilla').

<a name='wawa.Recall.Generator.Logger(thiswawa.Recall.IVanilla,string).label'></a>

`label` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

An additional label to attach to the end.

#### Returns
[System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The callable function that logs the current path of the encapsulated value.