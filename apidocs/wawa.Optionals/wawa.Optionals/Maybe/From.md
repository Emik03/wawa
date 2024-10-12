# From Method

namespace: [wawa\.Optionals](../../wawa.Optionals.md)<br />
assembly: [wawa\.Optionals](../../../wawa.Optionals.md)



## Overloads

| Name | Summary |
|------|---------|
| From\<T\>\(T\) | Wraps `T` in a [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\. |
| From\<T\>\(T?\) | Wraps `T` in a [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\. |

## From\<T\>\(T\)

Wraps `T` in a [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

```csharp
public static Maybe<T> From<T>(T that) where T : class;
```

### Type Parameters

__T__ : `class`

The type of parameter and generic in [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

### Parameters

__that__ : `T`

This instance of `T`\.

### Return Value

[Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

A new instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

## From\<T\>\(T?\)

Wraps `T` in a [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

```csharp
public static Maybe<T> From<T>(T? that) where T : struct;
```

### Type Parameters

__T__ : `struct`

The type of parameter and generic in [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

### Parameters

__that__ : `T?`

This instance of `T`\.

### Return Value

[Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

A new instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

