### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks')

## SelectedCore Class

Implementations for [Selected](Selected.md 'Wawa.Callbacks.Selected').

```csharp
public static class SelectedCore
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SelectedCore

| Methods | |
| :--- | :--- |
| [Add(this Selected, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action)](SelectedCore.Add(Selected,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action).md 'Wawa.Callbacks.SelectedCore.Add(this Wawa.Callbacks.Selected, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action)') | Adds the parameter values to the corresponding hooks, when applicable. |
| [Add(this Selected, Func&lt;bool&gt;, Func&lt;bool&gt;, Action&lt;KMSelectable&gt;)](SelectedCore.Add(Selected,Func{bool},Func{bool},Action{KMSelectable}).md 'Wawa.Callbacks.SelectedCore.Add(this Wawa.Callbacks.Selected, System.Func<bool>, System.Func<bool>, System.Action<KMSelectable>)') | Removes the parameter values to the corresponding hooks, when applicable. |
| [AsSelectable(this KMSelectable)](SelectedCore.AsSelectable(KMSelectable).md 'Wawa.Callbacks.SelectedCore.AsSelectable(this KMSelectable)') | Creates an instance of [Entity](Entity.md 'Wawa.Callbacks.Entity') where [Solvable](Entity.Solvable.md 'Wawa.Callbacks.Entity.Solvable') is set. |
| [Log(this IEnumerable&lt;Selected&gt;)](SelectedCore.Log(IEnumerable{Selected}).md 'Wawa.Callbacks.SelectedCore.Log(this System.Collections.Generic.IEnumerable<Wawa.Callbacks.Selected>)') | Hooks the logger to each instance. |
| [Log(this Selected)](SelectedCore.Log(Selected).md 'Wawa.Callbacks.SelectedCore.Log(this Wawa.Callbacks.Selected)') | Hooks the logger to each instance. |
| [Remove(this Selected, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action)](SelectedCore.Remove(Selected,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action).md 'Wawa.Callbacks.SelectedCore.Remove(this Wawa.Callbacks.Selected, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action)') | Adds the parameter values to the corresponding hooks, when applicable. |
| [Remove(this Selected, Func&lt;bool&gt;, Func&lt;bool&gt;, Action&lt;KMSelectable&gt;)](SelectedCore.Remove(Selected,Func{bool},Func{bool},Action{KMSelectable}).md 'Wawa.Callbacks.SelectedCore.Remove(this Wawa.Callbacks.Selected, System.Func<bool>, System.Func<bool>, System.Action<KMSelectable>)') | Removes the parameter values to the corresponding hooks, when applicable. |
| [Set(this Selected, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action)](SelectedCore.Set(Selected,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action).md 'Wawa.Callbacks.SelectedCore.Set(this Wawa.Callbacks.Selected, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action)') | Adds the parameter values to the corresponding hooks, when applicable. |
| [Set(Selected, Func&lt;bool&gt;, Func&lt;bool&gt;, Action&lt;KMSelectable&gt;)](SelectedCore.Set(Selected,Func{bool},Func{bool},Action{KMSelectable}).md 'Wawa.Callbacks.SelectedCore.Set(Wawa.Callbacks.Selected, System.Func<bool>, System.Func<bool>, System.Action<KMSelectable>)') | Removes the parameter values to the corresponding hooks, when applicable. |
| [ToEntities(this IEnumerable&lt;Selected&gt;)](SelectedCore.ToEntities(IEnumerable{Selected}).md 'Wawa.Callbacks.SelectedCore.ToEntities(this System.Collections.Generic.IEnumerable<Wawa.Callbacks.Selected>)') | Creates an [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
| [ToEntity(this Selected)](SelectedCore.ToEntity(Selected).md 'Wawa.Callbacks.SelectedCore.ToEntity(this Wawa.Callbacks.Selected)') | Gets the [Entity](Entity.md 'Wawa.Callbacks.Entity') of this [Selected](Selected.md 'Wawa.Callbacks.Selected').<br/>An empty value is given if there is no attached [Entity](Entity.md 'Wawa.Callbacks.Entity') on the [Selected](Selected.md 'Wawa.Callbacks.Selected'). |
| [ToSelectables(this IEnumerable&lt;KMSelectable&gt;)](SelectedCore.ToSelectables(IEnumerable{KMSelectable}).md 'Wawa.Callbacks.SelectedCore.ToSelectables(this System.Collections.Generic.IEnumerable<KMSelectable>)') | Creates an [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
