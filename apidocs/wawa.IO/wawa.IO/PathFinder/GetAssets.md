# GetAssets\<T\>\(string, string\) Method

namespace: [wawa\.IO](../../wawa.IO.md)<br />
assembly: [wawa\.IO](../../../wawa.IO.md)

Loads and returns assets from disk\.

```csharp
public static Maybe<IList<T>> GetAssets<T>(string filePath ,string modId = null);
```

## Type Parameters

__T__ : `UnityEngine.Object`

The type of asset to get\.

## Parameters

__filePath__ : `string`

The file which contains the assets\.

__modId__ : `string`

The mod id to get the mod directory from\.
If `null`, implicitly gets the directory of the mod from the name of the assembly\.


## Return Value

[Maybe\<IList\<T\>\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

A [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md), consisting of either an `Array` of ``
from the assets in the file specified, or `default` in the event of an error\.

