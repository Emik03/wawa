### [wawa.IO](wawa.IO.md 'wawa.IO').[Config](Config.md 'wawa.IO.Config')

## Config.Write<T>(this Config<T>, string) Method

Writes the string to the settings file.

```csharp
public static wawa.IO.Config<T> Write<T>(this wawa.IO.Config<T> that, string value)
    where T : new();
```
#### Type parameters

<a name='wawa.IO.Config.Write_T_(thiswawa.IO.Config_T_,string).T'></a>

`T`

The generic used in [that](Config.Write{T}(Config{T},string).md#wawa.IO.Config.Write_T_(thiswawa.IO.Config_T_,string).that 'wawa.IO.Config.Write<T>(this wawa.IO.Config<T>, string).that').
#### Parameters

<a name='wawa.IO.Config.Write_T_(thiswawa.IO.Config_T_,string).that'></a>

`that` [wawa.IO.Config&lt;](Config{T}.md 'wawa.IO.Config<T>')[T](Config.Write{T}(Config{T},string).md#wawa.IO.Config.Write_T_(thiswawa.IO.Config_T_,string).T 'wawa.IO.Config.Write<T>(this wawa.IO.Config<T>, string).T')[&gt;](Config{T}.md 'wawa.IO.Config<T>')

This instance of [Config&lt;T&gt;](Config{T}.md 'wawa.IO.Config<T>').

<a name='wawa.IO.Config.Write_T_(thiswawa.IO.Config_T_,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The contents to write.

#### Returns
[wawa.IO.Config&lt;](Config{T}.md 'wawa.IO.Config<T>')[T](Config.Write{T}(Config{T},string).md#wawa.IO.Config.Write_T_(thiswawa.IO.Config_T_,string).T 'wawa.IO.Config.Write<T>(this wawa.IO.Config<T>, string).T')[&gt;](Config{T}.md 'wawa.IO.Config<T>')  
The parameter [that](Config.Write{T}(Config{T},string).md#wawa.IO.Config.Write_T_(thiswawa.IO.Config_T_,string).that 'wawa.IO.Config.Write<T>(this wawa.IO.Config<T>, string).that').

### Remarks
  
To protect the user settings, this does nothing if the last read wasn't successful.  
  
In the editor, this method does nothing.