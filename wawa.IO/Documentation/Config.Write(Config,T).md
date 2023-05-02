### [Wawa.IO](Wawa.IO.md 'Wawa.IO').[Config](Config.md 'Wawa.IO.Config')

## Config.Write<T>(this Config<T>, T) Method

Writes the settings to the settings file.

```csharp
public static Wawa.IO.Config<T> Write<T>(this Wawa.IO.Config<T> that, T value)
    where T : new();
```
#### Type parameters

<a name='Wawa.IO.Config.Write_T_(thisWawa.IO.Config_T_,T).T'></a>

`T`

The generic used in [that](Config.Write(Config,T).md#Wawa.IO.Config.Write_T_(thisWawa.IO.Config_T_,T).that 'Wawa.IO.Config.Write<T>(this Wawa.IO.Config<T>, T).that').
#### Parameters

<a name='Wawa.IO.Config.Write_T_(thisWawa.IO.Config_T_,T).that'></a>

`that` [Wawa.IO.Config&lt;](Config_T_.md 'Wawa.IO.Config<T>')[T](Config.Write(Config,T).md#Wawa.IO.Config.Write_T_(thisWawa.IO.Config_T_,T).T 'Wawa.IO.Config.Write<T>(this Wawa.IO.Config<T>, T).T')[&gt;](Config_T_.md 'Wawa.IO.Config<T>')

This instance of [Config&lt;T&gt;](Config_T_.md 'Wawa.IO.Config<T>').

<a name='Wawa.IO.Config.Write_T_(thisWawa.IO.Config_T_,T).value'></a>

`value` [T](Config.Write(Config,T).md#Wawa.IO.Config.Write_T_(thisWawa.IO.Config_T_,T).T 'Wawa.IO.Config.Write<T>(this Wawa.IO.Config<T>, T).T')

The value to overwrite the settings file with.

#### Returns
[Wawa.IO.Config&lt;](Config_T_.md 'Wawa.IO.Config<T>')[T](Config.Write(Config,T).md#Wawa.IO.Config.Write_T_(thisWawa.IO.Config_T_,T).T 'Wawa.IO.Config.Write<T>(this Wawa.IO.Config<T>, T).T')[&gt;](Config_T_.md 'Wawa.IO.Config<T>')  
The value [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').

### Remarks
  
To protect the user settings, this does nothing if the last read wasn't successful.  
  
In the editor, this method does nothing.