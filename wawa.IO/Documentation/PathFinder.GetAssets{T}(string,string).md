### [wawa.IO](wawa.IO.md 'wawa.IO').[PathFinder](PathFinder.md 'wawa.IO.PathFinder')

## PathFinder.GetAssets<T>(string, string) Method

Loads and returns assets from disk.

```csharp
public static wawa.Optionals.Maybe<System.Collections.Generic.IList<T>> GetAssets<T>(string filePath, string modId=null)
    where T : Object;
```
#### Type parameters

<a name='wawa.IO.PathFinder.GetAssets_T_(string,string).T'></a>

`T`

The type of asset to get.
#### Parameters

<a name='wawa.IO.PathFinder.GetAssets_T_(string,string).filePath'></a>

`filePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The file which contains the assets.

<a name='wawa.IO.PathFinder.GetAssets_T_(string,string).modId'></a>

`modId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The mod id to get the mod directory from.  
If [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), implicitly gets the directory of the mod from the name of the assembly.

#### Returns
[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](PathFinder.GetAssets{T}(string,string).md#wawa.IO.PathFinder.GetAssets_T_(string,string).T 'wawa.IO.PathFinder.GetAssets<T>(string, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')  
A [wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1'), consisting of either an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of   
from the assets in the file specified, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default') in the event of an error.