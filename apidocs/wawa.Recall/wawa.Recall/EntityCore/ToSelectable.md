# ToSelectable\(Entity\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Gets the [Selected](../../../wawa.Recall/wawa.Recall/Selected.md) of this [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)\.
An empty value is given if there is no attached [Selected](../../../wawa.Recall/wawa.Recall/Selected.md) on the [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)\.

```csharp
public static Maybe<Selected> ToSelectable(this Entity entity);
```

## Parameters

__entity__ : [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)

This instance of [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)\.

## Return Value

[Maybe\<Selected\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

A [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md), consisting of either a [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)
that is attached to this instance, or `default`\.

