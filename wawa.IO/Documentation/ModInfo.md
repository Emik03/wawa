### [wawa.IO](wawa.IO.md 'wawa.IO')

## ModInfo Class

Contains the properties needed to perform JSON-deserialization  
of a modInfo.json located in the root directory of a mod.

```csharp
public sealed class ModInfo :
System.ICloneable,
System.IEquatable<wawa.IO.ModInfo>,
System.Collections.Generic.IEqualityComparer<wawa.IO.ModInfo>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ModInfo

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[ModInfo](ModInfo.md 'wawa.IO.ModInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[ModInfo](ModInfo.md 'wawa.IO.ModInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

| Fields | |
| :--- | :--- |
| [FileName](ModInfo.FileName.md 'wawa.IO.ModInfo.FileName') | The file name used for this type. |

| Properties | |
| :--- | :--- |
| [Author](ModInfo.Author.md 'wawa.IO.ModInfo.Author') | Gets the author(s) of the mod. |
| [Description](ModInfo.Description.md 'wawa.IO.ModInfo.Description') | Gets the description of the mod. |
| [Id](ModInfo.Id.md 'wawa.IO.ModInfo.Id') | Gets the id of the mod. |
| [Title](ModInfo.Title.md 'wawa.IO.ModInfo.Title') | Gets the title of the mod. |
| [UnityVersion](ModInfo.UnityVersion.md 'wawa.IO.ModInfo.UnityVersion') | Gets the Unity version used to compile the mod. |
| [Version](ModInfo.Version.md 'wawa.IO.ModInfo.Version') | Gets the version number of the mod. |

| Methods | |
| :--- | :--- |
| [Deserialize(string)](ModInfo.Deserialize(string).md 'wawa.IO.ModInfo.Deserialize(string)') | Tries to deserialize the parameter as [ModInfo](ModInfo.md 'wawa.IO.ModInfo'). |
| [ReadThenDeserialize(string)](ModInfo.ReadThenDeserialize(string).md 'wawa.IO.ModInfo.ReadThenDeserialize(string)') | Attempts to read the specified path to try to deserialize its contents as [ModInfo](ModInfo.md 'wawa.IO.ModInfo'). |

| Operators | |
| :--- | :--- |
| [operator ==(ModInfo, ModInfo)](ModInfo.op_Equality(ModInfo,ModInfo).md 'wawa.IO.ModInfo.op_Equality(wawa.IO.ModInfo, wawa.IO.ModInfo)') | Determines whether both instances contain the same values. |
| [operator !=(ModInfo, ModInfo)](ModInfo.op_Inequality(ModInfo,ModInfo).md 'wawa.IO.ModInfo.op_Inequality(wawa.IO.ModInfo, wawa.IO.ModInfo)') | Determines whether both instances do not contain the same values. |
