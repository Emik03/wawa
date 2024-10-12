# ExpectRemoveRaw\<T\>\(HookMay\<T\>, T\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Removes the parameter `value` from the inner value\. Will throw on fail\.

```csharp
public static HookMay<T>? ExpectRemoveRaw<T>(this HookMay<T> that ,T value);
```

## Type Parameters

__T__ : `Delegate`

The type parameter of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

## Parameters

__that__ : [HookMay\<T\>](../../../wawa.Recall/wawa.Recall/HookMay\`1.md)

This instance of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

__value__ : `T`

The value to set the inner value with\.

## Return Value

[HookMay\<T\>?](../../../wawa.Recall/wawa.Recall/HookMay\`1.md)

The parameter `that`\.

