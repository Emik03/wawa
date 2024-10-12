# ToEntity\(Highlighted\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Gets the [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) of this [Highlighted](../../../wawa.Recall/wawa.Recall/Highlighted.md)\.
An empty value is given if there is no attached [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) on the [Highlighted](../../../wawa.Recall/wawa.Recall/Highlighted.md)\.

```csharp
public static Maybe<Entity> ToEntity(this Highlighted highlighted);
```

## Parameters

__highlighted__ : [Highlighted](../../../wawa.Recall/wawa.Recall/Highlighted.md)

This instance of [Highlighted](../../../wawa.Recall/wawa.Recall/Highlighted.md)\.

## Return Value

[Maybe\<Entity\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

A [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md), consisting of either a [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)
that is attached to this instance, or `default`\.

