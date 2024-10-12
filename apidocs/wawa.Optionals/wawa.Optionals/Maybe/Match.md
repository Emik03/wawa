# Match Method

namespace: [wawa\.Optionals](../../wawa.Optionals.md)<br />
assembly: [wawa\.Optionals](../../../wawa.Optionals.md)



## Overloads

| Name | Summary |
|------|---------|
| Match\<T\>\(Maybe\<T\>, Action\<T\>, Action\<Unit\>\) | Uses the callback corresponding to the inner value of `that`\. |
| Match\<T, TResult\>\(Maybe\<T\>, Func\<T, Maybe\<TResult\>\>\) | Uses the callback corresponding to the inner value of `that`\. |
| Match\<T, TResult\>\(Maybe\<T\>, Func\<T, TResult\>\) | Uses the callback corresponding to the inner value of `that`\. |
| Match\<T, TResult\>\(Maybe\<T\>, TResult\) | Gives the parameter corresponding to the inner value of `that`\. |
| Match\<T, TResult\>\(Maybe\<T\>, Func\<T, TResult\>, Func\<Unit, TResult\>\) | Uses the callback corresponding to the inner value of `that`\. |
| Match\<T, TResult\>\(Maybe\<T\>, TResult, TResult\) | Gives the parameter corresponding to the inner value of `that`\. |

## Match\<T\>\(Maybe\<T\>, Action\<T\>, Action\<Unit\>\)

Uses the callback corresponding to the inner value of `that`\.

```csharp
public static Maybe<T> Match<T>(this Maybe<T> that ,Action<T> some = null ,Action<Unit> none = null);
```

### Type Parameters

__T__

The type of value stored within `that`\.

### Parameters

__that__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

__some__ : `Action<T>`

The callback to run if `Maybe<T>.IsSome` is `true`\.

__none__ : `Action<Unit>`

The callback to run if `Maybe<T>.IsSome` is `false`\.

### Return Value

[Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

The parameter `that`\.

## Match\<T, TResult\>\(Maybe\<T\>, Func\<T, Maybe\<TResult\>\>\)

Uses the callback corresponding to the inner value of `that`\.

```csharp
public static Maybe<TResult> Match<T ,TResult>(this Maybe<T> that ,Func<T, Maybe<TResult>> some);
```

### Type Parameters

__T__

The type of value stored within `that`\.

__TResult__

The `return` value of both callbacks\.

### Parameters

__that__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

__some__ : `Func<T, Maybe<TResult>>`

The callback to run if `Maybe<T>.IsSome` is `true`\.

### Return Value

[Maybe\<TResult\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

The value returned from the corresponding callback\.

## Match\<T, TResult\>\(Maybe\<T\>, Func\<T, TResult\>\)

Uses the callback corresponding to the inner value of `that`\.

```csharp
public static Maybe<TResult> Match<T ,TResult>(this Maybe<T> that ,Func<T, TResult> some);
```

### Type Parameters

__T__

The type of value stored within `that`\.

__TResult__

The `return` value of both callbacks\.

### Parameters

__that__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

__some__ : `Func<T, TResult>`

The callback to run if `Maybe<T>.IsSome` is `true`\.

### Return Value

[Maybe\<TResult\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

The value returned from the callback, or `default`\.

## Match\<T, TResult\>\(Maybe\<T\>, TResult\)

Gives the parameter corresponding to the inner value of `that`\.

```csharp
public static Maybe<TResult> Match<T ,TResult>(this Maybe<T> that ,TResult some);
```

### Type Parameters

__T__

The type of value stored within `that`\.

__TResult__

The `return` value of both callbacks\.

### Parameters

__that__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

__some__ : `TResult`

The value to return if `Maybe<T>.IsSome` is `true`\.

### Return Value

[Maybe\<TResult\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

The parameter, or `default`\.

## Match\<T, TResult\>\(Maybe\<T\>, Func\<T, TResult\>, Func\<Unit, TResult\>\)

Uses the callback corresponding to the inner value of `that`\.

```csharp
public static TResult Match<T ,TResult>(this Maybe<T> that ,Func<T, TResult> some ,Func<Unit, TResult> none);
```

### Type Parameters

__T__

The type of value stored within `that`\.

__TResult__

The `return` value of both callbacks\.

### Parameters

__that__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

__some__ : `Func<T, TResult>`

The callback to run if `Maybe<T>.IsSome` is `true`\.

__none__ : `Func<Unit, TResult>`

The callback to run if `Maybe<T>.IsSome` is `false`\.

### Return Value

`TResult`

The value returned from the corresponding callback\.

## Match\<T, TResult\>\(Maybe\<T\>, TResult, TResult\)

Gives the parameter corresponding to the inner value of `that`\.

```csharp
public static TResult Match<T ,TResult>(this Maybe<T> that ,TResult some ,TResult none);
```

### Type Parameters

__T__

The type of value stored within `that`\.

__TResult__

The `return` value of both callbacks\.

### Parameters

__that__ : [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

__some__ : `TResult`

The value to return if `Maybe<T>.IsSome` is `true`\.

__none__ : `TResult`

The value to return if `Maybe<T>.IsSome` is `false`\.

### Return Value

`TResult`

The corresponding parameter\.

