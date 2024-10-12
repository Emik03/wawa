# AsMaybe\<T\>\(T?\) Method

namespace: [wawa\.Optionals](../../wawa.Optionals.md)<br />
assembly: [wawa\.Optionals](../../../wawa.Optionals.md)

Creates a `Nullable<T>` from a [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

```csharp
public static Maybe<T> AsMaybe<T>(this T? that) where T : struct;
```

## Type Parameters

__T__ : `struct`

The type of parameter and generic in [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

## Parameters

__that__ : `T?`

This instance of `T`\.

## Return Value

[Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

The [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md) representing `that`\.

