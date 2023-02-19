### [Wawa.IO](Wawa.IO.md 'Wawa.IO')

## Config Class

Implementations for [Config&lt;T&gt;](Config_T_.md 'Wawa.IO.Config<T>').

```csharp
public static class Config
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Config

| Fields | |
| :--- | :--- |
| [Folder](Config.Folder.md 'Wawa.IO.Config.Folder') | The name of the folder that contains locally stored mod settings. |
| [Suffix](Config.Suffix.md 'Wawa.IO.Config.Suffix') | The suffix for the default file name for mod settings. |
| [Tutorial](Config.Tutorial.md 'Wawa.IO.Config.Tutorial') | The key substring that is ignored in mod configs. |

| Methods | |
| :--- | :--- |
| [Merge&lt;T&gt;(this Config&lt;T&gt;, T, bool)](Config.Merge.ckC11BkUEgxVLRVpKCtQYQ.md 'Wawa.IO.Config.Merge<T>(this Wawa.IO.Config<T>, T, bool)') | Reads, merges, and writes the settings to the settings file. |
| [Read&lt;T&gt;(this Config&lt;T&gt;)](Config.Read.Wf3BaFg6buMD5/HtAWmjSg.md 'Wawa.IO.Config.Read<T>(this Wawa.IO.Config<T>)') | Reads the settings from the settings file. |
| [Serialize&lt;TSerialize&gt;(TSerialize)](Config.Serialize.6DBej5T2qB+lCS5EB2849g.md 'Wawa.IO.Config.Serialize<TSerialize>(TSerialize)') | Serializes settings the same way it's written to the file. Supports settings that use enums. |
| [Write&lt;T&gt;(this Config&lt;T&gt;, string)](Config.Write.FQR/NUxIJfravK00QJhM8w.md 'Wawa.IO.Config.Write<T>(this Wawa.IO.Config<T>, string)') | Writes the string to the settings file. |
| [Write&lt;T&gt;(this Config&lt;T&gt;, T)](Config.Write.Z/NLGGEGDY/9ekiVDsDJlg.md 'Wawa.IO.Config.Write<T>(this Wawa.IO.Config<T>, T)') | Writes the settings to the settings file. |
