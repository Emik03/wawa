### [Wawa.Extensions](Wawa.Extensions.md 'Wawa.Extensions').[KMExtensions](KMExtensions.md 'Wawa.Extensions.KMExtensions')

## KMExtensions.Notify(this KMSelectable, KMSelectable) Method

Notifies the game that the children list has been updated.

```csharp
public static KMSelectable Notify(this KMSelectable selectable, KMSelectable childrenToSelect=null);
```
#### Parameters

<a name='Wawa.Extensions.KMExtensions.Notify(thisKMSelectable,KMSelectable).selectable'></a>

`selectable` [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')

The [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') to update its children.

<a name='Wawa.Extensions.KMExtensions.Notify(thisKMSelectable,KMSelectable).childrenToSelect'></a>

`childrenToSelect` [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')

The child [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') to force a selection on, if specified.

#### Returns
[KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')  
The parameter [selectable](KMExtensions.Notify(KMSelectable,KMSelectable).md#Wawa.Extensions.KMExtensions.Notify(thisKMSelectable,KMSelectable).selectable 'Wawa.Extensions.KMExtensions.Notify(this KMSelectable, KMSelectable).selectable').

### Remarks
  
This is a swap-in replacement for [KMSelectable.UpdateChildren(KMSelectable)](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable.UpdateChildren#KMSelectable_UpdateChildren_KMSelectable_ 'KMSelectable.UpdateChildren(KMSelectable)'),  
since that method only works in the editor.