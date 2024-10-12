# PathFinder Class

namespace: [wawa\.IO](../wawa.IO.md)<br />
assembly: [wawa\.IO](../../wawa.IO.md)

Access to the paths and contents of files within folder mod directory\.

```csharp
public static class PathFinder;
```

Inheritance: `object` > PathFinder

## Methods

| Name | Summary |
|------|---------|
| [AssemblyLog\(string, LogType, string\)](./PathFinder/AssemblyLog.md) | Logs a message to the Unity Console with the assembly's name that called this\. |
| [GetDirectory\(string\)](./PathFinder/GetDirectory.md) | Gets the absolute directory of the mod\. |
| [GetFile\(string, string\)](./PathFinder/GetFile.md) | Gets the absolute directory of the file located inside the mod directory\. |
| [GetModInfo\(string\)](./PathFinder/GetModInfo.md) | Gets and deserializes the [ModInfo](../../wawa.IO/wawa.IO/ModInfo.md) file located in every mod's root directory\. |
| [GetAssets\<T\>\(string, string\)](./PathFinder/GetAssets.md) | Loads and returns assets from disk\. |
| [GetUnmanaged\<T\>\(string, string, string\)](./PathFinder/GetUnmanaged.md) | Gets an unmanaged function from an external library\. |

## Properties

| Name | Summary |
|------|---------|
| [Caller](./PathFinder/Caller.md) | Gets the `AssemblyName` of the caller that invoked the method calling this\. |

