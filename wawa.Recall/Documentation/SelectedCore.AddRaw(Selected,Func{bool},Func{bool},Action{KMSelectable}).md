### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[SelectedCore](SelectedCore.md 'Wawa.Recall.SelectedCore')

## SelectedCore.AddRaw(this Selected, Func<bool>, Func<bool>, Action<KMSelectable>) Method

Removes the parameter values to the corresponding hooks, when applicable.

```csharp
public static Wawa.Recall.Selected AddRaw(this Wawa.Recall.Selected that, System.Func<bool> onCancel=null, System.Func<bool> onInteract=null, System.Action<KMSelectable> onUpdateChildren=null);
```
#### Parameters

<a name='Wawa.Recall.SelectedCore.AddRaw(thisWawa.Recall.Selected,System.Func_bool_,System.Func_bool_,System.Action_KMSelectable_).that'></a>

`that` [Selected](Selected.md 'Wawa.Recall.Selected')

This instance of [Selected](Selected.md 'Wawa.Recall.Selected').

<a name='Wawa.Recall.SelectedCore.AddRaw(thisWawa.Recall.Selected,System.Func_bool_,System.Func_bool_,System.Action_KMSelectable_).onCancel'></a>

`onCancel` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Invoked when the player backs out of the selectable.

<a name='Wawa.Recall.SelectedCore.AddRaw(thisWawa.Recall.Selected,System.Func_bool_,System.Func_bool_,System.Action_KMSelectable_).onInteract'></a>

`onInteract` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Invoked when the player interacts with the selectable.

<a name='Wawa.Recall.SelectedCore.AddRaw(thisWawa.Recall.Selected,System.Func_bool_,System.Func_bool_,System.Action_KMSelectable_).onUpdateChildren'></a>

`onUpdateChildren` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Invoked when the list of children are updated.

#### Returns
[Selected](Selected.md 'Wawa.Recall.Selected')  
The parameter [that](SelectedCore.AddRaw(Selected,Func{bool},Func{bool},Action{KMSelectable}).md#Wawa.Recall.SelectedCore.AddRaw(thisWawa.Recall.Selected,System.Func_bool_,System.Func_bool_,System.Action_KMSelectable_).that 'Wawa.Recall.SelectedCore.AddRaw(this Wawa.Recall.Selected, System.Func<bool>, System.Func<bool>, System.Action<KMSelectable>).that').