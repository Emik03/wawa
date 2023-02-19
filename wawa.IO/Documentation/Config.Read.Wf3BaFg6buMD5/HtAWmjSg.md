### [Wawa.IO](Wawa.IO.md 'Wawa.IO').[Config](Config.md 'Wawa.IO.Config')

## Config.Read<T>(this Config<T>) Method

Reads the settings from the settings file.

```csharp
public static T Read<T>(this Wawa.IO.Config<T> that)
    where T : new();
```
#### Type parameters

<a name='Wawa.IO.Config.Read_T_(thisWawa.IO.Config_T_).T'></a>

`T`

The generic used in [that](Config.Read.Wf3BaFg6buMD5/HtAWmjSg.md#Wawa.IO.Config.Read_T_(thisWawa.IO.Config_T_).that 'Wawa.IO.Config.Read<T>(this Wawa.IO.Config<T>).that').
#### Parameters

<a name='Wawa.IO.Config.Read_T_(thisWawa.IO.Config_T_).that'></a>

`that` [Wawa.IO.Config&lt;](Config_T_.md 'Wawa.IO.Config<T>')[T](Config.Read.Wf3BaFg6buMD5/HtAWmjSg.md#Wawa.IO.Config.Read_T_(thisWawa.IO.Config_T_).T 'Wawa.IO.Config.Read<T>(this Wawa.IO.Config<T>).T')[&gt;](Config_T_.md 'Wawa.IO.Config<T>')

This instance of [Config&lt;T&gt;](Config_T_.md 'Wawa.IO.Config<T>').

#### Returns
[T](Config.Read.Wf3BaFg6buMD5/HtAWmjSg.md#Wawa.IO.Config.Read_T_(thisWawa.IO.Config_T_).T 'Wawa.IO.Config.Read<T>(this Wawa.IO.Config<T>).T')  
If the read and deserialization was successful, a [T](Config.Read.Wf3BaFg6buMD5/HtAWmjSg.md#Wawa.IO.Config.Read_T_(thisWawa.IO.Config_T_).T 'Wawa.IO.Config.Read<T>(this Wawa.IO.Config<T>).T') containing the values from the file,  
otherwise a new instance of [T](Config.Read.Wf3BaFg6buMD5/HtAWmjSg.md#Wawa.IO.Config.Read_T_(thisWawa.IO.Config_T_).T 'Wawa.IO.Config.Read<T>(this Wawa.IO.Config<T>).T').

### Remarks
  
If the settings couldn't be read, the default settings will be returned.  
  
In the editor, this method returns the default value of the constructor in [T](Config.Read.Wf3BaFg6buMD5/HtAWmjSg.md#Wawa.IO.Config.Read_T_(thisWawa.IO.Config_T_).T 'Wawa.IO.Config.Read<T>(this Wawa.IO.Config<T>).T').