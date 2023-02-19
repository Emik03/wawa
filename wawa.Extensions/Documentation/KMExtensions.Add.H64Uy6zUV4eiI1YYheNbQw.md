### [Wawa.Extensions](Wawa.Extensions.md 'Wawa.Extensions').[KMExtensions](KMExtensions.md 'Wawa.Extensions.KMExtensions')

## KMExtensions.Add(this KMGameInfo, Action, Action, Action) Method

Sets specified delegate parameters into the [KMGameInfo](https://docs.microsoft.com/en-us/dotnet/api/KMGameInfo 'KMGameInfo').

```csharp
public static KMGameInfo Add(this KMGameInfo game, System.Action onStateChange=null, System.Action onAlarmClockChange=null, System.Action onLightsChange=null);
```
#### Parameters

<a name='Wawa.Extensions.KMExtensions.Add(thisKMGameInfo,System.Action,System.Action,System.Action).game'></a>

`game` [KMGameInfo](https://docs.microsoft.com/en-us/dotnet/api/KMGameInfo 'KMGameInfo')

The [KMGameInfo](https://docs.microsoft.com/en-us/dotnet/api/KMGameInfo 'KMGameInfo') to hook.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMGameInfo,System.Action,System.Action,System.Action).onStateChange'></a>

`onStateChange` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the state of the game changes.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMGameInfo,System.Action,System.Action,System.Action).onAlarmClockChange'></a>

`onAlarmClockChange` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the alarm clock changes state, and passes in whether it's on or off.

<a name='Wawa.Extensions.KMExtensions.Add(thisKMGameInfo,System.Action,System.Action,System.Action).onLightsChange'></a>

`onLightsChange` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the lights change state, and passes in whether it's on or off.

#### Returns
[KMGameInfo](https://docs.microsoft.com/en-us/dotnet/api/KMGameInfo 'KMGameInfo')  
The parameter [game](KMExtensions.Add.H64Uy6zUV4eiI1YYheNbQw.md#Wawa.Extensions.KMExtensions.Add(thisKMGameInfo,System.Action,System.Action,System.Action).game 'Wawa.Extensions.KMExtensions.Add(this KMGameInfo, System.Action, System.Action, System.Action).game').