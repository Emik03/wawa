### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.None<T>() Method

Gets an empty [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>') of the desired type.<p/>`[PublicAPI]`

```csharp
public static wawa.Optionals.Maybe<T> None<T>();
```
#### Type parameters

<a name='wawa.Optionals.Maybe.None_T_().T'></a>

`T`

The generic in [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

#### Returns
[wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.None{T}.md#wawa.Optionals.Maybe.None_T_().T 'wawa.Optionals.Maybe.None<T>().T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')  
A [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>') that always has [IsNone](Maybe{T}.IsNone.md 'wawa.Optionals.Maybe<T>.IsNone')[return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').