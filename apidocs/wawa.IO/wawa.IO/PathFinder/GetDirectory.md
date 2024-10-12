# GetDirectory\(string\) Method

namespace: [wawa\.IO](../../wawa.IO.md)<br />
assembly: [wawa\.IO](../../../wawa.IO.md)

Gets the absolute directory of the mod\.

```csharp
public static Maybe<string> GetDirectory(string modId = null);
```

## Parameters

__modId__ : `string`

The mod id to get the mod directory from\.
If `null`, implicitly gets the directory of the mod from the name of the assembly\.


## Return Value

[Maybe\<string\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

A [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md), consisting of either folder `System.String` of the absolute directory
of the file if there is a folder mod id entry within the game's mod dictionary, or `default`\.

