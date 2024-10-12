# ToEntities\(IEnumerable\<Selected\>\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Creates an `ReadOnlyCollection<T>` where each element has been converted\.

```csharp
public static ReadOnlyCollection<Maybe<Entity>> ToEntities(this IEnumerable<Selected> that);
```

## Parameters

__that__ : `IEnumerable<Selected>`

The collection\.

## Return Value

`ReadOnlyCollection<Maybe<Entity>>`

An immutable array\.

