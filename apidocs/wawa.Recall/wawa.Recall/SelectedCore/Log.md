# Log Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)



## Overloads

| Name | Summary |
|------|---------|
| Log\(Selected\) | Hooks the logger to each instance\. |
| Log\(IEnumerable\<Selected\>\) | Hooks the logger to each instance\. |
| Log\(IEnumerable\<Maybe\<Selected\>\>\) | Hooks the logger to each instance\. |

## Log\(Selected\)

Hooks the logger to each instance\.

```csharp
public static Selected Log(this Selected that);
```

### Parameters

__that__ : [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)

This instance of [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)\.

### Return Value

[Selected](../../../wawa.Recall/wawa.Recall/Selected.md)

The parameter `that`\.

## Log\(IEnumerable\<Selected\>\)

Hooks the logger to each instance\.

```csharp
public static IEnumerable<Selected> Log(this IEnumerable<Selected> that);
```

### Parameters

__that__ : `IEnumerable<Selected>`

This instance of [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)\.

### Return Value

`IEnumerable<Selected>`

The parameter `that`\.

## Log\(IEnumerable\<Maybe\<Selected\>\>\)

Hooks the logger to each instance\.

```csharp
public static IEnumerable<Maybe<Selected>> Log(this IEnumerable<Maybe<Selected>> that);
```

### Parameters

__that__ : `IEnumerable<Maybe<Selected>>`

This instance of [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)\.

### Return Value

`IEnumerable<Maybe<Selected>>`

The parameter `that`\.

