# NeedyTimerSet Property

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Gets a `Action<T>` that when called, sets the time remaining to the parameter passed in\.
This value is immutable for vanilla modules\. Needy Only\.

```csharp
public HookMay<Action<float>> NeedyTimerSet { get; };
```

## Property Value

[HookMay\<Action\<float\>\>](../../../wawa.Recall/wawa.Recall/HookMay\`1.md)

