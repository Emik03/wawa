### [Wawa.Modules](Wawa.Modules.md 'Wawa.Modules').[Stringifier](Stringifier.md 'Wawa.Modules.Stringifier')

## Stringifier.Stringify<T>(T, bool, bool, bool) Method

Converts [source](Stringifier.Stringify(T,Boolean,Boolean,Boolean).md#Wawa.Modules.Stringifier.Stringify_T_(T,bool,bool,bool).source 'Wawa.Modules.Stringifier.Stringify<T>(T, bool, bool, bool).source') into a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of [source](Stringifier.Stringify(T,Boolean,Boolean,Boolean).md#Wawa.Modules.Stringifier.Stringify_T_(T,bool,bool,bool).source 'Wawa.Modules.Stringifier.Stringify<T>(T, bool, bool, bool).source').

```csharp
public static string Stringify<T>(T? source, bool isSurrounded, bool isRecursive=true, bool forceReflection=true);
```
#### Type parameters

<a name='Wawa.Modules.Stringifier.Stringify_T_(T,bool,bool,bool).T'></a>

`T`

The type of the source.
#### Parameters

<a name='Wawa.Modules.Stringifier.Stringify_T_(T,bool,bool,bool).source'></a>

`source` [T](Stringifier.Stringify(T,Boolean,Boolean,Boolean).md#Wawa.Modules.Stringifier.Stringify_T_(T,bool,bool,bool).T 'Wawa.Modules.Stringifier.Stringify<T>(T, bool, bool, bool).T')

The item to get a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of.

<a name='Wawa.Modules.Stringifier.Stringify_T_(T,bool,bool,bool).isSurrounded'></a>

`isSurrounded` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Determines whether [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') and [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char') have a " and ' surrounding them.

<a name='Wawa.Modules.Stringifier.Stringify_T_(T,bool,bool,bool).isRecursive'></a>

`isRecursive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Determines whether it re-calls [Stringify&lt;T&gt;(T, bool, bool, bool)](Stringifier.Stringify(T,Boolean,Boolean,Boolean).md 'Wawa.Modules.Stringifier.Stringify<T>(T, bool, bool, bool)')  
on each property in [source](Stringifier.Stringify(T,Boolean,Boolean,Boolean).md#Wawa.Modules.Stringifier.Stringify_T_(T,bool,bool,bool).source 'Wawa.Modules.Stringifier.Stringify<T>(T, bool, bool, bool).source').

<a name='Wawa.Modules.Stringifier.Stringify_T_(T,bool,bool,bool).forceReflection'></a>

`forceReflection` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Determines whether it uses its own reflective stringification regardless of type.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[source](Stringifier.Stringify(T,Boolean,Boolean,Boolean).md#Wawa.Modules.Stringifier.Stringify_T_(T,bool,bool,bool).source 'Wawa.Modules.Stringifier.Stringify<T>(T, bool, bool, bool).source') as [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').

### Remarks
  
Unlike [System.Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/System.Object.ToString 'System.Object.ToString'), the values of all properties are printed out,  
unless they explicitly define a [System.Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/System.Object.ToString 'System.Object.ToString'), or inherit [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'),  
in which case each item within is printed out separately.