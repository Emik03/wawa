### [wawa.IO](wawa.IO.md 'wawa.IO').[PathFinder](PathFinder.md 'wawa.IO.PathFinder')

## PathFinder.GetModInfo(string) Method

Gets and deserializes the [ModInfo](ModInfo.md 'wawa.IO.ModInfo') file located in every mod's root directory.<p/>`[MustUseReturnValue]`

```csharp
public static wawa.Optionals.Maybe<wawa.IO.ModInfo> GetModInfo(string modId=null);
```
#### Parameters

<a name='wawa.IO.PathFinder.GetModInfo(string).modId'></a>

`modId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The mod id to get the mod directory from.  
If [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), implicitly gets the directory of the mod from the name of the assembly.

#### Returns
[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[ModInfo](ModInfo.md 'wawa.IO.ModInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')  
A [wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1'), consisting of either folder [ModInfo](ModInfo.md 'wawa.IO.ModInfo') if the file was read  
and deserialized successfully, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').