### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[SelectedCore](SelectedCore.md 'wawa.Recall.SelectedCore')

## SelectedCore.AddRaw(this Selected, Func<bool>, Func<bool>, Action<KMSelectable>) Method

Removes the parameter values to the corresponding hooks, when applicable.

```csharp
public static wawa.Recall.Selected AddRaw(this wawa.Recall.Selected that, System.Func<bool> onCancel=null, System.Func<bool> onInteract=null, System.Action<KMSelectable> onUpdateChildren=null);
```
#### Parameters

<a name='wawa.Recall.SelectedCore.AddRaw(thiswawa.Recall.Selected,System.Func_bool_,System.Func_bool_,System.Action_KMSelectable_).that'></a>

`that` [Selected](Selected.md 'wawa.Recall.Selected')

This instance of [Selected](Selected.md 'wawa.Recall.Selected').

<a name='wawa.Recall.SelectedCore.AddRaw(thiswawa.Recall.Selected,System.Func_bool_,System.Func_bool_,System.Action_KMSelectable_).onCancel'></a>

`onCancel` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Invoked when the player backs out of the selectable.

<a name='wawa.Recall.SelectedCore.AddRaw(thiswawa.Recall.Selected,System.Func_bool_,System.Func_bool_,System.Action_KMSelectable_).onInteract'></a>

`onInteract` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Invoked when the player interacts with the selectable.

<a name='wawa.Recall.SelectedCore.AddRaw(thiswawa.Recall.Selected,System.Func_bool_,System.Func_bool_,System.Action_KMSelectable_).onUpdateChildren'></a>

`onUpdateChildren` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Invoked when the list of children are updated.

#### Returns
[Selected](Selected.md 'wawa.Recall.Selected')  
The parameter [that](SelectedCore.AddRaw(Selected,Func{bool},Func{bool},Action{KMSelectable}).md#wawa.Recall.SelectedCore.AddRaw(thiswawa.Recall.Selected,System.Func_bool_,System.Func_bool_,System.Action_KMSelectable_).that 'wawa.Recall.SelectedCore.AddRaw(this wawa.Recall.Selected, System.Func<bool>, System.Func<bool>, System.Action<KMSelectable>).that').