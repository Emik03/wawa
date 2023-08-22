### [Wawa.IO](Wawa.IO.md 'Wawa.IO').[ModInfo](ModInfo.md 'Wawa.IO.ModInfo')

## ModInfo.Deserialize(string) Method

Tries to deserialize the parameter as [ModInfo](ModInfo.md 'Wawa.IO.ModInfo').

```csharp
public static Wawa.Optionals.Maybe<Wawa.IO.ModInfo> Deserialize(string contents);
```
#### Parameters

<a name='Wawa.IO.ModInfo.Deserialize(string).contents'></a>

`contents` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The contents to a modInfo.json.

#### Returns
[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[ModInfo](ModInfo.md 'Wawa.IO.ModInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')  
A [Wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1') containing either a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new') instance  
of [ModInfo](ModInfo.md 'Wawa.IO.ModInfo') which has the information of the file if the serialization is successful,  
or no value if the file couldn't be read/located.