### [Wawa.Modules](Wawa.Modules.md 'Wawa.Modules').[Stringifier](Stringifier.md 'Wawa.Modules.Stringifier')

## Stringifier.Stringify<T>(T) Method

Converts [source](Stringifier.Stringify(T).md#Wawa.Modules.Stringifier.Stringify_T_(T).source 'Wawa.Modules.Stringifier.Stringify<T>(T).source') into a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of [source](Stringifier.Stringify(T).md#Wawa.Modules.Stringifier.Stringify_T_(T).source 'Wawa.Modules.Stringifier.Stringify<T>(T).source').

```csharp
public static string Stringify<T>(T? source);
```
#### Type parameters

<a name='Wawa.Modules.Stringifier.Stringify_T_(T).T'></a>

`T`

The type of the source.
#### Parameters

<a name='Wawa.Modules.Stringifier.Stringify_T_(T).source'></a>

`source` [T](Stringifier.Stringify(T).md#Wawa.Modules.Stringifier.Stringify_T_(T).T 'Wawa.Modules.Stringifier.Stringify<T>(T).T')

The item to get a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[source](Stringifier.Stringify(T).md#Wawa.Modules.Stringifier.Stringify_T_(T).source 'Wawa.Modules.Stringifier.Stringify<T>(T).source') as [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').

### Remarks
  
Unlike [System.Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/System.Object.ToString 'System.Object.ToString'), the values of all properties are printed out,  
unless they explicitly define a [System.Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/System.Object.ToString 'System.Object.ToString'), or inherit [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'),  
in which case each item within is printed out separately.