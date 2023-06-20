### [Wawa.Modules](Wawa.Modules.md 'Wawa.Modules').[Stringifier](Stringifier.md 'Wawa.Modules.Stringifier')

## Stringifier.Stringify<T>(T, int, bool) Method

Converts [source](Stringifier.Stringify{T}(T,int,bool).md#Wawa.Modules.Stringifier.Stringify_T_(T,int,bool).source 'Wawa.Modules.Stringifier.Stringify<T>(T, int, bool).source') into a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of [source](Stringifier.Stringify{T}(T,int,bool).md#Wawa.Modules.Stringifier.Stringify_T_(T,int,bool).source 'Wawa.Modules.Stringifier.Stringify<T>(T, int, bool).source').

```csharp
public static string Stringify<T>(T? source, int depth, bool useQuotes=false);
```
#### Type parameters

<a name='Wawa.Modules.Stringifier.Stringify_T_(T,int,bool).T'></a>

`T`

The type of the source.
#### Parameters

<a name='Wawa.Modules.Stringifier.Stringify_T_(T,int,bool).source'></a>

`source` [T](Stringifier.Stringify{T}(T,int,bool).md#Wawa.Modules.Stringifier.Stringify_T_(T,int,bool).T 'Wawa.Modules.Stringifier.Stringify<T>(T, int, bool).T')

The item to get a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of.

<a name='Wawa.Modules.Stringifier.Stringify_T_(T,int,bool).depth'></a>

`depth` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Determines how deep the recursive function should go.

<a name='Wawa.Modules.Stringifier.Stringify_T_(T,int,bool).useQuotes'></a>

`useQuotes` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Determines whether [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') and [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char') have a " and ' surrounding them.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[source](Stringifier.Stringify{T}(T,int,bool).md#Wawa.Modules.Stringifier.Stringify_T_(T,int,bool).source 'Wawa.Modules.Stringifier.Stringify<T>(T, int, bool).source') as [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').

### Remarks
  
Unlike [System.Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/System.Object.ToString 'System.Object.ToString'), the values of all properties are printed out,  
unless they explicitly define a [System.Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/System.Object.ToString 'System.Object.ToString'), or implement [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'),  
in which case each item within is printed out separately.