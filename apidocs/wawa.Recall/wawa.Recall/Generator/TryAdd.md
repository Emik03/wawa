# TryAdd Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)



## Overloads

| Name | Summary |
|------|---------|
| TryAdd\<T\>\(HookMay\<T\>?, T\) | Attempts to add the parameter `value` from the inner value\. |
| TryAdd\<T\>\(HookMay\<T\>?, Action?\) |  |

## TryAdd\<T\>\(HookMay\<T\>?, T\)

Attempts to add the parameter `value` from the inner value\.

```csharp
public static bool TryAdd<T>(this HookMay<T>? that ,T value);
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

The value `true` if mutation succeeded, otherwise; `false`\.

## TryAdd\<T\>\(HookMay\<T\>?, Action?\)



```csharp
public static bool TryAdd<T>(this HookMay<T>? that ,Action? value);
```

### Type Parameters

__T__ : `Delegate`



### Parameters

__that__ : [HookMay\<T\>?](../../../wawa.Recall/wawa.Recall/HookMay\`1.md)



__value__ : `Action?`



### Return Value

`bool`



