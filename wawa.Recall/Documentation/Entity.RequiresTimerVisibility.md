### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[Entity](Entity.md 'wawa.Recall.Entity')

## Entity.RequiresTimerVisibility Property

Gets whether to only allow this module to be placed on the same face as the timer.  
Useful when the rules involve the timer in some way (like the Big Button),  
but should be used sparingly as it limits generation possibilities.

```csharp
public wawa.Recall.PropDef<bool> RequiresTimerVisibility { get; }
```

#### Property Value
[wawa.Recall.PropDef&lt;](PropDef{T}.md 'wawa.Recall.PropDef<T>')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](PropDef{T}.md 'wawa.Recall.PropDef<T>')