# Remove\<T\>\(HookDef\<T\>, Action?\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Removes the parameter `value` from the inner value\.

```csharp
public static HookDef<T> Remove<T>(this HookDef<T> that ,Action? value);
```

## Type Parameters

__T__ : `Delegate`

The type parameter of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

## Parameters

__that__ : [HookDef\<T\>](../../../wawa.Recall/wawa.Recall/HookDef\`1.md)

This instance of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

__value__ : `Action?`

The value to set the inner value with\.

## Return Value

[HookDef\<T\>](../../../wawa.Recall/wawa.Recall/HookDef\`1.md)

The parameter `that`\.

