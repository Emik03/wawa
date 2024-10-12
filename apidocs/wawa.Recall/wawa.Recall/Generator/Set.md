# Set Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)



## Overloads

| Name | Summary |
|------|---------|
| Set\<T\>\(PropDef\<T\>, T\) | Sets the inner value to the parameter `value`\. |
| Set\<T\>\(HookDef\<T\>, Action?\) | Sets the inner value to the parameter `value`\. |

## Set\<T\>\(PropDef\<T\>, T\)

Sets the inner value to the parameter `value`\.

```csharp
public static PropDef<T> Set<T>(this PropDef<T> that ,T value);
```

### Type Parameters

__T__

The type parameter of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

### Parameters

__that__ : [PropDef\<T\>](../../../wawa.Recall/wawa.Recall/PropDef\`1.md)

This instance of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

__value__ : `T`

The value to set the inner value with\.

### Return Value

[PropDef\<T\>](../../../wawa.Recall/wawa.Recall/PropDef\`1.md)

The parameter `that`\.

## Set\<T\>\(HookDef\<T\>, Action?\)

Sets the inner value to the parameter `value`\.

```csharp
public static HookDef<T> Set<T>(this HookDef<T> that ,Action? value);
```

### Type Parameters

__T__ : `Delegate`

The type parameter of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

### Parameters

__that__ : [HookDef\<T\>](../../../wawa.Recall/wawa.Recall/HookDef\`1.md)

This instance of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

__value__ : `Action?`

The value to set the inner value with\.

### Return Value

[HookDef\<T\>](../../../wawa.Recall/wawa.Recall/HookDef\`1.md)

The parameter `that`\.

