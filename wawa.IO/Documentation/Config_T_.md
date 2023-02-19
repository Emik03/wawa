### [Wawa.IO](Wawa.IO.md 'Wawa.IO')

## Config<T> Class

Meant for information that needs to be deserialized within the mod settings folder.

```csharp
public sealed class Config<T> :
System.ICloneable,
System.IEquatable<Wawa.IO.Config<T>>,
System.Collections.Generic.IEqualityComparer<Wawa.IO.Config<T>>
    where T : new()
```
#### Type parameters

<a name='Wawa.IO.Config_T_.T'></a>

`T`

The type to serialize and deserialize the file.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Config<T>

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Wawa.IO.Config&lt;](Config_T_.md 'Wawa.IO.Config<T>')[T](Config_T_.md#Wawa.IO.Config_T_.T 'Wawa.IO.Config<T>.T')[&gt;](Config_T_.md 'Wawa.IO.Config<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[Wawa.IO.Config&lt;](Config_T_.md 'Wawa.IO.Config<T>')[T](Config_T_.md#Wawa.IO.Config_T_.T 'Wawa.IO.Config<T>.T')[&gt;](Config_T_.md 'Wawa.IO.Config<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

### Remarks
  
Originally by samfundev: https://github.com/samfundev/KTANE-Utilities/blob/master/ModConfig.cs.  
  
All constructors in this type have the following side effects:  
- A file will automatically be made if it doesn't exist.  
- A JSON property defined in the type [T](Config_T_.md#Wawa.IO.Config_T_.T 'Wawa.IO.Config<T>.T') that doesn't exist in the file  
  will automatically be appended with a new default instance of [T](Config_T_.md#Wawa.IO.Config_T_.T 'Wawa.IO.Config<T>.T')'s values.  
- In the editor, this constructor will not merge the default of type [T](Config_T_.md#Wawa.IO.Config_T_.T 'Wawa.IO.Config<T>.T') with the file.

| Constructors | |
| :--- | :--- |
| [Config()](Config_T_.Config().md 'Wawa.IO.Config<T>.Config()') | Initializes a new instance of the [Config&lt;T&gt;](Config_T_.md 'Wawa.IO.Config<T>') class. |
| [Config(string)](Config_T_..ctor.K+nESknSzAKLqcgVaVFegA.md 'Wawa.IO.Config<T>.Config(string)') | Initializes a new instance of the [Config&lt;T&gt;](Config_T_.md 'Wawa.IO.Config<T>') class. |

| Properties | |
| :--- | :--- |
| [FilePath](Config_T_.FilePath.md 'Wawa.IO.Config<T>.FilePath') | Gets the path of the file to read and write. |
| [HasRead](Config_T_.HasRead.md 'Wawa.IO.Config<T>.HasRead') | Gets a value indicating whether or not there has been a successful read of the settings file. |

| Methods | |
| :--- | :--- |
| [ToString()](Config_T_.ToString().md 'Wawa.IO.Config<T>.ToString()') | Deserializes, then re-serializes the file according to [Serialize&lt;TSerialize&gt;(TSerialize)](Config.Serialize.6DBej5T2qB+lCS5EB2849g.md 'Wawa.IO.Config.Serialize<TSerialize>(TSerialize)').<br/>In the editor, this method serializes the default value of the constructor in [T](Config_T_.md#Wawa.IO.Config_T_.T 'Wawa.IO.Config<T>.T'). |

| Operators | |
| :--- | :--- |
| [operator ==(Config&lt;T&gt;, Config&lt;T&gt;)](Config_T_.op_Equality.cKCl7ASCejwoNGBMH0WAHw.md 'Wawa.IO.Config<T>.op_Equality(Wawa.IO.Config<T>, Wawa.IO.Config<T>)') | Determines whether both instances are both [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') or both instances. |
| [operator !=(Config&lt;T&gt;, Config&lt;T&gt;)](Config_T_.op_Inequality.YN6WKI1CsOkd57cNG6pQNQ.md 'Wawa.IO.Config<T>.op_Inequality(Wawa.IO.Config<T>, Wawa.IO.Config<T>)') | Determines whether both instances are one of [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') and the other instanced. |
