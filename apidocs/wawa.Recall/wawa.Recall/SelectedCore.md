# SelectedCore Class

namespace: [wawa\.Recall](../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../wawa.Recall.md)

Implementations for [Selected](../../wawa.Recall/wawa.Recall/Selected.md)\.

```csharp
public static class SelectedCore;
```

Inheritance: `object` > SelectedCore

## Methods

| Name | Summary |
|------|---------|
| [ToEntity\(Selected\)](./SelectedCore/ToEntity.md) | Gets the [Entity](../../wawa.Recall/wawa.Recall/Entity.md) of this [Selected](../../wawa.Recall/wawa.Recall/Selected.md)\.An empty value is given if there is no attached [Entity](../../wawa.Recall/wawa.Recall/Entity.md) on the [Selected](../../wawa.Recall/wawa.Recall/Selected.md)\. |
| [AsSelectable\(KMSelectable\)](./SelectedCore/AsSelectable.md) | Creates an instance of [Entity](../../wawa.Recall/wawa.Recall/Entity.md) where [Solvable](../../wawa.Recall/wawa.Recall/Entity/Solvable.md) is set\. |
| [Add\(Selected, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action\)](./SelectedCore/Add.md) | Adds the parameter values to the corresponding hooks, when applicable\. |
| [Remove\(Selected, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action\)](./SelectedCore/Remove.md) | Removes the parameter values to the corresponding hooks, when applicable\. |
| [Set\(Selected, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action\)](./SelectedCore/Set.md) | Sets the parameter values to the corresponding hooks, when applicable\. |
| [AddRaw\(Selected, Func\<bool\>, Func\<bool\>, Action\<KMSelectable\>\)](./SelectedCore/AddRaw.md) | Removes the parameter values to the corresponding hooks, when applicable\. |
| [RemoveRaw\(Selected, Func\<bool\>, Func\<bool\>, Action\<KMSelectable\>\)](./SelectedCore/RemoveRaw.md) | Removes the parameter values to the corresponding hooks, when applicable\. |
| [SetRaw\(Selected, Func\<bool\>, Func\<bool\>, Action\<KMSelectable\>\)](./SelectedCore/SetRaw.md) | Sets the parameter values to the corresponding hooks, when applicable\. |
| [Log\(Selected\)](./SelectedCore/Log.md) | Hooks the logger to each instance\. |
| [Log\(IEnumerable\<Selected\>\)](./SelectedCore/Log.md) | Hooks the logger to each instance\. |
| [Log\(IEnumerable\<Maybe\<Selected\>\>\)](./SelectedCore/Log.md) | Hooks the logger to each instance\. |
| [ToEntities\(IEnumerable\<Selected\>\)](./SelectedCore/ToEntities.md) | Creates an `ReadOnlyCollection<T>` where each element has been converted\. |
| [ToSelectables\(IEnumerable\<KMSelectable\>\)](./SelectedCore/ToSelectables.md) | Creates an `ReadOnlyCollection<T>` where each element has been converted\. |

