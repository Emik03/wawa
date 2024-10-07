### [wawa.IO](wawa.IO.md 'wawa.IO').[ModInfo](ModInfo.md 'wawa.IO.ModInfo')

## ModInfo.ReadThenDeserialize(string) Method

Attempts to read the specified path to try to deserialize its contents as [ModInfo](ModInfo.md 'wawa.IO.ModInfo').

```csharp
public static wawa.Optionals.Maybe<wawa.IO.ModInfo> ReadThenDeserialize(string filePath);
```
#### Parameters

<a name='wawa.IO.ModInfo.ReadThenDeserialize(string).filePath'></a>

`filePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The contents to a modInfo.json.<p/>`[UriString]`

#### Returns
[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[ModInfo](ModInfo.md 'wawa.IO.ModInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')  
A [wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1') containing either a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new') instance  
of [ModInfo](ModInfo.md 'wawa.IO.ModInfo') which has the information of the file if the serialization is successful,  
or no value if the file couldn't be read/located.