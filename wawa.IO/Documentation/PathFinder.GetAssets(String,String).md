### [Wawa.IO](Wawa.IO.md 'Wawa.IO').[PathFinder](PathFinder.md 'Wawa.IO.PathFinder')

## PathFinder.GetAssets<T>(string, string) Method

Loads and returns assets from disk.

```csharp
public static Wawa.Optionals.Maybe<System.Collections.Generic.IList<T>> GetAssets<T>(string filePath, string modId=null)
    where T : Object;
```
#### Type parameters

<a name='Wawa.IO.PathFinder.GetAssets_T_(string,string).T'></a>

`T`

The type of asset to get.
#### Parameters

<a name='Wawa.IO.PathFinder.GetAssets_T_(string,string).filePath'></a>

`filePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The file which contains the assets.

<a name='Wawa.IO.PathFinder.GetAssets_T_(string,string).modId'></a>

`modId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The mod id to get the mod directory from.  
If [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), implicitly gets the directory of the mod from the file of the assembly.

#### Returns
[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](PathFinder.GetAssets(String,String).md#Wawa.IO.PathFinder.GetAssets_T_(string,string).T 'Wawa.IO.PathFinder.GetAssets<T>(string, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')  
A [Wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1'), consisting of either an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of   
from the assets in the file specified, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default') in the event of an error.