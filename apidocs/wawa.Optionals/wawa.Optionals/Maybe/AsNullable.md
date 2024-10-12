# AsNullable\<T\>\(Maybe\<T\>\) Method

namespace: [wawa\.Optionals](../../wawa.Optionals.md)<br />
assembly: [wawa\.Optionals](../../../wawa.Optionals.md)

Creates a [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md) from a `Nullable<T>`\.

```csharp
public static T? AsNullable<T>(this Maybe<T> that) where T : struct;
```

## Type Parameters

__T__ : `struct`

The type of parameter and generic in `Nullable<T>`\.

## Parameters

__that__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of `T`\.

## Return Value

`T?`

The `Nullable<T>` representing `that`\.

