# ChildLength Property

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Gets the number of children the selectable has\. Calling [ChildLength](../../../wawa.Recall/wawa.Recall/Selected/ChildLength.md) is more efficient
than [Children](../../../wawa.Recall/wawa.Recall/Selected/Children.md) then using `ReadOnlyCollection<T>.Count` because
[Children](../../../wawa.Recall/wawa.Recall/Selected/Children.md) constructs a new `ReadOnlyCollection<T>` every time\.

```csharp
public int ChildLength { get; };
```

## Property Value

`int`

