# Interact Property

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Gets the `Func<TResult>` that is called whenever the player interacts with
this selectable\. Done on button down\. Returning `true` makes the selectable
behave as a module with children, and `false` as a button with no children\.

```csharp
public HookDef<Func<bool>> Interact { get; };
```

## Property Value

[HookDef\<Func\<bool\>\>](../../../wawa.Recall/wawa.Recall/HookDef\`1.md)

