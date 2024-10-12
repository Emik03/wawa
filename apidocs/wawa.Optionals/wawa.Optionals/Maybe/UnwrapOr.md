# UnwrapOr Method

namespace: [wawa\.Optionals](../../wawa.Optionals.md)<br />
assembly: [wawa\.Optionals](../../../wawa.Optionals.md)



## Overloads

| Name | Summary |
|------|---------|
| UnwrapOr\<T\>\(Maybe\<T\>, T\) | Gives the inner value, or the parameter\. |
| UnwrapOr\<T\>\(Maybe\<T\>, Func\<Unit, T\>\) | Gives the inner value, or the returned value from the callback\. |

## UnwrapOr\<T\>\(Maybe\<T\>, T\)

Gives the inner value, or the parameter\.

```csharp
public static T UnwrapOr<T>(this Maybe<T> that ,T otherwise);
```

### Type Parameters

__T__

The type of value stored within `that`\.

### Parameters

__that__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

__otherwise__ : `T`

The value to return if `Maybe<T>.IsSome` is `false`\.

### Return Value

`T`

The inner value, or the parameter `otherwise`\.

## UnwrapOr\<T\>\(Maybe\<T\>, Func\<Unit, T\>\)

Gives the inner value, or the returned value from the callback\.

```csharp
public static T UnwrapOr<T>(this Maybe<T> that ,Func<Unit, T> otherwise);
```

### Type Parameters

__T__

The type of value stored within `that`\.

### Parameters

__that__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

__otherwise__ : `Func<Unit, T>`

The callback to execute if `Maybe<T>.IsSome` is `false`\.


### Return Value

`T`

The inner value, or the returned value from the parameter `otherwise`\.

