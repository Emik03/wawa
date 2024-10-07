### [wawa.Modules](wawa.Modules.md 'wawa.Modules').[ModdedModule](ModdedModule.md 'wawa.Modules.ModdedModule')

## ModdedModule.Strike(string, object[]) Method

Strikes the module.

```csharp
public wawa.Optionals.Unit Strike(string format=null, params object[] args);
```
#### Parameters

<a name='wawa.Modules.ModdedModule.Strike(string,object[]).format'></a>

`format` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value to log.

<a name='wawa.Modules.ModdedModule.Strike(string,object[]).args'></a>

`args` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The arguments to hook into format.<p/>`[ItemCanBeNull]`

#### Returns
[wawa.Optionals.Unit](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Unit 'wawa.Optionals.Unit')  
The value [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').