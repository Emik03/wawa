### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[Selected](Selected.md 'Wawa.Callbacks.Selected')

## Selected.Cancel Property

Gets the [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1') that is called whenever the player backs out of this  
selectable, an example would be zooming out of a module. Returning [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')  
backs out of the selectable and makes its parent the current, and [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')  
does not back out of the selectable and keeps the selectable as the current.

```csharp
public Wawa.Callbacks.HookDef<System.Func<bool>> Cancel { get; }
```

#### Property Value
[Wawa.Callbacks.HookDef&lt;](HookDef{T}.md 'Wawa.Callbacks.HookDef<T>')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[&gt;](HookDef{T}.md 'Wawa.Callbacks.HookDef<T>')