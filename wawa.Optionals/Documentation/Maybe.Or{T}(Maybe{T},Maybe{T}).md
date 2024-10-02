### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.Or<T>(this Maybe<T>, Maybe<T>) Method

Gives itself, or the parameter.

```csharp
public static wawa.Optionals.Maybe<T> Or<T>(this wawa.Optionals.Maybe<T> that, wawa.Optionals.Maybe<T> otherwise);
```
#### Type parameters

<a name='wawa.Optionals.Maybe.Or_T_(thiswawa.Optionals.Maybe_T_,wawa.Optionals.Maybe_T_).T'></a>

`T`

The type of value stored within [that](Maybe.Or{T}(Maybe{T},Maybe{T}).md#wawa.Optionals.Maybe.Or_T_(thiswawa.Optionals.Maybe_T_,wawa.Optionals.Maybe_T_).that 'wawa.Optionals.Maybe.Or<T>(this wawa.Optionals.Maybe<T>, wawa.Optionals.Maybe<T>).that').
#### Parameters

<a name='wawa.Optionals.Maybe.Or_T_(thiswawa.Optionals.Maybe_T_,wawa.Optionals.Maybe_T_).that'></a>

`that` [wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.Or{T}(Maybe{T},Maybe{T}).md#wawa.Optionals.Maybe.Or_T_(thiswawa.Optionals.Maybe_T_,wawa.Optionals.Maybe_T_).T 'wawa.Optionals.Maybe.Or<T>(this wawa.Optionals.Maybe<T>, wawa.Optionals.Maybe<T>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

<a name='wawa.Optionals.Maybe.Or_T_(thiswawa.Optionals.Maybe_T_,wawa.Optionals.Maybe_T_).otherwise'></a>

`otherwise` [wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.Or{T}(Maybe{T},Maybe{T}).md#wawa.Optionals.Maybe.Or_T_(thiswawa.Optionals.Maybe_T_,wawa.Optionals.Maybe_T_).T 'wawa.Optionals.Maybe.Or<T>(this wawa.Optionals.Maybe<T>, wawa.Optionals.Maybe<T>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

The value to return if [IsSome](Maybe{T}.IsSome.md 'wawa.Optionals.Maybe<T>.IsSome') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.Or{T}(Maybe{T},Maybe{T}).md#wawa.Optionals.Maybe.Or_T_(thiswawa.Optionals.Maybe_T_,wawa.Optionals.Maybe_T_).T 'wawa.Optionals.Maybe.Or<T>(this wawa.Optionals.Maybe<T>, wawa.Optionals.Maybe<T>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')  
The inner value, or the parameter [otherwise](Maybe.Or{T}(Maybe{T},Maybe{T}).md#wawa.Optionals.Maybe.Or_T_(thiswawa.Optionals.Maybe_T_,wawa.Optionals.Maybe_T_).otherwise 'wawa.Optionals.Maybe.Or<T>(this wawa.Optionals.Maybe<T>, wawa.Optionals.Maybe<T>).otherwise').