# operator \!=\(Config\<T\>, Config\<T\>\) Method

namespace: [wawa\.IO](../../wawa.IO.md)<br />
assembly: [wawa\.IO](../../../wawa.IO.md)

Determines whether both instances are one of `null` and the other instanced\.

```csharp
public static bool op_Inequality(Config<T> left ,Config<T> right);
```

## Parameters

__left__ : [Config\<T\>](../../../wawa.IO/wawa.IO/Config\`1.md)

The left\-hand side\.

__right__ : [Config\<T\>](../../../wawa.IO/wawa.IO/Config\`1.md)

The right\-hand side\.

## Return Value

`bool`

The value `true` if both do not share the same [FilePath](../../../wawa.IO/wawa.IO/Config\`1/FilePath.md),
otherwise `false`\.

