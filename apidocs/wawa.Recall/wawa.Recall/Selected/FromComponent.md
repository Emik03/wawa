# FromComponent\(UnityEngine\.Component\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Gets a new instance of [Selected](../../../wawa.Recall/wawa.Recall/Selected.md) based on
the first found selectable of the `UnityEngine.Component`\.

```csharp
public static Maybe<Selected> FromComponent(UnityEngine.Component component);
```

## Parameters

__component__ : `UnityEngine.Component`

The `UnityEngine.Component` to find components of using `Component.GetComponent<T>`\.


## Return Value

[Maybe\<Selected\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

A [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md), consisting of either a [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)
that is attached to this instance, or `default`\.

