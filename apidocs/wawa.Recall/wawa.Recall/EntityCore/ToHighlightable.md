# ToHighlightable\(Entity\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Gets the [Highlighted](../../../wawa.Recall/wawa.Recall/Highlighted.md) of this [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)\.
An empty value is given if there is no attached [Selected](../../../wawa.Recall/wawa.Recall/Selected.md) on the [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)\.

```csharp
public static Maybe<Highlighted> ToHighlightable(this Entity that);
```

## Parameters

__that__ : [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)

This instance of [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)\.

## Return Value

[Maybe\<Highlighted\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

A [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md), consisting of either a [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)
that is attached to this instance, or `default`\.

