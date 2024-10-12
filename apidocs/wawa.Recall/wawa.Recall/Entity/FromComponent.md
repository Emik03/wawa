# FromComponent\(UnityEngine\.Component\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Gets the [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) of this `UnityEngine.Component`\.
An empty value is given if there is no attached [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) on the `UnityEngine.Component`\.

```csharp
public static Maybe<Entity> FromComponent(UnityEngine.Component component);
```

## Parameters

__component__ : `UnityEngine.Component`

The `UnityEngine.Component` to find components, by using `Component.GetComponent<T>`\.


## Return Value

[Maybe\<Entity\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

A [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md), consisting of either a [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)
that is attached to this instance, or `default`\.

