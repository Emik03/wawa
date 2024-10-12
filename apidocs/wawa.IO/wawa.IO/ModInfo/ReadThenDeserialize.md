# ReadThenDeserialize\(string\) Method

namespace: [wawa\.IO](../../wawa.IO.md)<br />
assembly: [wawa\.IO](../../../wawa.IO.md)

Attempts to read the specified path to try to deserialize its contents as [ModInfo](../../../wawa.IO/wawa.IO/ModInfo.md)\.

```csharp
public static Maybe<ModInfo> ReadThenDeserialize(string filePath);
```

## Parameters

__filePath__ : `string`

The contents to a modInfo\.json\.

## Return Value

[Maybe\<ModInfo\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

A [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md) containing either a `new` instance
of [ModInfo](../../../wawa.IO/wawa.IO/ModInfo.md) which has the information of the file if the serialization is successful,
or no value if the file couldn't be read/located\.

