# GetFile\(string, string\) Method

namespace: [wawa\.IO](../../wawa.IO.md)<br />
assembly: [wawa\.IO](../../../wawa.IO.md)

Gets the absolute directory of the file located inside the mod directory\.

```csharp
public static Maybe<string> GetFile(string filePath ,string modId = null);
```

## Parameters

__filePath__ : `string`

The file located inside folder mod directory\.

__modId__ : `string`

The mod id to get the mod directory from\.
If `null`, implicitly gets the directory of the mod from the name of the assembly\.


## Return Value

[Maybe\<string\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

A [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md), consisting of either folder `System.String` of the absolute directory
of the file if the mod directory and file were found, or `default`\.

