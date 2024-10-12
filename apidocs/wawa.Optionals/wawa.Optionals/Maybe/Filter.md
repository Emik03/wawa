# Filter\<T\>\(IEnumerable\<Maybe\<T\>\>\) Method

namespace: [wawa\.Optionals](../../wawa.Optionals.md)<br />
assembly: [wawa\.Optionals](../../../wawa.Optionals.md)

Filters a collection with only that of items with a value\.

```csharp
public static IEnumerable<T> Filter<T>(this IEnumerable<Maybe<T>> source);
```

## Type Parameters

__T__

The type of parameter and generic in [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

## Parameters

__source__ : `IEnumerable<Maybe<T>>`

This collection of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

## Return Value

`IEnumerable<T>`

A filtered collection only consisting of unwrapped `T` values\.

