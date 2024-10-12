# ToHighlighters\(IEnumerable\<Entity\>\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Creates an `ReadOnlyCollection<T>` where each element has been converted\.

```csharp
public static ReadOnlyCollection<Maybe<Highlighted>> ToHighlighters(this IEnumerable<Entity> entities);
```

## Parameters

__entities__ : `IEnumerable<Entity>`

The collection\.

## Return Value

`ReadOnlyCollection<Maybe<Highlighted>>`

An immutable array\.

