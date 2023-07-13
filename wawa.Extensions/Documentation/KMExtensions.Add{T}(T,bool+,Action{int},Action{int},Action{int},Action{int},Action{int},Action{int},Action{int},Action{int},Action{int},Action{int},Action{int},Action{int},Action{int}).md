### [Wawa.Extensions](Wawa.Extensions.md 'Wawa.Extensions').[KMExtensions](KMExtensions.md 'Wawa.Extensions.KMExtensions')

## KMExtensions.Add<T>(this T, Nullable<bool>, Action<int>, Action<int>, Action<int>, Action<int>, Action<int>, Action<int>, Action<int>, Action<int>, Action<int>, Action<int>, Action<int>, Action<int>, Action<int>) Method

Adds specified delegate parameters into the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') of [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') instances.  
An [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') is passed in the [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1') based on the index from the collection.

```csharp
public static T Add<T>(this T selectables, System.Nullable<bool> isParent=null, System.Action<int> onCancel=null, System.Action<int> onDefocus=null, System.Action<int> onDeselect=null, System.Action<int> onFocus=null, System.Action<int> onHighlight=null, System.Action<int> onHighlightEnded=null, System.Action<int> onInteract=null, System.Action<int> onInteractEnded=null, System.Action<int> onInteractionPunch=null, System.Action<int> onLeft=null, System.Action<int> onRight=null, System.Action<int> onSelect=null, System.Action<int> onUpdateChildren=null)
    where T : System.Collections.Generic.IEnumerable<KMSelectable>;
```
#### Type parameters

<a name='Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).T'></a>

`T`

The type of [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') containing [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') instances.
#### Parameters

<a name='Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).selectables'></a>

`selectables` [T](KMExtensions.Add{T}(T,bool+,Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int}).md#Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).T 'Wawa.Extensions.KMExtensions.Add<T>(this T, System.Nullable<bool>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>).T')

The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') of [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') instances to hook.

<a name='Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).isParent'></a>

`isParent` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') value of [KMSelectable.OnCancel](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable.OnCancel 'KMSelectable.OnCancel')  
and [KMSelectable.OnInteract](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable.OnInteract 'KMSelectable.OnInteract').  
If [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), the value is evaluated at runtime to be [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if  
[KMSelectable.Children](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable.Children 'KMSelectable.Children') is a populated [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array'), and [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') otherwise.

<a name='Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).onCancel'></a>

`onCancel` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Called when player backs out of this selectable.

<a name='Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).onDefocus'></a>

`onDefocus` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Called when a different selectable becomes the focus, or the module has been backed out of.

<a name='Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).onDeselect'></a>

`onDeselect` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Called when the selectable stops being the current selectable.

<a name='Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).onFocus'></a>

`onFocus` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Called when a module is focused, this is when it is interacted with from the bomb face level  
and its children can be selected.

<a name='Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).onHighlight'></a>

`onHighlight` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Called when the highlight is turned on.

<a name='Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).onHighlightEnded'></a>

`onHighlightEnded` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Called when the highlight is turned off.

<a name='Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).onInteract'></a>

`onInteract` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Called when player interacts with the selectable.

<a name='Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).onInteractEnded'></a>

`onInteractEnded` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Called when a player interacting with the selectable releases the mouse or controller button.

<a name='Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).onInteractionPunch'></a>

`onInteractionPunch` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Called when the interaction punch method is called.

<a name='Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).onLeft'></a>

`onLeft` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Called when the left controller stick is pulled while selected.

<a name='Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).onRight'></a>

`onRight` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Called when the right controller stick is pulled while selected.

<a name='Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).onSelect'></a>

`onSelect` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Called whenever the selectable becomes the current selectable.

<a name='Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).onUpdateChildren'></a>

`onUpdateChildren` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Called when the selectable updates its children.

#### Returns
[T](KMExtensions.Add{T}(T,bool+,Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int}).md#Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).T 'Wawa.Extensions.KMExtensions.Add<T>(this T, System.Nullable<bool>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>).T')  
The parameter [selectables](KMExtensions.Add{T}(T,bool+,Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int},Action{int}).md#Wawa.Extensions.KMExtensions.Add_T_(thisT,System.Nullable_bool_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_,System.Action_int_).selectables 'Wawa.Extensions.KMExtensions.Add<T>(this T, System.Nullable<bool>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>, System.Action<int>).selectables').