### [wawa.IO](wawa.IO.md 'wawa.IO').[Config](Config.md 'wawa.IO.Config')

## Config.Merge<T>(this Config<T>, T, bool) Method

Reads, merges, and writes the settings to the settings file.

```csharp
public static wawa.IO.Config<T> Merge<T>(this wawa.IO.Config<T> that, T value, bool isDiscarding=false)
    where T : new();
```
#### Type parameters

<a name='wawa.IO.Config.Merge_T_(thiswawa.IO.Config_T_,T,bool).T'></a>

`T`

The generic used in [that](Config.Merge{T}(Config{T},T,bool).md#wawa.IO.Config.Merge_T_(thiswawa.IO.Config_T_,T,bool).that 'wawa.IO.Config.Merge<T>(this wawa.IO.Config<T>, T, bool).that').
#### Parameters

<a name='wawa.IO.Config.Merge_T_(thiswawa.IO.Config_T_,T,bool).that'></a>

`that` [wawa.IO.Config&lt;](Config{T}.md 'wawa.IO.Config<T>')[T](Config.Merge{T}(Config{T},T,bool).md#wawa.IO.Config.Merge_T_(thiswawa.IO.Config_T_,T,bool).T 'wawa.IO.Config.Merge<T>(this wawa.IO.Config<T>, T, bool).T')[&gt;](Config{T}.md 'wawa.IO.Config<T>')

This instance of [Config&lt;T&gt;](Config{T}.md 'wawa.IO.Config<T>').

<a name='wawa.IO.Config.Merge_T_(thiswawa.IO.Config_T_,T,bool).value'></a>

`value` [T](Config.Merge{T}(Config{T},T,bool).md#wawa.IO.Config.Merge_T_(thiswawa.IO.Config_T_,T,bool).T 'wawa.IO.Config.Merge<T>(this wawa.IO.Config<T>, T, bool).T')

The value to merge the file with.

<a name='wawa.IO.Config.Merge_T_(thiswawa.IO.Config_T_,T,bool).isDiscarding'></a>

`isDiscarding` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Determines whether it should remove values from the original  
file that isn't contained within the type, or has the incorrect type.

#### Returns
[wawa.IO.Config&lt;](Config{T}.md 'wawa.IO.Config<T>')[T](Config.Merge{T}(Config{T},T,bool).md#wawa.IO.Config.Merge_T_(thiswawa.IO.Config_T_,T,bool).T 'wawa.IO.Config.Merge<T>(this wawa.IO.Config<T>, T, bool).T')[&gt;](Config{T}.md 'wawa.IO.Config<T>')  
The parameter [that](Config.Merge{T}(Config{T},T,bool).md#wawa.IO.Config.Merge_T_(thiswawa.IO.Config_T_,T,bool).that 'wawa.IO.Config.Merge<T>(this wawa.IO.Config<T>, T, bool).that').

### Remarks
  
To protect the user settings, this does nothing if the last read wasn't successful.  
  
In the editor, this method does nothing.