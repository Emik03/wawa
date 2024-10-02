### [wawa.Modules](wawa.Modules.md 'wawa.Modules').[State](State.md 'wawa.Modules.State')

## State.IsSolved Property

Gets a value indicating whether the module is solved.

```csharp
public bool IsSolved { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

### Remarks
  
For needy modules, a module is considered solved any time it is not active.