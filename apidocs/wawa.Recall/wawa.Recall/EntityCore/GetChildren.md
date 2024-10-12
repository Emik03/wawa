# GetChildren\(GameObject\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Gets all modules that are children of a provided `GameObject`\.

```csharp
public static ReadOnlyCollection<Entity> GetChildren(this GameObject gameObject);
```

## Parameters

__gameObject__ : `GameObject`

The `GameObject` to get the modules from\.

## Return Value

`ReadOnlyCollection<Entity>`

A `ReadOnlyCollection<T>` of type [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)
which contains every module from `gameObject`\.

