### [wawa.Extensions](wawa.Extensions.md 'wawa.Extensions').[KMExtensions](KMExtensions.md 'wawa.Extensions.KMExtensions')

## KMExtensions.Notify<T,TChild>(this T, TChild) Method

Notifies the game that the children list has been updated.

```csharp
public static T Notify<T,TChild>(this T selectables, TChild childrenToSelect)
    where T : System.Collections.Generic.IEnumerable<KMSelectable>
    where TChild : System.Collections.Generic.IEnumerable<KMSelectable>;
```
#### Type parameters

<a name='wawa.Extensions.KMExtensions.Notify_T,TChild_(thisT,TChild).T'></a>

`T`

The type of [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') containing [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') instances.

<a name='wawa.Extensions.KMExtensions.Notify_T,TChild_(thisT,TChild).TChild'></a>

`TChild`

The type of [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') containing child [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') instances.
#### Parameters

<a name='wawa.Extensions.KMExtensions.Notify_T,TChild_(thisT,TChild).selectables'></a>

`selectables` [T](KMExtensions.Notify{T,TChild}(T,TChild).md#wawa.Extensions.KMExtensions.Notify_T,TChild_(thisT,TChild).T 'wawa.Extensions.KMExtensions.Notify<T,TChild>(this T, TChild).T')

The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') of [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') instances to update its children.  
<p/>`[ItemNotNull]`

<a name='wawa.Extensions.KMExtensions.Notify_T,TChild_(thisT,TChild).childrenToSelect'></a>

`childrenToSelect` [TChild](KMExtensions.Notify{T,TChild}(T,TChild).md#wawa.Extensions.KMExtensions.Notify_T,TChild_(thisT,TChild).TChild 'wawa.Extensions.KMExtensions.Notify<T,TChild>(this T, TChild).TChild')

The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') of children [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') to force selections on, if specified.

#### Returns
[T](KMExtensions.Notify{T,TChild}(T,TChild).md#wawa.Extensions.KMExtensions.Notify_T,TChild_(thisT,TChild).T 'wawa.Extensions.KMExtensions.Notify<T,TChild>(this T, TChild).T')  
The parameter [selectables](KMExtensions.Notify{T,TChild}(T,TChild).md#wawa.Extensions.KMExtensions.Notify_T,TChild_(thisT,TChild).selectables 'wawa.Extensions.KMExtensions.Notify<T,TChild>(this T, TChild).selectables').

### Remarks
  
This is a swap-in replacement for [KMSelectable.UpdateChildren(KMSelectable)](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable.UpdateChildren#KMSelectable_UpdateChildren_KMSelectable_ 'KMSelectable.UpdateChildren(KMSelectable)'),  
since that method only works in the editor.