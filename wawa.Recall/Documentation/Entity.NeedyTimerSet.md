### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[Entity](Entity.md 'wawa.Recall.Entity')

## Entity.NeedyTimerSet Property

Gets a [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1') that when called, sets the time remaining to the parameter passed in.  
This value is immutable for vanilla modules. Needy Only.

```csharp
public wawa.Recall.HookMay<System.Action<float>> NeedyTimerSet { get; }
```

#### Property Value
[wawa.Recall.HookMay&lt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[&gt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')