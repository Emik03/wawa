### [Wawa.Modules](Wawa.Modules.md 'Wawa.Modules').[ModdedModule](ModdedModule.md 'Wawa.Modules.ModdedModule')

## ModdedModule.OnEnable() Method

Unsubscribes [UnityEngine.Application.logMessageReceived](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Application.logMessageReceived 'UnityEngine.Application.logMessageReceived') and [KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate').

```csharp
protected virtual void OnEnable();
```

### Remarks
  
It is recommended to invoke the base method when overriding this method.