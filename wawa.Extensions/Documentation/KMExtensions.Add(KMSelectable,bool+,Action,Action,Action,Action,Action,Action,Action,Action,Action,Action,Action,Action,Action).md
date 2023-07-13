### [Wawa.Extensions](Wawa.Extensions.md 'Wawa.Extensions').[KMExtensions](KMExtensions.md 'Wawa.Extensions.KMExtensions')

## KMExtensions.Add(this KMSelectable, Nullable<bool>, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action) Method

Adds specified delegate parameters into the [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable').

```csharp
public static KMSelectable Add(this KMSelectable selectable, System.Nullable<bool> isParent=null, System.Action onCancel=null, System.Action onDefocus=null, System.Action onDeselect=null, System.Action onFocus=null, System.Action onHighlight=null, System.Action onHighlightEnded=null, System.Action onInteract=null, System.Action onInteractEnded=null, System.Action onInteractionPunch=null, System.Action onLeft=null, System.Action onRight=null, System.Action onSelect=null, System.Action onUpdateChildren=null);
```
#### Parameters

<a name='Wawa.Extensions.KMExtensions.Add(thisKMSelectable,System.Nullable_bool_,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).selectable'></a>

`selectable` [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')

The [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') to hook.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMSelectable,System.Nullable_bool_,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).isParent'></a>

`isParent` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') value of [KMSelectable.OnCancel](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable.OnCancel 'KMSelectable.OnCancel')  
and [KMSelectable.OnInteract](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable.OnInteract 'KMSelectable.OnInteract').  
If [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), the value is evaluated at runtime to be [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if  
[KMSelectable.Children](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable.Children 'KMSelectable.Children') is a populated [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array'), and [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') otherwise.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMSelectable,System.Nullable_bool_,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onCancel'></a>

`onCancel` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when player backs out of this selectable.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMSelectable,System.Nullable_bool_,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onDefocus'></a>

`onDefocus` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when a different selectable becomes the focus, or the module has been backed out of.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMSelectable,System.Nullable_bool_,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onDeselect'></a>

`onDeselect` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the selectable stops being the current selectable.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMSelectable,System.Nullable_bool_,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onFocus'></a>

`onFocus` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when a module is focused, this is when it is interacted with from the bomb face level  
and its children can be selected.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMSelectable,System.Nullable_bool_,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onHighlight'></a>

`onHighlight` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the highlight is turned on.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMSelectable,System.Nullable_bool_,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onHighlightEnded'></a>

`onHighlightEnded` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the highlight is turned off.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMSelectable,System.Nullable_bool_,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onInteract'></a>

`onInteract` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when player interacts with the selectable.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMSelectable,System.Nullable_bool_,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onInteractEnded'></a>

`onInteractEnded` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when a player interacting with the selectable releases the mouse or controller button.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMSelectable,System.Nullable_bool_,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onInteractionPunch'></a>

`onInteractionPunch` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the interaction punch method is called.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMSelectable,System.Nullable_bool_,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onLeft'></a>

`onLeft` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the left controller stick is pulled while selected.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMSelectable,System.Nullable_bool_,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onRight'></a>

`onRight` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the right controller stick is pulled while selected.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMSelectable,System.Nullable_bool_,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onSelect'></a>

`onSelect` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called whenever the selectable becomes the current selectable.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMSelectable,System.Nullable_bool_,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onUpdateChildren'></a>

`onUpdateChildren` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the selectable updates its children.

#### Returns
[KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')  
The parameter [selectable](KMExtensions.Add(KMSelectable,bool+,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action).md#Wawa.Extensions.KMExtensions.Add(thisKMSelectable,System.Nullable_bool_,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).selectable 'Wawa.Extensions.KMExtensions.Add(this KMSelectable, System.Nullable<bool>, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action).selectable').