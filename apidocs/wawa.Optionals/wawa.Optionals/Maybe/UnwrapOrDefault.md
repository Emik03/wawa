# UnwrapOrDefault\<T\>\(Maybe\<T\>\) Method

namespace: [wawa\.Optionals](../../wawa.Optionals.md)<br />
assembly: [wawa\.Optionals](../../../wawa.Optionals.md)

Gives the inner value, or `default`\.

```csharp
public static T UnwrapOrDefault<T>(this Maybe<T> that) where T : struct;
```

## Type Parameters

__T__ : `struct`

The type of value stored within `that`\.

## Parameters

__that__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

## Return Value

`T`

The inner value, or `default`\.

