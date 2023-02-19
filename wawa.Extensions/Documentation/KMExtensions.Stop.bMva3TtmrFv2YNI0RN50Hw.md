### [Wawa.Extensions](Wawa.Extensions.md 'Wawa.Extensions').[KMExtensions](KMExtensions.md 'Wawa.Extensions.KMExtensions')

## KMExtensions.Stop<T>(this T) Method

Invokes [KMAudio.KMAudioRef.StopSound](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef.StopSound 'KMAudio.KMAudioRef.StopSound') for all elements in the  
[System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') of [KMAudio.KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef 'KMAudio.KMAudioRef') instances.

```csharp
public static T Stop<T>(this T audio)
    where T : System.Collections.Generic.IEnumerable<KMAudioRef>;
```
#### Type parameters

<a name='Wawa.Extensions.KMExtensions.Stop_T_(thisT).T'></a>

`T`

The type of [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') containing [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') instances.
#### Parameters

<a name='Wawa.Extensions.KMExtensions.Stop_T_(thisT).audio'></a>

`audio` [T](KMExtensions.Stop.bMva3TtmrFv2YNI0RN50Hw.md#Wawa.Extensions.KMExtensions.Stop_T_(thisT).T 'Wawa.Extensions.KMExtensions.Stop<T>(this T).T')

The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') of [KMAudio.KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef 'KMAudio.KMAudioRef')  
instances to invoke [KMAudio.KMAudioRef.StopSound](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef.StopSound 'KMAudio.KMAudioRef.StopSound').

#### Returns
[T](KMExtensions.Stop.bMva3TtmrFv2YNI0RN50Hw.md#Wawa.Extensions.KMExtensions.Stop_T_(thisT).T 'Wawa.Extensions.KMExtensions.Stop<T>(this T).T')  
The parameter [audio](KMExtensions.Stop.bMva3TtmrFv2YNI0RN50Hw.md#Wawa.Extensions.KMExtensions.Stop_T_(thisT).audio 'Wawa.Extensions.KMExtensions.Stop<T>(this T).audio').