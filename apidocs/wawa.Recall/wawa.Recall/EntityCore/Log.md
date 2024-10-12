# Log Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)



## Overloads

| Name | Summary |
|------|---------|
| Log\(Entity\) | Hooks the logger to each instance\. |
| Log\(IEnumerable\<Entity\>\) | Hooks the logger to each instance\. |
| Log\(IEnumerable\<Maybe\<Entity\>\>\) | Hooks the logger to each instance\. |

## Log\(Entity\)

Hooks the logger to each instance\.

```csharp
public static Entity Log(this Entity that);
```

### Parameters

__that__ : [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)

This instance of [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)\.

### Return Value

[Entity](../../../wawa.Recall/wawa.Recall/Entity.md)

The parameter `that`\.

## Log\(IEnumerable\<Entity\>\)

Hooks the logger to each instance\.

```csharp
public static IEnumerable<Entity> Log(this IEnumerable<Entity> that);
```

### Parameters

__that__ : `IEnumerable<Entity>`

This instance of [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)\.

### Return Value

`IEnumerable<Entity>`

The parameter `that`\.

## Log\(IEnumerable\<Maybe\<Entity\>\>\)

Hooks the logger to each instance\.

```csharp
public static IEnumerable<Maybe<Entity>> Log(this IEnumerable<Maybe<Entity>> that);
```

### Parameters

__that__ : `IEnumerable<Maybe<Entity>>`

This instance of [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)\.

### Return Value

`IEnumerable<Maybe<Entity>>`

The parameter `that`\.

