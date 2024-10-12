# ToSelectors\(IEnumerable\<Entity\>\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Creates an `ReadOnlyCollection<T>` where each element has been converted\.

```csharp
public static ReadOnlyCollection<Maybe<Selected>> ToSelectors(this IEnumerable<Entity> entities);
```

## Parameters

__entities__ : `IEnumerable<Entity>`

The collection\.

## Return Value

`ReadOnlyCollection<Maybe<Selected>>`

An immutable array\.

