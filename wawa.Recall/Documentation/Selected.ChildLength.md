### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[Selected](Selected.md 'Wawa.Recall.Selected')

## Selected.ChildLength Property

Gets the number of children the selectable has. Calling [ChildLength](Selected.ChildLength.md 'Wawa.Recall.Selected.ChildLength') is more efficient  
than [Children](Selected.Children.md 'Wawa.Recall.Selected.Children') then using [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;.Count](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1.Count 'System.Collections.ObjectModel.ReadOnlyCollection`1.Count') because  
[Children](Selected.Children.md 'Wawa.Recall.Selected.Children') constructs a new [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') every time.

```csharp
public int ChildLength { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')