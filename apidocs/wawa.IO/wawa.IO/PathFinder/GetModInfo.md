# GetModInfo\(string\) Method

namespace: [wawa\.IO](../../wawa.IO.md)<br />
assembly: [wawa\.IO](../../../wawa.IO.md)

Gets and deserializes the [ModInfo](../../../wawa.IO/wawa.IO/ModInfo.md) file located in every mod's root directory\.

```csharp
public static Maybe<ModInfo> GetModInfo(string modId = null);
```

## Parameters

__modId__ : `string`

The mod id to get the mod directory from\.
If `null`, implicitly gets the directory of the mod from the name of the assembly\.


## Return Value

[Maybe\<ModInfo\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

A [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md), consisting of either folder [ModInfo](../../../wawa.IO/wawa.IO/ModInfo.md) if the file was read
and deserialized successfully, or `default`\.

