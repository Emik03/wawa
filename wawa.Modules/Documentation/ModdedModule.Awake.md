### [Wawa.Modules](Wawa.Modules.md 'Wawa.Modules').[ModdedModule](ModdedModule.md 'Wawa.Modules.ModdedModule')

## ModdedModule.Awake() Method

Logs version numbers. Be sure to call this method if you are implementing Awake.

```csharp
protected virtual void Awake();
```

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
A loaded mod has a null mod id, or has an id that conflicts with another loaded mod.