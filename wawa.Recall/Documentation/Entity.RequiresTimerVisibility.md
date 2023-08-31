### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[Entity](Entity.md 'Wawa.Callbacks.Entity')

## Entity.RequiresTimerVisibility Property

Gets whether to only allow this module to be placed on the same face as the timer.  
Useful when the rules involve the timer in some way (like the Big Button),  
but should be used sparingly as it limits generation possibilities.

```csharp
public Wawa.Callbacks.PropDef<bool> RequiresTimerVisibility { get; }
```

#### Property Value
[Wawa.Callbacks.PropDef&lt;](PropDef{T}.md 'Wawa.Callbacks.PropDef<T>')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](PropDef{T}.md 'Wawa.Callbacks.PropDef<T>')