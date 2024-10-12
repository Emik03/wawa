# Cancel Property

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Gets the `Func<TResult>` that is called whenever the player backs out of this
selectable, an example would be zooming out of a module\. Returning `true`
backs out of the selectable and makes its parent the current, and `false`
does not back out of the selectable and keeps the selectable as the current\.

```csharp
public HookDef<Func<bool>> Cancel { get; };
```

## Property Value

[HookDef\<Func\<bool\>\>](../../../wawa.Recall/wawa.Recall/HookDef\`1.md)

