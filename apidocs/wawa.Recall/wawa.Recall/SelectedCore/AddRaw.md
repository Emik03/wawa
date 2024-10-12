# AddRaw\(Selected, Func\<bool\>, Func\<bool\>, Action\<KMSelectable\>\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Removes the parameter values to the corresponding hooks, when applicable\.

```csharp
public static Selected AddRaw(this Selected that ,Func<bool> onCancel = null ,Func<bool> onInteract = null ,Action<KMSelectable> onUpdateChildren = null);
```

## Parameters

__that__ : [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)

This instance of [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)\.

__onCancel__ : `Func<bool>`

Invoked when the player backs out of the selectable\.

__onInteract__ : `Func<bool>`

Invoked when the player interacts with the selectable\.

__onUpdateChildren__ : `Action<KMSelectable>`

Invoked when the list of children are updated\.

## Return Value

[Selected](../../../wawa.Recall/wawa.Recall/Selected.md)

The parameter `that`\.

