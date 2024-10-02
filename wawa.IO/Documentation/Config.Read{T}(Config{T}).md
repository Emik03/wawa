### [wawa.IO](wawa.IO.md 'wawa.IO').[Config](Config.md 'wawa.IO.Config')

## Config.Read<T>(this Config<T>) Method

Reads the settings from the settings file.

```csharp
public static T Read<T>(this wawa.IO.Config<T> that)
    where T : new();
```
#### Type parameters

<a name='wawa.IO.Config.Read_T_(thiswawa.IO.Config_T_).T'></a>

`T`

The generic used in [that](Config.Read{T}(Config{T}).md#wawa.IO.Config.Read_T_(thiswawa.IO.Config_T_).that 'wawa.IO.Config.Read<T>(this wawa.IO.Config<T>).that').
#### Parameters

<a name='wawa.IO.Config.Read_T_(thiswawa.IO.Config_T_).that'></a>

`that` [wawa.IO.Config&lt;](Config{T}.md 'wawa.IO.Config<T>')[T](Config.Read{T}(Config{T}).md#wawa.IO.Config.Read_T_(thiswawa.IO.Config_T_).T 'wawa.IO.Config.Read<T>(this wawa.IO.Config<T>).T')[&gt;](Config{T}.md 'wawa.IO.Config<T>')

This instance of [Config&lt;T&gt;](Config{T}.md 'wawa.IO.Config<T>').

#### Returns
[T](Config.Read{T}(Config{T}).md#wawa.IO.Config.Read_T_(thiswawa.IO.Config_T_).T 'wawa.IO.Config.Read<T>(this wawa.IO.Config<T>).T')  
If the read and deserialization was successful, a [T](Config.Read{T}(Config{T}).md#wawa.IO.Config.Read_T_(thiswawa.IO.Config_T_).T 'wawa.IO.Config.Read<T>(this wawa.IO.Config<T>).T') containing the values from the file,  
otherwise a new instance of [T](Config.Read{T}(Config{T}).md#wawa.IO.Config.Read_T_(thiswawa.IO.Config_T_).T 'wawa.IO.Config.Read<T>(this wawa.IO.Config<T>).T').

### Remarks
  
If the settings couldn't be read, the default settings will be returned.  
  
In the editor, this method returns the default value of the constructor in [T](Config.Read{T}(Config{T}).md#wawa.IO.Config.Read_T_(thiswawa.IO.Config_T_).T 'wawa.IO.Config.Read<T>(this wawa.IO.Config<T>).T').