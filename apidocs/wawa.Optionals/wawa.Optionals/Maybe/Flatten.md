# Flatten Method

namespace: [wawa\.Optionals](../../wawa.Optionals.md)<br />
assembly: [wawa\.Optionals](../../../wawa.Optionals.md)



## Overloads

| Name | Summary |
|------|---------|
| Flatten\<T\>\(Maybe\<Maybe\<T\>\>\) | Flattens a nested [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\. |
| Flatten\<T\>\(Maybe\<Maybe\<Maybe\<T\>\>\>\) | Flattens a nested [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\. |
| Flatten\<T\>\(Maybe\<Maybe\<Maybe\<Maybe\<T\>\>\>\>\) | Flattens a nested [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\. |

## Flatten\<T\>\(Maybe\<Maybe\<T\>\>\)

Flattens a nested [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

```csharp
public static Maybe<T> Flatten<T>(this Maybe<Maybe<T>> that);
```

### Type Parameters

__T__

The type of value stored within `that`\.

### Parameters

__that__ : [Maybe\<Maybe\<T\>\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

### Return Value

[Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

The nested [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md), or `default`\.

## Flatten\<T\>\(Maybe\<Maybe\<Maybe\<T\>\>\>\)

Flattens a nested [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

```csharp
public static Maybe<T> Flatten<T>(this Maybe<Maybe<Maybe<T>>> that);
```

### Type Parameters

__T__

The type of value stored within `that`\.

### Parameters

__that__ : [Maybe\<Maybe\<Maybe\<T\>\>\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

### Return Value

[Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

The nested [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md), or `default`\.

## Flatten\<T\>\(Maybe\<Maybe\<Maybe\<Maybe\<T\>\>\>\>\)

Flattens a nested [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

```csharp
public static Maybe<T> Flatten<T>(this Maybe<Maybe<Maybe<Maybe<T>>>> that);
```

### Type Parameters

__T__

The type of value stored within `that`\.

### Parameters

__that__ : [Maybe\<Maybe\<Maybe\<Maybe\<T\>\>\>\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

This instance of [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

### Return Value

[Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

The nested [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md), or `default`\.

