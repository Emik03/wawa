# EntityCore Class

namespace: [wawa\.Recall](../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../wawa.Recall.md)

Implementations for [Entity](../../wawa.Recall/wawa.Recall/Entity.md)\.

```csharp
public static class EntityCore;
```

Inheritance: `object` > EntityCore

## Methods

| Name | Summary |
|------|---------|
| [AsEntity\(KMBombModule\)](./EntityCore/AsEntity.md) | Creates an instance of [Entity](../../wawa.Recall/wawa.Recall/Entity.md) where [Solvable](../../wawa.Recall/wawa.Recall/Entity/Solvable.md) is set\. |
| [AsEntity\(KMNeedyModule\)](./EntityCore/AsEntity.md) | Creates an instance of [Entity](../../wawa.Recall/wawa.Recall/Entity.md) where [Needy](../../wawa.Recall/wawa.Recall/Entity/Needy.md) is set\. |
| [Add\(Entity, Action, Action, Action, Action, Action, Action, Action, Action, Action\)](./EntityCore/Add.md) | Adds the parameter values to the corresponding hooks, when applicable\. |
| [Change\(Entity, StatusLights\)](./EntityCore/Change.md) | Alters the status light to `lights`\. |
| [FakeStrike\(Entity\)](./EntityCore/FakeStrike.md) | Plays the strike sound effect and flashes the status light red, without registering a strike\. |
| [Set\(Entity, Action, Action, Action, Action, Action, Action, Action, Action, Action\)](./EntityCore/Set.md) | Sets the parameter values to the corresponding hooks, when applicable\. |
| [Remove\(Entity, Action, Action, Action, Action, Action, Action, Action, Action, Action\)](./EntityCore/Remove.md) | Removes the parameter values to the corresponding hooks, when applicable\. |
| [AddRaw\(Entity, Func\<float\>, Action\<float\>, Func\<int\>, Func\<bool\>, Func\<bool\>\)](./EntityCore/AddRaw.md) | Adds the parameter values to the corresponding hooks, when applicable\. |
| [RemoveRaw\(Entity, Func\<float\>, Action\<float\>, Func\<int\>, Func\<bool\>, Func\<bool\>\)](./EntityCore/RemoveRaw.md) | Removes the parameter values to the corresponding hooks, when applicable\. |
| [SetRaw\(Entity, Func\<float\>, Action\<float\>, Func\<int\>, Func\<bool\>, Func\<bool\>\)](./EntityCore/SetRaw.md) | Sets the parameter values to the corresponding hooks, when applicable\. |
| [Log\(Entity\)](./EntityCore/Log.md) | Hooks the logger to each instance\. |
| [Log\(IEnumerable\<Entity\>\)](./EntityCore/Log.md) | Hooks the logger to each instance\. |
| [Log\(IEnumerable\<Maybe\<Entity\>\>\)](./EntityCore/Log.md) | Hooks the logger to each instance\. |
| [ToHighlightable\(Entity\)](./EntityCore/ToHighlightable.md) | Gets the [Highlighted](../../wawa.Recall/wawa.Recall/Highlighted.md) of this [Entity](../../wawa.Recall/wawa.Recall/Entity.md)\.An empty value is given if there is no attached [Selected](../../wawa.Recall/wawa.Recall/Selected.md) on the [Entity](../../wawa.Recall/wawa.Recall/Entity.md)\. |
| [ToSelectable\(Entity\)](./EntityCore/ToSelectable.md) | Gets the [Selected](../../wawa.Recall/wawa.Recall/Selected.md) of this [Entity](../../wawa.Recall/wawa.Recall/Entity.md)\.An empty value is given if there is no attached [Selected](../../wawa.Recall/wawa.Recall/Selected.md) on the [Entity](../../wawa.Recall/wawa.Recall/Entity.md)\. |
| [GetChildren\(GameObject\)](./EntityCore/GetChildren.md) | Gets all modules that are children of a provided `GameObject`\. |
| [ToEntities\(KMBomb\)](./EntityCore/ToEntities.md) | Gets all modules that are children of a provided `KMBomb`\. |
| [ToEntities\(IEnumerable\<KMBombModule\>\)](./EntityCore/ToEntities.md) | Creates an `ReadOnlyCollection<T>` where each element has been converted\. |
| [ToEntities\(IEnumerable\<KMNeedyModule\>\)](./EntityCore/ToEntities.md) | Creates an `ReadOnlyCollection<T>` where each element has been converted\. |
| [ToHighlighters\(IEnumerable\<Entity\>\)](./EntityCore/ToHighlighters.md) | Creates an `ReadOnlyCollection<T>` where each element has been converted\. |
| [ToSelectors\(IEnumerable\<Entity\>\)](./EntityCore/ToSelectors.md) | Creates an `ReadOnlyCollection<T>` where each element has been converted\. |
| [ToManyEntities\(IEnumerable\<KMBomb\>\)](./EntityCore/ToManyEntities.md) | Creates an `ReadOnlyCollection<T>` where each element has been converted\. |

