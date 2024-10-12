# Config Class

namespace: [wawa\.IO](../wawa.IO.md)<br />
assembly: [wawa\.IO](../../wawa.IO.md)

Implementations for [Config\<T\>](../../wawa.IO/wawa.IO/Config\`1.md)\.

```csharp
public static class Config;
```

Inheritance: `object` > Config

## Methods

| Name | Summary |
|------|---------|
| [Serialize\<TSerialize\>\(TSerialize\)](./Config/Serialize.md) | Serializes settings the same way it's written to the file\. Supports settings that use enums\. |
| [Write\<T\>\(Config\<T\>, string\)](./Config/Write.md) | Writes the string to the settings file\. |
| [Write\<T\>\(Config\<T\>, T\)](./Config/Write.md) | Writes the settings to the settings file\. |
| [Merge\<T\>\(Config\<T\>, T, bool\)](./Config/Merge.md) | Reads, merges, and writes the settings to the settings file\. |
| [Read\<T\>\(Config\<T\>\)](./Config/Read.md) | Reads the settings from the settings file\. |

## Fields

| Name | Value | Summary |
|------|-------|---------|
| [Folder](./Config/Folder) | null | The name of the folder that contains locally stored mod settings\. |
| [Suffix](./Config/Suffix) | null | The suffix for the default file name for mod settings\. |
| [Tutorial](./Config/Tutorial) | null | The key substring that is ignored in mod configs\. |

