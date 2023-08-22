### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.TryGet<T>(this Maybe<T>, T) Method

Assigns a value with the inner value, or a [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default') value if none exists.

```csharp
public static bool TryGet<T>(this Wawa.Optionals.Maybe<T> that, out T result);
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.TryGet_T_(thisWawa.Optionals.Maybe_T_,T).T'></a>

`T`

The generic type argument in [Maybe&lt;T&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>').
#### Parameters

<a name='Wawa.Optionals.Maybe.TryGet_T_(thisWawa.Optionals.Maybe_T_,T).that'></a>

`that` [Wawa.Optionals.Maybe&lt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.TryGet{T}(Maybe{T},T&).md#Wawa.Optionals.Maybe.TryGet_T_(thisWawa.Optionals.Maybe_T_,T).T 'Wawa.Optionals.Maybe.TryGet<T>(this Wawa.Optionals.Maybe<T>, T).T')[&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>').

<a name='Wawa.Optionals.Maybe.TryGet_T_(thisWawa.Optionals.Maybe_T_,T).result'></a>

`result` [T](Maybe.TryGet{T}(Maybe{T},T&).md#Wawa.Optionals.Maybe.TryGet_T_(thisWawa.Optionals.Maybe_T_,T).T 'Wawa.Optionals.Maybe.TryGet<T>(this Wawa.Optionals.Maybe<T>, T).T')

The resulting value, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if [that](Maybe.TryGet{T}(Maybe{T},T&).md#Wawa.Optionals.Maybe.TryGet_T_(thisWawa.Optionals.Maybe_T_,T).that 'Wawa.Optionals.Maybe.TryGet<T>(this Wawa.Optionals.Maybe<T>, T).that') contains a value, otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').