### [Wawa.IO](Wawa.IO.md 'Wawa.IO').[Config](Config.md 'Wawa.IO.Config')

## Config.Write<T>(this Config<T>, string) Method

Writes the string to the settings file.

```csharp
public static Wawa.IO.Config<T> Write<T>(this Wawa.IO.Config<T> that, string value)
    where T : new();
```
#### Type parameters

<a name='Wawa.IO.Config.Write_T_(thisWawa.IO.Config_T_,string).T'></a>

`T`

The generic used in [that](Config.Write{T}(Config{T},String).md#Wawa.IO.Config.Write_T_(thisWawa.IO.Config_T_,string).that 'Wawa.IO.Config.Write<T>(this Wawa.IO.Config<T>, string).that').
#### Parameters

<a name='Wawa.IO.Config.Write_T_(thisWawa.IO.Config_T_,string).that'></a>

`that` [Wawa.IO.Config&lt;](Config{T}.md 'Wawa.IO.Config<T>')[T](Config.Write{T}(Config{T},String).md#Wawa.IO.Config.Write_T_(thisWawa.IO.Config_T_,string).T 'Wawa.IO.Config.Write<T>(this Wawa.IO.Config<T>, string).T')[&gt;](Config{T}.md 'Wawa.IO.Config<T>')

This instance of [Config&lt;T&gt;](Config{T}.md 'Wawa.IO.Config<T>').

<a name='Wawa.IO.Config.Write_T_(thisWawa.IO.Config_T_,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The contents to write.

#### Returns
[Wawa.IO.Config&lt;](Config{T}.md 'Wawa.IO.Config<T>')[T](Config.Write{T}(Config{T},String).md#Wawa.IO.Config.Write_T_(thisWawa.IO.Config_T_,string).T 'Wawa.IO.Config.Write<T>(this Wawa.IO.Config<T>, string).T')[&gt;](Config{T}.md 'Wawa.IO.Config<T>')  
The parameter [that](Config.Write{T}(Config{T},String).md#Wawa.IO.Config.Write_T_(thisWawa.IO.Config_T_,string).that 'Wawa.IO.Config.Write<T>(this Wawa.IO.Config<T>, string).that').

### Remarks
  
To protect the user settings, this does nothing if the last read wasn't successful.  
  
In the editor, this method does nothing.