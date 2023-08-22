### [Wawa.Extensions](Wawa.Extensions.md 'Wawa.Extensions').[KMExtensions](KMExtensions.md 'Wawa.Extensions.KMExtensions')

## KMExtensions.Add(this KMBombModule, Action, Action, Action) Method

Sets specified delegate parameters into the [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule').

```csharp
public static KMBombModule Add(this KMBombModule module, System.Action onActivate=null, System.Action onPass=null, System.Action onStrike=null);
```
#### Parameters

<a name='Wawa.Extensions.KMExtensions.Add(thisKMBombModule,System.Action,System.Action,System.Action).module'></a>

`module` [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule')

The [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') to hook.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMBombModule,System.Action,System.Action,System.Action).onActivate'></a>

`onActivate` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the lights turn on.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMBombModule,System.Action,System.Action,System.Action).onPass'></a>

`onPass` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the module is solved.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMBombModule,System.Action,System.Action,System.Action).onStrike'></a>

`onStrike` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the module strikes.

#### Returns
[KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule')  
The parameter [module](KMExtensions.Add(KMBombModule,Action,Action,Action).md#Wawa.Extensions.KMExtensions.Add(thisKMBombModule,System.Action,System.Action,System.Action).module 'Wawa.Extensions.KMExtensions.Add(this KMBombModule, System.Action, System.Action, System.Action).module').