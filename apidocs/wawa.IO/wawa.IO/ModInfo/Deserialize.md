# Deserialize\(string\) Method

namespace: [wawa\.IO](../../wawa.IO.md)<br />
assembly: [wawa\.IO](../../../wawa.IO.md)

Tries to deserialize the parameter as [ModInfo](../../../wawa.IO/wawa.IO/ModInfo.md)\.

```csharp
public static Maybe<ModInfo> Deserialize(string contents);
```

## Parameters

__contents__ : `string`

The contents to a modInfo\.json\.

## Return Value

[Maybe\<ModInfo\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

A [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md) containing either a `new` instance
of [ModInfo](../../../wawa.IO/wawa.IO/ModInfo.md) which has the information of the file if the serialization is successful,
or no value if the file couldn't be read/located\.

