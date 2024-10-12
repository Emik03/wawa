# Add\(Selected, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Adds the parameter values to the corresponding hooks, when applicable\.

```csharp
public static Selected Add(this Selected that ,Action onCancel = null ,Action onDefocus = null ,Action onDeselect = null ,Action onFocus = null ,Action onHighlight = null ,Action onHighlightEnded = null ,Action onInteract = null ,Action onInteractEnded = null ,Action onLeft = null ,Action onRight = null ,Action onSelect = null ,Action onUpdateChildren = null);
```

## Parameters

__that__ : [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)

This instance of [Selected](../../../wawa.Recall/wawa.Recall/Selected.md)\.

__onCancel__ : `Action`

Invoked when the player backs out of the selectable\.

__onDefocus__ : `Action`

Invoked when the selectable is defocused\.

__onDeselect__ : `Action`

Invoked when this stops being the current selectable\.

__onFocus__ : `Action`

Invoked when the selectable is focused\.

__onHighlight__ : `Action`

Invoked whenever the highlight is turned on\.

__onHighlightEnded__ : `Action`

Invoked whenever the highlight is turned off\.

__onInteract__ : `Action`

Invoked when the player interacts with the selectable\.

__onInteractEnded__ : `Action`

Invoked when the player releases the mouse or controller button\.

__onLeft__ : `Action`

Invoked when the player pulls the selection stick left while selected\.

__onRight__ : `Action`

Invoked when the player pulls the selection stick right while selected\.

__onSelect__ : `Action`

Invoked when this becomes the current selectable\.

__onUpdateChildren__ : `Action`

Invoked when the list of children are updated\.

## Return Value

[Selected](../../../wawa.Recall/wawa.Recall/Selected.md)

The parameter `that`\.

