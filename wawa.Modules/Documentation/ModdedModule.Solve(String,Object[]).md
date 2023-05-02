### [Wawa.Modules](Wawa.Modules.md 'Wawa.Modules').[ModdedModule](ModdedModule.md 'Wawa.Modules.ModdedModule')

## ModdedModule.Solve(string, object[]) Method

Solves the module.

```csharp
public virtual Wawa.Optionals.Unit Solve(string format=null, params object[] args);
```
#### Parameters

<a name='Wawa.Modules.ModdedModule.Solve(string,object[]).format'></a>

`format` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value to log.

<a name='Wawa.Modules.ModdedModule.Solve(string,object[]).args'></a>

`args` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The arguments to hook into format.

#### Returns
[Wawa.Optionals.Unit](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Unit 'Wawa.Optionals.Unit')  
The value [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').