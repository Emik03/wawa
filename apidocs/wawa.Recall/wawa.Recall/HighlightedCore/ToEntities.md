# ToEntities\(IEnumerable\<Highlighted\>\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Creates a `ReadOnlyCollection<T>` where each element has been converted\.

```csharp
public static ReadOnlyCollection<Maybe<Entity>> ToEntities(this IEnumerable<Highlighted> highlighters);
```

## Parameters

__highlighters__ : `IEnumerable<Highlighted>`

The collection\.

## Return Value

`ReadOnlyCollection<Maybe<Entity>>`

An immutable array\.

