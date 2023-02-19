### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.TryGet<T>(this Maybe<T>, T) Method

Assigns a value with the inner value, or a [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default') value if none exists.

```csharp
public static bool TryGet<T>(this Wawa.Optionals.Maybe<T> that, out T result);
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.TryGet_T_(thisWawa.Optionals.Maybe_T_,T).T'></a>

`T`

The generic type argument in [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').
#### Parameters

<a name='Wawa.Optionals.Maybe.TryGet_T_(thisWawa.Optionals.Maybe_T_,T).that'></a>

`that` [Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.TryGet.qytbwmJZD2EKJYJXTa2hhQ.md#Wawa.Optionals.Maybe.TryGet_T_(thisWawa.Optionals.Maybe_T_,T).T 'Wawa.Optionals.Maybe.TryGet<T>(this Wawa.Optionals.Maybe<T>, T).T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').

<a name='Wawa.Optionals.Maybe.TryGet_T_(thisWawa.Optionals.Maybe_T_,T).result'></a>

`result` [T](Maybe.TryGet.qytbwmJZD2EKJYJXTa2hhQ.md#Wawa.Optionals.Maybe.TryGet_T_(thisWawa.Optionals.Maybe_T_,T).T 'Wawa.Optionals.Maybe.TryGet<T>(this Wawa.Optionals.Maybe<T>, T).T')

The resulting value, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if [that](Maybe.TryGet.qytbwmJZD2EKJYJXTa2hhQ.md#Wawa.Optionals.Maybe.TryGet_T_(thisWawa.Optionals.Maybe_T_,T).that 'Wawa.Optionals.Maybe.TryGet<T>(this Wawa.Optionals.Maybe<T>, T).that') contains a value, otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').