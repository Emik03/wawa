# ToEntity\(Selected\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Gets the [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) of this [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)\.
An empty value is given if there is no attached [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) on the [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)\.

```csharp
public static Maybe<Entity> ToEntity(this Selected that);
```

## Parameters

__that__ : [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)

This instance of [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)\.

## Return Value

[Maybe\<Entity\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

A [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md), consisting of either a [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)
that is attached to this instance, or `default`\.

