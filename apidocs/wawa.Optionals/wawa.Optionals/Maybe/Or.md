# Or Method

namespace: [wawa\.Optionals](../../wawa.Optionals.md)<br />
assembly: [wawa\.Optionals](../../../wawa.Optionals.md)



## Overloads

| Name | Summary |
|------|---------|
| Or\<T\>\(Maybe\<T\>, Maybe\<T\>\) | Gives itself, or the parameter\. |
| Or\<T\>\(Maybe\<T\>, Func\<Unit, Maybe\<T\>\>\) | Gives itself, or the parameter\. |

## Or\<T\>\(Maybe\<T\>, Maybe\<T\>\)

Gives itself, or the parameter\.

```csharp
public static Maybe<T> Or<T>(this Maybe<T> that ,Maybe<T> otherwise);
```

### Type Parameters

__T__

The type of value stored within `that`\.

### Parameters

__that__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

__otherwise__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

The value to return if `Maybe<T>.IsSome` is `false`\.

### Return Value

[Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

The inner value, or the parameter `otherwise`\.

## Or\<T\>\(Maybe\<T\>, Func\<Unit, Maybe\<T\>\>\)

Gives itself, or the parameter\.

```csharp
public static Maybe<T> Or<T>(this Maybe<T> that ,Func<Unit, Maybe<T>> otherwise);
```

### Type Parameters

__T__

The type of value stored within `that`\.

### Parameters

__that__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

__otherwise__ : `Func<Unit, Maybe<T>>`

The callback to execute if `Maybe<T>.IsSome` is `false`\.


### Return Value

[Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

The inner value, or the parameter `otherwise`\.

