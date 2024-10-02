### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[Entity](Entity.md 'wawa.Recall.Entity')

## Entity.NeedyTimerGet Property

Gets a [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1') that when called, gets the time remaining.  
This value is immutable for vanilla modules. Needy Only.

```csharp
public wawa.Recall.HookMay<System.Func<float>> NeedyTimerGet { get; }
```

#### Property Value
[wawa.Recall.HookMay&lt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[&gt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')