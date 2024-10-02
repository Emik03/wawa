### [wawa.Extensions](wawa.Extensions.md 'wawa.Extensions').[KMExtensions](KMExtensions.md 'wawa.Extensions.KMExtensions')

## KMExtensions.Notify<T>(this T, KMSelectable[]) Method

Notifies the game that the children list has been updated.

```csharp
public static T Notify<T>(this T selectables, params KMSelectable[] childrenToSelect)
    where T : System.Collections.Generic.IEnumerable<KMSelectable>;
```
#### Type parameters

<a name='wawa.Extensions.KMExtensions.Notify_T_(thisT,KMSelectable[]).T'></a>

`T`

The type of [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') containing [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') instances.
#### Parameters

<a name='wawa.Extensions.KMExtensions.Notify_T_(thisT,KMSelectable[]).selectables'></a>

`selectables` [T](KMExtensions.Notify{T}(T,KMSelectable[]).md#wawa.Extensions.KMExtensions.Notify_T_(thisT,KMSelectable[]).T 'wawa.Extensions.KMExtensions.Notify<T>(this T, KMSelectable[]).T')

The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') of [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') instances to update its children.

<a name='wawa.Extensions.KMExtensions.Notify_T_(thisT,KMSelectable[]).childrenToSelect'></a>

`childrenToSelect` [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of children [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') to force selections on, if specified.

#### Returns
[T](KMExtensions.Notify{T}(T,KMSelectable[]).md#wawa.Extensions.KMExtensions.Notify_T_(thisT,KMSelectable[]).T 'wawa.Extensions.KMExtensions.Notify<T>(this T, KMSelectable[]).T')  
The parameter [selectables](KMExtensions.Notify{T}(T,KMSelectable[]).md#wawa.Extensions.KMExtensions.Notify_T_(thisT,KMSelectable[]).selectables 'wawa.Extensions.KMExtensions.Notify<T>(this T, KMSelectable[]).selectables').

### Remarks
  
This is a swap-in replacement for [KMSelectable.UpdateChildren(KMSelectable)](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable.UpdateChildren#KMSelectable_UpdateChildren_KMSelectable_ 'KMSelectable.UpdateChildren(KMSelectable)'),  
since that method only works in the editor.