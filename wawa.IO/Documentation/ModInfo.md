### [Wawa.IO](Wawa.IO.md 'Wawa.IO')

## ModInfo Class

Contains the properties needed to perform JSON-deserialization  
of a modInfo.json located in the root directory of a mod.

```csharp
public sealed class ModInfo :
System.ICloneable,
System.IEquatable<Wawa.IO.ModInfo>,
System.Collections.Generic.IEqualityComparer<Wawa.IO.ModInfo>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ModInfo

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[ModInfo](ModInfo.md 'Wawa.IO.ModInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[ModInfo](ModInfo.md 'Wawa.IO.ModInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

| Fields | |
| :--- | :--- |
| [FileName](ModInfo.FileName.md 'Wawa.IO.ModInfo.FileName') | The file name used for this type. |

| Properties | |
| :--- | :--- |
| [Author](ModInfo.Author.md 'Wawa.IO.ModInfo.Author') | Gets the author(s) of the mod. |
| [Description](ModInfo.Description.md 'Wawa.IO.ModInfo.Description') | Gets the description of the mod. |
| [Id](ModInfo.Id.md 'Wawa.IO.ModInfo.Id') | Gets the id of the mod. |
| [Title](ModInfo.Title.md 'Wawa.IO.ModInfo.Title') | Gets the title of the mod. |
| [UnityVersion](ModInfo.UnityVersion.md 'Wawa.IO.ModInfo.UnityVersion') | Gets the Unity version used to compile the mod. |
| [Version](ModInfo.Version.md 'Wawa.IO.ModInfo.Version') | Gets the version number of the mod. |

| Methods | |
| :--- | :--- |
| [Deserialize(string)](ModInfo.Deserialize.kNjYqzFD5WSwl17Uj4U6uA.md 'Wawa.IO.ModInfo.Deserialize(string)') | Tries to deserialize the parameter as [ModInfo](ModInfo.md 'Wawa.IO.ModInfo'). |
| [ReadThenDeserialize(string)](ModInfo.ReadThenDeserialize.RlM9tEAbHu9qaPDACNvviQ.md 'Wawa.IO.ModInfo.ReadThenDeserialize(string)') | Attempts to read the specified path to try to deserialize its contents as [ModInfo](ModInfo.md 'Wawa.IO.ModInfo'). |

| Operators | |
| :--- | :--- |
| [operator ==(ModInfo, ModInfo)](ModInfo.op_Equality.P8F2OIoLFI3CB+jcve6SIg.md 'Wawa.IO.ModInfo.op_Equality(Wawa.IO.ModInfo, Wawa.IO.ModInfo)') | Determines whether both instances contain the same values. |
| [operator !=(ModInfo, ModInfo)](ModInfo.op_Inequality.lYm2WQXpvfHsshtswBKrCg.md 'Wawa.IO.ModInfo.op_Inequality(Wawa.IO.ModInfo, Wawa.IO.ModInfo)') | Determines whether both instances do not contain the same values. |
