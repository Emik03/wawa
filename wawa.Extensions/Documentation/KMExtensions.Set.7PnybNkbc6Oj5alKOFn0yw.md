### [Wawa.Extensions](Wawa.Extensions.md 'Wawa.Extensions').[KMExtensions](KMExtensions.md 'Wawa.Extensions.KMExtensions')

## KMExtensions.Set(this KMNeedyModule, Action, Action, Action, Action, Action, Action) Method

Sets specified delegate parameters into the [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule').

```csharp
public static KMNeedyModule Set(this KMNeedyModule needy, System.Action onActivate=null, System.Action onNeedyActivation=null, System.Action onNeedyDeactivation=null, System.Action onPass=null, System.Action onStrike=null, System.Action onTimerExpired=null);
```
#### Parameters

<a name='Wawa.Extensions.KMExtensions.Set(thisKMNeedyModule,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).needy'></a>

`needy` [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule')

The [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule') to hook.

<a name='Wawa.Extensions.KMExtensions.Set(thisKMNeedyModule,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onActivate'></a>

`onActivate` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the lights turn on.

<a name='Wawa.Extensions.KMExtensions.Set(thisKMNeedyModule,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onNeedyActivation'></a>

`onNeedyActivation` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the needy activates.

<a name='Wawa.Extensions.KMExtensions.Set(thisKMNeedyModule,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onNeedyDeactivation'></a>

`onNeedyDeactivation` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the needy deactivates.

<a name='Wawa.Extensions.KMExtensions.Set(thisKMNeedyModule,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onPass'></a>

`onPass` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the needy is solved.

<a name='Wawa.Extensions.KMExtensions.Set(thisKMNeedyModule,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onStrike'></a>

`onStrike` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the needy strikes.

<a name='Wawa.Extensions.KMExtensions.Set(thisKMNeedyModule,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).onTimerExpired'></a>

`onTimerExpired` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the timer runs out of time.

#### Returns
[KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule')  
The parameter [needy](KMExtensions.Set.7PnybNkbc6Oj5alKOFn0yw.md#Wawa.Extensions.KMExtensions.Set(thisKMNeedyModule,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action).needy 'Wawa.Extensions.KMExtensions.Set(this KMNeedyModule, System.Action, System.Action, System.Action, System.Action, System.Action, System.Action).needy').