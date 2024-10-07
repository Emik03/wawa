### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.Match<T,TResult>(this Maybe<T>, TResult, TResult) Method

Gives the parameter corresponding to the inner value of [that](Maybe.Match{T,TResult}(Maybe{T},TResult,TResult).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult,TResult).that 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, TResult, TResult).that').<p/>`[PublicAPI]`

```csharp
public static TResult Match<T,TResult>(this wawa.Optionals.Maybe<T> that, TResult some, TResult none);
```
#### Type parameters

<a name='wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult,TResult).T'></a>

`T`

The type of value stored within [that](Maybe.Match{T,TResult}(Maybe{T},TResult,TResult).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult,TResult).that 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, TResult, TResult).that').

<a name='wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult,TResult).TResult'></a>

`TResult`

The [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') value of both callbacks.
#### Parameters

<a name='wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult,TResult).that'></a>

`that` [wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.Match{T,TResult}(Maybe{T},TResult,TResult).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult,TResult).T 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, TResult, TResult).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

<a name='wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult,TResult).some'></a>

`some` [TResult](Maybe.Match{T,TResult}(Maybe{T},TResult,TResult).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult,TResult).TResult 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, TResult, TResult).TResult')

The value to return if [IsSome](Maybe{T}.IsSome.md 'wawa.Optionals.Maybe<T>.IsSome') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

<a name='wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult,TResult).none'></a>

`none` [TResult](Maybe.Match{T,TResult}(Maybe{T},TResult,TResult).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult,TResult).TResult 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, TResult, TResult).TResult')

The value to return if [IsSome](Maybe{T}.IsSome.md 'wawa.Optionals.Maybe<T>.IsSome') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[TResult](Maybe.Match{T,TResult}(Maybe{T},TResult,TResult).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult,TResult).TResult 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, TResult, TResult).TResult')  
The corresponding parameter.