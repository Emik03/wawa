# ToManyEntities\(IEnumerable\<KMBomb\>\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Creates an `ReadOnlyCollection<T>` where each element has been converted\.

```csharp
public static ReadOnlyCollection<ReadOnlyCollection<Entity>> ToManyEntities(this IEnumerable<KMBomb> bombs);
```

## Parameters

__bombs__ : `IEnumerable<KMBomb>`

The collection\.

## Return Value

`ReadOnlyCollection<ReadOnlyCollection<Entity>>`

An immutable array\.

