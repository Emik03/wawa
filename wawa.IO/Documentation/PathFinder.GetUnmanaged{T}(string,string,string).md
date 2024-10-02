### [wawa.IO](wawa.IO.md 'wawa.IO').[PathFinder](PathFinder.md 'wawa.IO.PathFinder')

## PathFinder.GetUnmanaged<T>(string, string, string) Method

Gets an unmanaged function from an external library.

```csharp
public static wawa.Optionals.Maybe<T> GetUnmanaged<T>(string libPath, string ffiMethodName, string modId=null)
    where T : System.Delegate;
```
#### Type parameters

<a name='wawa.IO.PathFinder.GetUnmanaged_T_(string,string,string).T'></a>

`T`

The signature of the function.
#### Parameters

<a name='wawa.IO.PathFinder.GetUnmanaged_T_(string,string,string).libPath'></a>

`libPath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The external file.

<a name='wawa.IO.PathFinder.GetUnmanaged_T_(string,string,string).ffiMethodName'></a>

`ffiMethodName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the method.

<a name='wawa.IO.PathFinder.GetUnmanaged_T_(string,string,string).modId'></a>

`modId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The mod id to get the mod directory from.  
If [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), implicitly gets the directory of the mod from the file of the assembly.

#### Returns
[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[T](PathFinder.GetUnmanaged{T}(string,string,string).md#wawa.IO.PathFinder.GetUnmanaged_T_(string,string,string).T 'wawa.IO.PathFinder.GetUnmanaged<T>(string, string, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if copying the file was successful, otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').