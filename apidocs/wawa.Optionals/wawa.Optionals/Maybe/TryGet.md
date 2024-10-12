# TryGet\<T\>\(Maybe\<T\>, out T\) Method

namespace: [wawa\.Optionals](../../wawa.Optionals.md)<br />
assembly: [wawa\.Optionals](../../../wawa.Optionals.md)

Assigns a value with the inner value, or a `default` value if none exists\.

```csharp
public static bool TryGet<T>(this Maybe<T> that ,out T result);
```

## Type Parameters

__T__

The generic type argument in [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

## Parameters

__that__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

__result__ : `T`

The resulting value, or `default`\.

## Return Value

`bool`

The value `true` if `that` contains a value, otherwise `false`\.

