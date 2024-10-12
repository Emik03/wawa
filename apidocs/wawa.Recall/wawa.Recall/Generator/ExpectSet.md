# ExpectSet Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)



## Overloads

| Name | Summary |
|------|---------|
| ExpectSet\<T\>\(PropMay\<T\>, T\) | Sets the inner value with the provided `value`\. Will throw on fail\. |
| ExpectSet\<T\>\(HookMay\<T\>, Action?\) | Sets the inner value with the provided `value`\. Will throw on fail\. |

## ExpectSet\<T\>\(PropMay\<T\>, T\)

Sets the inner value with the provided `value`\. Will throw on fail\.

```csharp
public static PropMay<T> ExpectSet<T>(this PropMay<T> that ,T value);
```

### Type Parameters

__T__

The type parameter of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

### Parameters

__that__ : [PropMay\<T\>](../../../wawa.Recall/wawa.Recall/PropMay\`1.md)

This instance of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

__value__ : `T`

The value to set the inner value with\.

### Return Value

[PropMay\<T\>](../../../wawa.Recall/wawa.Recall/PropMay\`1.md)

The parameter `that`\.

## ExpectSet\<T\>\(HookMay\<T\>, Action?\)

Sets the inner value with the provided `value`\. Will throw on fail\.

```csharp
public static HookMay<T> ExpectSet<T>(this HookMay<T> that ,Action? value);
```

### Type Parameters

__T__ : `Delegate`

The type parameter of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

### Parameters

__that__ : [HookMay\<T\>](../../../wawa.Recall/wawa.Recall/HookMay\`1.md)

This instance of [Prop\<T\>](../../../wawa.Recall/wawa.Recall/Prop\`1.md)\.

__value__ : `Action?`

The value to set the inner value with\.

### Return Value

[HookMay\<T\>](../../../wawa.Recall/wawa.Recall/HookMay\`1.md)

The parameter `that`\.

