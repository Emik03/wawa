# Split\(string, string\) Method

namespace: [wawa\.TwitchPlays](../../wawa.TwitchPlays.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)

Splits a `System.String` into an `Array` of `System.String` values based on a separator\.

```csharp
protected static IList<string> Split(string instance ,string separator = " ");
```

## Parameters

__instance__ : `string`

The `System.String` to split\.

__separator__ : `string`

The separator to split each `System.String` with\.

## Return Value

`IList<string>`

An `Array` of `System.String` values which are substrings of `instance`
based on `separator`\. Empty entries are omitted\.

