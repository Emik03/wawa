### [wawa.Modules](wawa.Modules.md 'wawa.Modules')

## ISolvable Interface

Interface for Twitch Plays auto-solvers. Used by [System.Reflection.Module](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Module 'System.Reflection.Module') to abstractly communicate  
with Twitch Plays solvers without importing the namespace.

```csharp
public interface ISolvable
```

| Properties | |
| :--- | :--- |
| [IsTP](ISolvable.IsTP.md 'wawa.Modules.ISolvable.IsTP') | Gets a value indicating whether Twitch Plays is currently active. |

| Methods | |
| :--- | :--- |
| [ForceTPSolve()](ISolvable.ForceTPSolve.md 'wawa.Modules.ISolvable.ForceTPSolve()') | When the module runs into an exception or the module is forced to be solved, it calls this method. |
