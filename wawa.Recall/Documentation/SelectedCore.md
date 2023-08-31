### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall')

## SelectedCore Class

Implementations for [Selected](Selected.md 'Wawa.Recall.Selected').

```csharp
public static class SelectedCore
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SelectedCore

| Methods | |
| :--- | :--- |
| [Add(this Selected, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action)](SelectedCore.Add(Selected,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action).md 'Wawa.Recall.SelectedCore.Add(this Wawa.Recall.Selected, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action)') | Adds the parameter values to the corresponding hooks, when applicable. |
| [AddRaw(this Selected, Func&lt;bool&gt;, Func&lt;bool&gt;, Action&lt;KMSelectable&gt;)](SelectedCore.AddRaw(Selected,Func{bool},Func{bool},Action{KMSelectable}).md 'Wawa.Recall.SelectedCore.AddRaw(this Wawa.Recall.Selected, System.Func<bool>, System.Func<bool>, System.Action<KMSelectable>)') | Removes the parameter values to the corresponding hooks, when applicable. |
| [AsSelectable(this KMSelectable)](SelectedCore.AsSelectable(KMSelectable).md 'Wawa.Recall.SelectedCore.AsSelectable(this KMSelectable)') | Creates an instance of [Entity](Entity.md 'Wawa.Recall.Entity') where [Solvable](Entity.Solvable.md 'Wawa.Recall.Entity.Solvable') is set. |
| [Log(this IEnumerable&lt;Maybe&lt;Selected&gt;&gt;)](SelectedCore.Log(IEnumerable{Maybe{Selected}}).md 'Wawa.Recall.SelectedCore.Log(this System.Collections.Generic.IEnumerable<Wawa.Optionals.Maybe<Wawa.Recall.Selected>>)') | Hooks the logger to each instance. |
| [Log(this IEnumerable&lt;Selected&gt;)](SelectedCore.Log(IEnumerable{Selected}).md 'Wawa.Recall.SelectedCore.Log(this System.Collections.Generic.IEnumerable<Wawa.Recall.Selected>)') | Hooks the logger to each instance. |
| [Log(this Selected)](SelectedCore.Log(Selected).md 'Wawa.Recall.SelectedCore.Log(this Wawa.Recall.Selected)') | Hooks the logger to each instance. |
| [Remove(this Selected, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action)](SelectedCore.Remove(Selected,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action).md 'Wawa.Recall.SelectedCore.Remove(this Wawa.Recall.Selected, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action)') | Adds the parameter values to the corresponding hooks, when applicable. |
| [RemoveRaw(this Selected, Func&lt;bool&gt;, Func&lt;bool&gt;, Action&lt;KMSelectable&gt;)](SelectedCore.RemoveRaw(Selected,Func{bool},Func{bool},Action{KMSelectable}).md 'Wawa.Recall.SelectedCore.RemoveRaw(this Wawa.Recall.Selected, System.Func<bool>, System.Func<bool>, System.Action<KMSelectable>)') | Removes the parameter values to the corresponding hooks, when applicable. |
| [Set(this Selected, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action)](SelectedCore.Set(Selected,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action).md 'Wawa.Recall.SelectedCore.Set(this Wawa.Recall.Selected, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action)') | Adds the parameter values to the corresponding hooks, when applicable. |
| [SetRaw(Selected, Func&lt;bool&gt;, Func&lt;bool&gt;, Action&lt;KMSelectable&gt;)](SelectedCore.SetRaw(Selected,Func{bool},Func{bool},Action{KMSelectable}).md 'Wawa.Recall.SelectedCore.SetRaw(Wawa.Recall.Selected, System.Func<bool>, System.Func<bool>, System.Action<KMSelectable>)') | Removes the parameter values to the corresponding hooks, when applicable. |
| [ToEntities(this IEnumerable&lt;Selected&gt;)](SelectedCore.ToEntities(IEnumerable{Selected}).md 'Wawa.Recall.SelectedCore.ToEntities(this System.Collections.Generic.IEnumerable<Wawa.Recall.Selected>)') | Creates an [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
| [ToEntity(this Selected)](SelectedCore.ToEntity(Selected).md 'Wawa.Recall.SelectedCore.ToEntity(this Wawa.Recall.Selected)') | Gets the [Entity](Entity.md 'Wawa.Recall.Entity') of this [Selected](Selected.md 'Wawa.Recall.Selected').<br/>An empty value is given if there is no attached [Entity](Entity.md 'Wawa.Recall.Entity') on the [Selected](Selected.md 'Wawa.Recall.Selected'). |
| [ToSelectables(this IEnumerable&lt;KMSelectable&gt;)](SelectedCore.ToSelectables(IEnumerable{KMSelectable}).md 'Wawa.Recall.SelectedCore.ToSelectables(this System.Collections.Generic.IEnumerable<KMSelectable>)') | Creates an [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
