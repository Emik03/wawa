# TryRemove Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)



## Overloads

| Name | Summary |
|------|---------|
| TryRemove\<T\>\(HookMay\<T\>?, T\) |  |
| TryRemove\<T\>\(HookMay\<T\>?, Action?\) |  |

## TryRemove\<T\>\(HookMay\<T\>?, T\)



```csharp
public static bool TryRemove<T>(this HookMay<T>? that ,T value);
```

### Type Parameters

__T__ : `Delegate`



### Parameters

__that__ : [HookMay\<T\>?](../../../wawa.Recall/wawa.Recall/HookMay\`1.md)



__value__ : `T`



### Return Value

`bool`



## TryRemove\<T\>\(HookMay\<T\>?, Action?\)



```csharp
public static bool TryRemove<T>(this HookMay<T>? that ,Action? value);
```

### Type Parameters

__T__ : `Delegate`



### Parameters

__that__ : [HookMay\<T\>?](../../../wawa.Recall/wawa.Recall/HookMay\`1.md)



__value__ : `Action?`



### Return Value

`bool`



