# operator ==\(Config\<T\>, Config\<T\>\) Method

namespace: [wawa\.IO](../../wawa.IO.md)<br />
assembly: [wawa\.IO](../../../wawa.IO.md)

Determines whether both instances are both `null` or both instances\.

```csharp
public static bool op_Equality(Config<T> left ,Config<T> right);
```

## Parameters

__left__ : [Config\<T\>](../../../wawa.IO/wawa.IO/Config\`1.md)

The left\-hand side operator\.

__right__ : [Config\<T\>](../../../wawa.IO/wawa.IO/Config\`1.md)

The right\-hand side operator\.

## Return Value

`bool`

The value `true` if both share the same [FilePath](../../../wawa.IO/wawa.IO/Config\`1/FilePath.md),
otherwise `false`\.

