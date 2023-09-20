### [Wawa.IO](Wawa.IO.md 'Wawa.IO').[Config](Config.md 'Wawa.IO.Config')

## Config.Merge<T>(this Config<T>, T, bool) Method

Reads, merges, and writes the settings to the settings file.

```csharp
public static Wawa.IO.Config<T> Merge<T>(this Wawa.IO.Config<T> that, T value, bool isDiscarding=false)
    where T : new();
```
#### Type parameters

<a name='Wawa.IO.Config.Merge_T_(thisWawa.IO.Config_T_,T,bool).T'></a>

`T`

The generic used in [that](Config.Merge{T}(Config{T},T,bool).md#Wawa.IO.Config.Merge_T_(thisWawa.IO.Config_T_,T,bool).that 'Wawa.IO.Config.Merge<T>(this Wawa.IO.Config<T>, T, bool).that').
#### Parameters

<a name='Wawa.IO.Config.Merge_T_(thisWawa.IO.Config_T_,T,bool).that'></a>

`that` [Wawa.IO.Config&lt;](Config{T}.md 'Wawa.IO.Config<T>')[T](Config.Merge{T}(Config{T},T,bool).md#Wawa.IO.Config.Merge_T_(thisWawa.IO.Config_T_,T,bool).T 'Wawa.IO.Config.Merge<T>(this Wawa.IO.Config<T>, T, bool).T')[&gt;](Config{T}.md 'Wawa.IO.Config<T>')

This instance of [Config&lt;T&gt;](Config{T}.md 'Wawa.IO.Config<T>').

<a name='Wawa.IO.Config.Merge_T_(thisWawa.IO.Config_T_,T,bool).value'></a>

`value` [T](Config.Merge{T}(Config{T},T,bool).md#Wawa.IO.Config.Merge_T_(thisWawa.IO.Config_T_,T,bool).T 'Wawa.IO.Config.Merge<T>(this Wawa.IO.Config<T>, T, bool).T')

The value to merge the file with.

<a name='Wawa.IO.Config.Merge_T_(thisWawa.IO.Config_T_,T,bool).isDiscarding'></a>

`isDiscarding` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Determines whether it should remove values from the original  
file that isn't contained within the type, or has the incorrect type.

#### Returns
[Wawa.IO.Config&lt;](Config{T}.md 'Wawa.IO.Config<T>')[T](Config.Merge{T}(Config{T},T,bool).md#Wawa.IO.Config.Merge_T_(thisWawa.IO.Config_T_,T,bool).T 'Wawa.IO.Config.Merge<T>(this Wawa.IO.Config<T>, T, bool).T')[&gt;](Config{T}.md 'Wawa.IO.Config<T>')  
The parameter [that](Config.Merge{T}(Config{T},T,bool).md#Wawa.IO.Config.Merge_T_(thisWawa.IO.Config_T_,T,bool).that 'Wawa.IO.Config.Merge<T>(this Wawa.IO.Config<T>, T, bool).that').

### Remarks
  
To protect the user settings, this does nothing if the last read wasn't successful.  
  
In the editor, this method does nothing.