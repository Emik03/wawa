### [Wawa.IO](Wawa.IO.md 'Wawa.IO').[Config&lt;T&gt;](Config_T_.md 'Wawa.IO.Config<T>')

## Config(string) Constructor

Initializes a new instance of the [Config&lt;T&gt;](Config_T_.md 'Wawa.IO.Config<T>') class.

```csharp
public Config(string fileName);
```
#### Parameters

<a name='Wawa.IO.Config_T_.Config(string).fileName'></a>

`fileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The file name to get.

### Remarks
- Allows specification of the target file name.  
- A file will automatically be made if it doesn't exist.  
- A JSON property defined in the type [T](Config_T_.md#Wawa.IO.Config_T_.T 'Wawa.IO.Config<T>.T') that doesn't exist in the file  
  will automatically be appended with a new default instance of [T](Config_T_.md#Wawa.IO.Config_T_.T 'Wawa.IO.Config<T>.T')'s values.  
- In the editor, this constructor will not merge the default of type [T](Config_T_.md#Wawa.IO.Config_T_.T 'Wawa.IO.Config<T>.T') with the file.