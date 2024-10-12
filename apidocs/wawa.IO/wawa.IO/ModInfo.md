# ModInfo Class

namespace: [wawa\.IO](../wawa.IO.md)<br />
assembly: [wawa\.IO](../../wawa.IO.md)

Contains the properties needed to perform JSON\-deserialization
of a modInfo\.json located in the root directory of a mod\.

```csharp
public sealed class ModInfo;
```

Inheritance: `ICloneable` > ModInfo

Implements: `IEquatable<ModInfo>`, `IEqualityComparer<ModInfo>`

## Methods

| Name | Summary |
|------|---------|
| [Clone\(\)](./ModInfo/Clone.md) |  |
| [Equals\(ModInfo, ModInfo\)](./ModInfo/Equals.md) |  |
| [GetHashCode\(ModInfo\)](./ModInfo/GetHashCode.md) |  |
| [Equals\(ModInfo\)](./ModInfo/Equals.md) |  |
| [operator ==\(ModInfo, ModInfo\)](./ModInfo/op_Equality.md) | Determines whether both instances contain the same values\. |
| [operator \!=\(ModInfo, ModInfo\)](./ModInfo/op_Inequality.md) | Determines whether both instances do not contain the same values\. |
| [Deserialize\(string\)](./ModInfo/Deserialize.md) | Tries to deserialize the parameter as [ModInfo](../../wawa.IO/wawa.IO/ModInfo.md)\. |
| [ReadThenDeserialize\(string\)](./ModInfo/ReadThenDeserialize.md) | Attempts to read the specified path to try to deserialize its contents as [ModInfo](../../wawa.IO/wawa.IO/ModInfo.md)\. |
| [Equals\(object\)](./ModInfo/Equals.md) |  |
| [GetHashCode\(\)](./ModInfo/GetHashCode.md) |  |
| [ToString\(\)](./ModInfo/ToString.md) |  |

## Properties

| Name | Summary |
|------|---------|
| [Author](./ModInfo/Author.md) | Gets the author\(s\) of the mod\. |
| [Description](./ModInfo/Description.md) | Gets the description of the mod\. |
| [Id](./ModInfo/Id.md) | Gets the id of the mod\. |
| [Title](./ModInfo/Title.md) | Gets the title of the mod\. |
| [UnityVersion](./ModInfo/UnityVersion.md) | Gets the Unity version used to compile the mod\. |
| [Version](./ModInfo/Version.md) | Gets the version number of the mod\. |

## Fields

| Name | Value | Summary |
|------|-------|---------|
| [FileName](./ModInfo/FileName) | null | The file name used for this type\. |

