# As\<T, TResult\>\(Maybe\<T\>\) Method

namespace: [wawa\.Optionals](../../wawa.Optionals.md)<br />
assembly: [wawa\.Optionals](../../../wawa.Optionals.md)

Upcasts this instance to `TResult`\.

```csharp
public static Maybe<TResult> As<T ,TResult>(this Maybe<T> that);
```

## Type Parameters

__T__ : `TResult`

The type of value stored within `that`\.

__TResult__

The type to value to upcast and return\.

## Parameters

__that__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)



## Return Value

[Maybe\<TResult\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

Itself, upcast to `TResult`\.

