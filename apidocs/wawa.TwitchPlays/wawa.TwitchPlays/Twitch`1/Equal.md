# Equal\(string, string\) Method

namespace: [wawa\.TwitchPlays](../../wawa.TwitchPlays.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)

Determines whether two strings are equal, without accounting for case\.

```csharp
protected static bool Equal(string left ,string right);
```

## Parameters

__left__ : `string`

The left\-hand side\.

__right__ : `string`

The right\-hand side\.

## Return Value

`bool`

The value `true` if the parameters `left` and
`right` are equal to each other according to the comparison type
`StringComparison.OrdinalIgnoreCase`; otherwise, `false`\.

