### [wawa.IO](wawa.IO.md 'wawa.IO').[PathFinder](PathFinder.md 'wawa.IO.PathFinder')

## PathFinder.GetDirectory(string) Method

Gets the absolute directory of the mod.<p/>`[MustUseReturnValue]`

```csharp
public static wawa.Optionals.Maybe<string> GetDirectory(string modId=null);
```
#### Parameters

<a name='wawa.IO.PathFinder.GetDirectory(string).modId'></a>

`modId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The mod id to get the mod directory from.  
If [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), implicitly gets the directory of the mod from the name of the assembly.

#### Returns
[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')  
A [wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1'), consisting of either folder [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') of the absolute directory  
of the file if there is a folder mod id entry within the game's mod dictionary, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').