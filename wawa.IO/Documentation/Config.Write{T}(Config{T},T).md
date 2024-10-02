### [wawa.IO](wawa.IO.md 'wawa.IO').[Config](Config.md 'wawa.IO.Config')

## Config.Write<T>(this Config<T>, T) Method

Writes the settings to the settings file.

```csharp
public static wawa.IO.Config<T> Write<T>(this wawa.IO.Config<T> that, T value)
    where T : new();
```
#### Type parameters

<a name='wawa.IO.Config.Write_T_(thiswawa.IO.Config_T_,T).T'></a>

`T`

The generic used in [that](Config.Write{T}(Config{T},T).md#wawa.IO.Config.Write_T_(thiswawa.IO.Config_T_,T).that 'wawa.IO.Config.Write<T>(this wawa.IO.Config<T>, T).that').
#### Parameters

<a name='wawa.IO.Config.Write_T_(thiswawa.IO.Config_T_,T).that'></a>

`that` [wawa.IO.Config&lt;](Config{T}.md 'wawa.IO.Config<T>')[T](Config.Write{T}(Config{T},T).md#wawa.IO.Config.Write_T_(thiswawa.IO.Config_T_,T).T 'wawa.IO.Config.Write<T>(this wawa.IO.Config<T>, T).T')[&gt;](Config{T}.md 'wawa.IO.Config<T>')

This instance of [Config&lt;T&gt;](Config{T}.md 'wawa.IO.Config<T>').

<a name='wawa.IO.Config.Write_T_(thiswawa.IO.Config_T_,T).value'></a>

`value` [T](Config.Write{T}(Config{T},T).md#wawa.IO.Config.Write_T_(thiswawa.IO.Config_T_,T).T 'wawa.IO.Config.Write<T>(this wawa.IO.Config<T>, T).T')

The value to overwrite the settings file with.

#### Returns
[wawa.IO.Config&lt;](Config{T}.md 'wawa.IO.Config<T>')[T](Config.Write{T}(Config{T},T).md#wawa.IO.Config.Write_T_(thiswawa.IO.Config_T_,T).T 'wawa.IO.Config.Write<T>(this wawa.IO.Config<T>, T).T')[&gt;](Config{T}.md 'wawa.IO.Config<T>')  
The value [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').

### Remarks
  
To protect the user settings, this does nothing if the last read wasn't successful.  
  
In the editor, this method does nothing.