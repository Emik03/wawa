### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.TryGet<T>(this Maybe<T>, T) Method

Assigns a value with the inner value, or a [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default') value if none exists.

```csharp
public static bool TryGet<T>(this wawa.Optionals.Maybe<T> that, out T result);
```
#### Type parameters

<a name='wawa.Optionals.Maybe.TryGet_T_(thiswawa.Optionals.Maybe_T_,T).T'></a>

`T`

The generic type argument in [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').
#### Parameters

<a name='wawa.Optionals.Maybe.TryGet_T_(thiswawa.Optionals.Maybe_T_,T).that'></a>

`that` [wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.TryGet{T}(Maybe{T},T&).md#wawa.Optionals.Maybe.TryGet_T_(thiswawa.Optionals.Maybe_T_,T).T 'wawa.Optionals.Maybe.TryGet<T>(this wawa.Optionals.Maybe<T>, T).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

<a name='wawa.Optionals.Maybe.TryGet_T_(thiswawa.Optionals.Maybe_T_,T).result'></a>

`result` [T](Maybe.TryGet{T}(Maybe{T},T&).md#wawa.Optionals.Maybe.TryGet_T_(thiswawa.Optionals.Maybe_T_,T).T 'wawa.Optionals.Maybe.TryGet<T>(this wawa.Optionals.Maybe<T>, T).T')

The resulting value, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if [that](Maybe.TryGet{T}(Maybe{T},T&).md#wawa.Optionals.Maybe.TryGet_T_(thiswawa.Optionals.Maybe_T_,T).that 'wawa.Optionals.Maybe.TryGet<T>(this wawa.Optionals.Maybe<T>, T).that') contains a value, otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').