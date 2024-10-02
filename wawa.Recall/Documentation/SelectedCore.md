### [wawa.Recall](wawa.Recall.md 'wawa.Recall')

## SelectedCore Class

Implementations for [Selected](Selected.md 'wawa.Recall.Selected').

```csharp
public static class SelectedCore
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SelectedCore

| Methods | |
| :--- | :--- |
| [Add(this Selected, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action)](SelectedCore.Add(Selected,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action).md 'wawa.Recall.SelectedCore.Add(this wawa.Recall.Selected, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action)') | Adds the parameter values to the corresponding hooks, when applicable. |
| [AddRaw(this Selected, Func&lt;bool&gt;, Func&lt;bool&gt;, Action&lt;KMSelectable&gt;)](SelectedCore.AddRaw(Selected,Func{bool},Func{bool},Action{KMSelectable}).md 'wawa.Recall.SelectedCore.AddRaw(this wawa.Recall.Selected, System.Func<bool>, System.Func<bool>, System.Action<KMSelectable>)') | Removes the parameter values to the corresponding hooks, when applicable. |
| [AsSelectable(this KMSelectable)](SelectedCore.AsSelectable(KMSelectable).md 'wawa.Recall.SelectedCore.AsSelectable(this KMSelectable)') | Creates an instance of [Entity](Entity.md 'wawa.Recall.Entity') where [Solvable](Entity.Solvable.md 'wawa.Recall.Entity.Solvable') is set. |
| [Log(this IEnumerable&lt;Maybe&lt;Selected&gt;&gt;)](SelectedCore.Log(IEnumerable{Maybe{Selected}}).md 'wawa.Recall.SelectedCore.Log(this System.Collections.Generic.IEnumerable<wawa.Optionals.Maybe<wawa.Recall.Selected>>)') | Hooks the logger to each instance. |
| [Log(this IEnumerable&lt;Selected&gt;)](SelectedCore.Log(IEnumerable{Selected}).md 'wawa.Recall.SelectedCore.Log(this System.Collections.Generic.IEnumerable<wawa.Recall.Selected>)') | Hooks the logger to each instance. |
| [Log(this Selected)](SelectedCore.Log(Selected).md 'wawa.Recall.SelectedCore.Log(this wawa.Recall.Selected)') | Hooks the logger to each instance. |
| [Remove(this Selected, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action)](SelectedCore.Remove(Selected,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action).md 'wawa.Recall.SelectedCore.Remove(this wawa.Recall.Selected, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action)') | Adds the parameter values to the corresponding hooks, when applicable. |
| [RemoveRaw(this Selected, Func&lt;bool&gt;, Func&lt;bool&gt;, Action&lt;KMSelectable&gt;)](SelectedCore.RemoveRaw(Selected,Func{bool},Func{bool},Action{KMSelectable}).md 'wawa.Recall.SelectedCore.RemoveRaw(this wawa.Recall.Selected, System.Func<bool>, System.Func<bool>, System.Action<KMSelectable>)') | Removes the parameter values to the corresponding hooks, when applicable. |
| [Set(this Selected, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action)](SelectedCore.Set(Selected,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action,Action).md 'wawa.Recall.SelectedCore.Set(this wawa.Recall.Selected, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action)') | Adds the parameter values to the corresponding hooks, when applicable. |
| [SetRaw(Selected, Func&lt;bool&gt;, Func&lt;bool&gt;, Action&lt;KMSelectable&gt;)](SelectedCore.SetRaw(Selected,Func{bool},Func{bool},Action{KMSelectable}).md 'wawa.Recall.SelectedCore.SetRaw(wawa.Recall.Selected, System.Func<bool>, System.Func<bool>, System.Action<KMSelectable>)') | Removes the parameter values to the corresponding hooks, when applicable. |
| [ToEntities(this IEnumerable&lt;Selected&gt;)](SelectedCore.ToEntities(IEnumerable{Selected}).md 'wawa.Recall.SelectedCore.ToEntities(this System.Collections.Generic.IEnumerable<wawa.Recall.Selected>)') | Creates an [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
| [ToEntity(this Selected)](SelectedCore.ToEntity(Selected).md 'wawa.Recall.SelectedCore.ToEntity(this wawa.Recall.Selected)') | Gets the [Entity](Entity.md 'wawa.Recall.Entity') of this [Selected](Selected.md 'wawa.Recall.Selected').<br/>An empty value is given if there is no attached [Entity](Entity.md 'wawa.Recall.Entity') on the [Selected](Selected.md 'wawa.Recall.Selected'). |
| [ToSelectables(this IEnumerable&lt;KMSelectable&gt;)](SelectedCore.ToSelectables(IEnumerable{KMSelectable}).md 'wawa.Recall.SelectedCore.ToSelectables(this System.Collections.Generic.IEnumerable<KMSelectable>)') | Creates an [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') where each element has been converted. |
