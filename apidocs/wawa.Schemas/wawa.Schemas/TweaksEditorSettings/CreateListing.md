# CreateListing\(string, string\) Method

namespace: [wawa\.Schemas](../../wawa.Schemas.md)<br />
assembly: [wawa\.Schemas](../../../wawa.Schemas.md)

Creates the new builder\.

```csharp
public static CanSection CreateListing(string name ,string modId = null);
```

## Parameters

__name__ : `string`

The name of the initial listing\.

__modId__ : `string`

The mod id to get the file name from\.
If `null`, implicitly gets the file name of the mod from the name of the assembly\.


## Return Value

[CanSection](../../../wawa.Schemas/wawa.Schemas.Fluent/CanSection.md)

Itself\.

