# Xor\<T\>\(Maybe\<T\>, Maybe\<T\>\) Method

namespace: [wawa\.Optionals](../../wawa.Optionals.md)<br />
assembly: [wawa\.Optionals](../../../wawa.Optionals.md)

Gives itself, or the parameter\.

```csharp
public static Maybe<T> Xor<T>(this Maybe<T> that ,Maybe<T> otherwise);
```

## Type Parameters

__T__

The type of value stored within `that`\.

## Parameters

__that__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

__otherwise__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

The value to return if `Maybe<T>.IsSome` is `false`\.

## Return Value

[Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

The inner value, or the parameter `otherwise`\.

