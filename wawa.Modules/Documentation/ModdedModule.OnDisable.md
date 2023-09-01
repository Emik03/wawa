### [Wawa.Modules](Wawa.Modules.md 'Wawa.Modules').[ModdedModule](ModdedModule.md 'Wawa.Modules.ModdedModule')

## ModdedModule.OnDisable() Method

Unsubscribes from [UnityEngine.Application.logMessageReceived](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Application.logMessageReceived 'UnityEngine.Application.logMessageReceived'), [KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate'),  
[KMBombModule.OnPass](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnPass 'KMBombModule.OnPass'), and [KMBombModule.OnStrike](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnStrike 'KMBombModule.OnStrike').

```csharp
protected virtual void OnDisable();
```

### Remarks
  
It is recommended to invoke the base method when overriding this method.