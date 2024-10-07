### [wawa.Extensions](wawa.Extensions.md 'wawa.Extensions').[KMExtensions](KMExtensions.md 'wawa.Extensions.KMExtensions')

## KMExtensions.Stop<T>(this T) Method

Invokes [KMAudio.KMAudioRef.StopSound](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef.StopSound 'KMAudio.KMAudioRef.StopSound') for all elements in the  
[System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') of [KMAudio.KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef 'KMAudio.KMAudioRef') instances.

```csharp
public static T Stop<T>(this T audio)
    where T : System.Collections.Generic.IEnumerable<KMAudioRef>;
```
#### Type parameters

<a name='wawa.Extensions.KMExtensions.Stop_T_(thisT).T'></a>

`T`

The type of [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') containing [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') instances.
#### Parameters

<a name='wawa.Extensions.KMExtensions.Stop_T_(thisT).audio'></a>

`audio` [T](KMExtensions.Stop{T}(T).md#wawa.Extensions.KMExtensions.Stop_T_(thisT).T 'wawa.Extensions.KMExtensions.Stop<T>(this T).T')

The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') of [KMAudio.KMAudioRef](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef 'KMAudio.KMAudioRef')  
instances to invoke [KMAudio.KMAudioRef.StopSound](https://docs.microsoft.com/en-us/dotnet/api/KMAudio.KMAudioRef.StopSound 'KMAudio.KMAudioRef.StopSound').  
<p/>`[ItemCanBeNull]`

#### Returns
[T](KMExtensions.Stop{T}(T).md#wawa.Extensions.KMExtensions.Stop_T_(thisT).T 'wawa.Extensions.KMExtensions.Stop<T>(this T).T')  
The parameter [audio](KMExtensions.Stop{T}(T).md#wawa.Extensions.KMExtensions.Stop_T_(thisT).audio 'wawa.Extensions.KMExtensions.Stop<T>(this T).audio').