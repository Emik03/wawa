# TrySet Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)



## Overloads

| Name | Summary |
|------|---------|
| TrySet\<T\>\(HookMay\<T\>?, T\) | Attempts to set the inner value to the parameter `value`\. |
| TrySet\<T\>\(HookMay\<T\>?, Action?\) |  |
| TrySet\<T\>\(PropMay\<T\>?, T\) | Attempts to set the inner value to the parameter `value`\. |

## TrySet\<T\>\(HookMay\<T\>?, T\)

Attempts to set the inner value to the parameter `value`\.

```csharp
public static bool TrySet<T>(this HookMay<T>? that ,T value);
```

### Type Parameters

__T__ : `Delegate`

The type parameter of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

### Parameters

__that__ : [HookMay\<T\>?](../../../wawa.Recall/wawa.Recall/HookMay\`1.md)

This instance of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

__value__ : `T`

The value to set the inner value with\.

### Return Value

`bool`

The value `true` if the value set was successful, otherwise `false`\.

## TrySet\<T\>\(HookMay\<T\>?, Action?\)



```csharp
public static bool TrySet<T>(this HookMay<T>? that ,Action? value);
```

### Type Parameters

__T__ : `Delegate`



### Parameters

__that__ : [HookMay\<T\>?](../../../wawa.Recall/wawa.Recall/HookMay\`1.md)



__value__ : `Action?`



### Return Value

`bool`



## TrySet\<T\>\(PropMay\<T\>?, T\)

Attempts to set the inner value to the parameter `value`\.

```csharp
public static bool TrySet<T>(this PropMay<T>? that ,T value);
```

### Type Parameters

__T__

The type parameter of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

### Parameters

__that__ : [PropMay\<T\>?](../../../wawa.Recall/wawa.Recall/PropMay\`1.md)

This instance of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

__value__ : `T`

The value to set the inner value with\.

### Return Value

`bool`

The value `true` if the value set was successful, otherwise `false`\.

