### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks')

## EntityCore Class

Implementations for [Entity](Entity.md 'Wawa.Callbacks.Entity').

```csharp
public static class EntityCore
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EntityCore

| Methods | |
| :--- | :--- |
| [AsEntity(this KMBombModule)](EntityCore.AsEntity(KMBombModule).md 'Wawa.Callbacks.EntityCore.AsEntity(this KMBombModule)') | Creates an instance of [Entity](Entity.md 'Wawa.Callbacks.Entity') where [Solvable](Entity.Solvable.md 'Wawa.Callbacks.Entity.Solvable') is set. |
| [AsEntity(this KMNeedyModule)](EntityCore.AsEntity(KMNeedyModule).md 'Wawa.Callbacks.EntityCore.AsEntity(this KMNeedyModule)') | Creates an instance of [Entity](Entity.md 'Wawa.Callbacks.Entity') where [Needy](Entity.Needy.md 'Wawa.Callbacks.Entity.Needy') is set. |
| [GetChildren(this GameObject)](EntityCore.GetChildren(GameObject).md 'Wawa.Callbacks.EntityCore.GetChildren(this GameObject)') | Gets all modules that are children of a provided [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject'). |
| [ToEntities(this KMBomb)](EntityCore.ToEntities(KMBomb).md 'Wawa.Callbacks.EntityCore.ToEntities(this KMBomb)') | Gets all modules that are children of a provided [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb'). |
| [ToEntities(this IEnumerable&lt;KMBombModule&gt;)](EntityCore.ToEntities(IEnumerable{KMBombModule}).md 'Wawa.Callbacks.EntityCore.ToEntities(this System.Collections.Generic.IEnumerable<KMBombModule>)') | Creates an [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
| [ToEntities(this IEnumerable&lt;KMNeedyModule&gt;)](EntityCore.ToEntities(IEnumerable{KMNeedyModule}).md 'Wawa.Callbacks.EntityCore.ToEntities(this System.Collections.Generic.IEnumerable<KMNeedyModule>)') | Creates an [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
| [ToHighlightable(this Entity)](EntityCore.ToHighlightable(Entity).md 'Wawa.Callbacks.EntityCore.ToHighlightable(this Wawa.Callbacks.Entity)') | Gets the [Highlighted](Highlighted.md 'Wawa.Callbacks.Highlighted') of this [Entity](Entity.md 'Wawa.Callbacks.Entity').<br/>An empty value is given if there is no attached [Selected](Selected.md 'Wawa.Callbacks.Selected') on the [Entity](Entity.md 'Wawa.Callbacks.Entity'). |
| [ToHighlighters(this IEnumerable&lt;Entity&gt;)](EntityCore.ToHighlighters(IEnumerable{Entity}).md 'Wawa.Callbacks.EntityCore.ToHighlighters(this System.Collections.Generic.IEnumerable<Wawa.Callbacks.Entity>)') | Creates an [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
| [ToManyEntities(this IEnumerable&lt;KMBomb&gt;)](EntityCore.ToManyEntities(IEnumerable{KMBomb}).md 'Wawa.Callbacks.EntityCore.ToManyEntities(this System.Collections.Generic.IEnumerable<KMBomb>)') | Creates an [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
| [ToSelectable(this Entity)](EntityCore.ToSelectable(Entity).md 'Wawa.Callbacks.EntityCore.ToSelectable(this Wawa.Callbacks.Entity)') | Gets the [Selected](Selected.md 'Wawa.Callbacks.Selected') of this [Entity](Entity.md 'Wawa.Callbacks.Entity').<br/>An empty value is given if there is no attached [Selected](Selected.md 'Wawa.Callbacks.Selected') on the [Entity](Entity.md 'Wawa.Callbacks.Entity'). |
| [ToSelectors(this IEnumerable&lt;Entity&gt;)](EntityCore.ToSelectors(IEnumerable{Entity}).md 'Wawa.Callbacks.EntityCore.ToSelectors(this System.Collections.Generic.IEnumerable<Wawa.Callbacks.Entity>)') | Creates an [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
