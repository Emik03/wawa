### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[SelectedCore](SelectedCore.md 'Wawa.Recall.SelectedCore')

## SelectedCore.Add(this Selected, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action) Method

Adds the parameter values to the corresponding hooks, when applicable.

```csharp
public static Wawa.Recall.Selected Add(this Wawa.Recall.Selected that, System.Action onCancel=null, System.Action onDefocus=null, System.Action onDeselect=null, System.Action onFocus=null, System.Action onHighlight=null, System.Action onHighlightEnded=null, System.Action onInteract=null, System.Action onInteractEnded=null, System.Action onLeft=null, System.Action onRight=null, System.Action onSelect=null, System.Action onUpdateChildren=null);
```
#### Parameters

<a name='Wawa.Recall.SelectedCore.Add(thisWawa.Recall.Selected,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).that'></a>

`that` [Selected](Selected.md 'Wawa.Recall.Selected')

This instance of [Selected](Selected.md 'Wawa.Recall.Selected').

<a name='Wawa.Recall.SelectedCore.Add(thisWawa.Recall.Selected,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onCancel'></a>

`onCancel` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked when the player backs out of the selectable.

<a name='Wawa.Recall.SelectedCore.Add(thisWawa.Recall.Selected,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onDefocus'></a>

`onDefocus` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked when the selectable is defocused.

<a name='Wawa.Recall.SelectedCore.Add(thisWawa.Recall.Selected,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onDeselect'></a>

`onDeselect` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked when this stops being the current selectable.

<a name='Wawa.Recall.SelectedCore.Add(thisWawa.Recall.Selected,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onFocus'></a>

`onFocus` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked when the selectable is focused.

<a name='Wawa.Recall.SelectedCore.Add(thisWawa.Recall.Selected,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onHighlight'></a>

`onHighlight` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked whenever the highlight is turned on.

<a name='Wawa.Recall.SelectedCore.Add(thisWawa.Recall.Selected,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onHighlightEnded'></a>

`onHighlightEnded` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked whenever the highlight is turned off.

<a name='Wawa.Recall.SelectedCore.Add(thisWawa.Recall.Selected,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onInteract'></a>

`onInteract` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked when the player interacts with the selectable.

<a name='Wawa.Recall.SelectedCore.Add(thisWawa.Recall.Selected,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onInteractEnded'></a>

`onInteractEnded` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked when the player releases the mouse or controller button.

<a name='Wawa.Recall.SelectedCore.Add(thisWawa.Recall.Selected,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onLeft'></a>

`onLeft` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked when the player pulls the selection stick left while selected.

<a name='Wawa.Recall.SelectedCore.Add(thisWawa.Recall.Selected,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onRight'></a>

`onRight` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked when the player pulls the selection stick right while selected.

<a name='Wawa.Recall.SelectedCore.Add(thisWawa.Recall.Selected,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onSelect'></a>

`onSelect` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked when this becomes the current selectable.

<a name='Wawa.Recall.SelectedCore.Add(thisWawa.Recall.Selected,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onUpdateChildren'></a>

`onUpdateChildren` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Invoked when the list of children are updated.

#### Returns
[Selected](Selected.md 'Wawa.Recall.Selected')  
The parameter [that](SelectedCore.Add(Selected,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action).md#Wawa.Recall.SelectedCore.Add(thisWawa.Recall.Selected,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).that 'Wawa.Recall.SelectedCore.Add(this Wawa.Recall.Selected, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action).that').