# Unwrap\<T\>\(Maybe\<T\>\) Method

namespace: [wawa\.Optionals](../../wawa.Optionals.md)<br />
assembly: [wawa\.Optionals](../../../wawa.Optionals.md)

Gets the value that is encapsulated\. This value returned will not be `null`,
and consequentially if it is\.

```csharp
public static T Unwrap<T>(this Maybe<T> that);
```

## Type Parameters

__T__

The type of value stored within `that`\.

## Parameters

__that__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

## Return Value

`T`

The inner value\.

