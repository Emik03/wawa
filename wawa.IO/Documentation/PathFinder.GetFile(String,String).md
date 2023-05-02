### [Wawa.IO](Wawa.IO.md 'Wawa.IO').[PathFinder](PathFinder.md 'Wawa.IO.PathFinder')

## PathFinder.GetFile(string, string) Method

Gets the absolute directory of the file located inside the mod directory.

```csharp
public static Wawa.Optionals.Maybe<string> GetFile(string filePath, string modId=null);
```
#### Parameters

<a name='Wawa.IO.PathFinder.GetFile(string,string).filePath'></a>

`filePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The file located inside folder mod directory.

<a name='Wawa.IO.PathFinder.GetFile(string,string).modId'></a>

`modId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The mod id to get the mod directory from.  
If [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), implicitly gets the directory of the mod from the file of the assembly.

#### Returns
[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')  
A [Wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1'), consisting of either folder [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') of the absolute directory  
of the file if the mod directory and file were found, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
A loaded mod has a null mod id, or has an id that conflicts with another loaded mod.