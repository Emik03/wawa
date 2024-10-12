# ExpectAdd\<T\>\(HookMay\<T\>, Action\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Adds the parameter `value` from the inner value\. Will throw on fail\.

```csharp
public static HookMay<T> ExpectAdd<T>(this HookMay<T> that ,Action value);
```

## Type Parameters

__T__ : `Delegate`

The type parameter of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

## Parameters

__that__ : [HookMay\<T\>](../../../wawa.Recall/wawa.Recall/HookMay\`1.md)

This instance of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

__value__ : `Action`

The value to set the inner value with\.

## Return Value

[HookMay\<T\>](../../../wawa.Recall/wawa.Recall/HookMay\`1.md)

The parameter `that`\.

