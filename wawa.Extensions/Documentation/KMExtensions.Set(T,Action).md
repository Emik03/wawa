### [Wawa.Extensions](Wawa.Extensions.md 'Wawa.Extensions').[KMExtensions](KMExtensions.md 'Wawa.Extensions.KMExtensions')

## KMExtensions.Set<T>(this T, Action<int>) Method

Sets the specified delegate parameter if not [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') into the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
of [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') instances. An [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') is passed in the [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
based on the index from the collection.

```csharp
public static T Set<T>(this T audio, System.Action<int> onStopSound)
    where T : System.Collections.Generic.IEnumerable<KMAudioRef>;
```
#### Type parameters

<a name='Wawa.Extensions.KMExtensions.Set_T_(thisT,System.Action_int_).T'></a>

`T`

The type of [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') containing [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') instances.
#### Parameters

<a name='Wawa.Extensions.KMExtensions.Set_T_(thisT,System.Action_int_).audio'></a>

`audio` [T](KMExtensions.Set(T,Action).md#Wawa.Extensions.KMExtensions.Set_T_(thisT,System.Action_int_).T 'Wawa.Extensions.KMExtensions.Set<T>(this T, System.Action<int>).T')

The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') of [KMAudio.KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef 'KMAudio.KMAudioRef')  
instances to invoke [KMAudio.KMAudioRef.StopSound](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef.StopSound 'KMAudio.KMAudioRef.StopSound').

<a name='Wawa.Extensions.KMExtensions.Set_T_(thisT,System.Action_int_).onStopSound'></a>

`onStopSound` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Called when the sound is prematurely stopped.

#### Returns
[T](KMExtensions.Set(T,Action).md#Wawa.Extensions.KMExtensions.Set_T_(thisT,System.Action_int_).T 'Wawa.Extensions.KMExtensions.Set<T>(this T, System.Action<int>).T')  
The parameter [audio](KMExtensions.Set(T,Action).md#Wawa.Extensions.KMExtensions.Set_T_(thisT,System.Action_int_).audio 'Wawa.Extensions.KMExtensions.Set<T>(this T, System.Action<int>).audio').