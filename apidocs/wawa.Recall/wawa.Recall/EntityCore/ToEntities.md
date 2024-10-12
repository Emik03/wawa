# ToEntities Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)



## Overloads

| Name | Summary |
|------|---------|
| ToEntities\(KMBomb\) | Gets all modules that are children of a provided `KMBomb`\. |
| ToEntities\(IEnumerable\<KMBombModule\>\) | Creates an `ReadOnlyCollection<T>` where each element has been converted\. |
| ToEntities\(IEnumerable\<KMNeedyModule\>\) | Creates an `ReadOnlyCollection<T>` where each element has been converted\. |

## ToEntities\(KMBomb\)

Gets all modules that are children of a provided `KMBomb`\.

```csharp
public static ReadOnlyCollection<Entity> ToEntities(this KMBomb bomb);
```

### Parameters

__bomb__ : `KMBomb`

The `KMBomb` to get the modules from\.

### Return Value

`ReadOnlyCollection<Entity>`

A `ReadOnlyCollection<T>` of type [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) which contains every module from `bomb`\.

## ToEntities\(IEnumerable\<KMBombModule\>\)

Creates an `ReadOnlyCollection<T>` where each element has been converted\.

```csharp
public static ReadOnlyCollection<Entity> ToEntities(this IEnumerable<KMBombModule> solvables);
```

### Parameters

__solvables__ : `IEnumerable<KMBombModule>`

The collection\.

### Return Value

`ReadOnlyCollection<Entity>`

An immutable array\.

## ToEntities\(IEnumerable\<KMNeedyModule\>\)

Creates an `ReadOnlyCollection<T>` where each element has been converted\.

```csharp
public static ReadOnlyCollection<Entity> ToEntities(this IEnumerable<KMNeedyModule> needies);
```

### Parameters

__needies__ : `IEnumerable<KMNeedyModule>`

The collection\.

### Return Value

`ReadOnlyCollection<Entity>`

An immutable array\.

