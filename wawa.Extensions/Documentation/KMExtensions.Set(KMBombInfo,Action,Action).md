### [Wawa.Extensions](Wawa.Extensions.md 'Wawa.Extensions').[KMExtensions](KMExtensions.md 'Wawa.Extensions.KMExtensions')

## KMExtensions.Set(this KMBombInfo, Action, Action) Method

Sets specified delegate parameters into the [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable').

```csharp
public static KMBombInfo Set(this KMBombInfo info, System.Action onBombExploded=null, System.Action onBombSolved=null);
```
#### Parameters

<a name='Wawa.Extensions.KMExtensions.Set(thisKMBombInfo,System.Action,System.Action).info'></a>

`info` [KMBombInfo](https://docs.microsoft.com/en-us/dotnet/api/KMBombInfo 'KMBombInfo')

The [KMBombInfo](https://docs.microsoft.com/en-us/dotnet/api/KMBombInfo 'KMBombInfo') to hook.

<a name='Wawa.Extensions.KMExtensions.Set(thisKMBombInfo,System.Action,System.Action).onBombExploded'></a>

`onBombExploded` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the bomb explodes.

<a name='Wawa.Extensions.KMExtensions.Set(thisKMBombInfo,System.Action,System.Action).onBombSolved'></a>

`onBombSolved` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Called when the bomb is defused.

#### Returns
[KMBombInfo](https://docs.microsoft.com/en-us/dotnet/api/KMBombInfo 'KMBombInfo')  
The parameter [info](KMExtensions.Set(KMBombInfo,Action,Action).md#Wawa.Extensions.KMExtensions.Set(thisKMBombInfo,System.Action,System.Action).info 'Wawa.Extensions.KMExtensions.Set(this KMBombInfo, System.Action, System.Action).info').