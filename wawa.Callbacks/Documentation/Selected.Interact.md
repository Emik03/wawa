### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[Selected](Selected.md 'Wawa.Callbacks.Selected')

## Selected.Interact Property

Gets the [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1') that is called whenever the player interacts with  
this selectable. Done on button down. Returning [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') makes the selectable  
behave as a module with children, and [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') as a button with no children.

```csharp
public Wawa.Callbacks.HookDef<System.Func<bool>> Interact { get; }
```

#### Property Value
[Wawa.Callbacks.HookDef&lt;](HookDef{T}.md 'Wawa.Callbacks.HookDef<T>')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[&gt;](HookDef{T}.md 'Wawa.Callbacks.HookDef<T>')