### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.Match<T,TResult>(this Maybe<T>, TResult) Method

Gives the parameter corresponding to the inner value of [that](Maybe.Match{T,TResult}(Maybe{T},TResult).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult).that 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, TResult).that').

```csharp
public static wawa.Optionals.Maybe<TResult> Match<T,TResult>(this wawa.Optionals.Maybe<T> that, TResult some);
```
#### Type parameters

<a name='wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult).T'></a>

`T`

The type of value stored within [that](Maybe.Match{T,TResult}(Maybe{T},TResult).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult).that 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, TResult).that').

<a name='wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult).TResult'></a>

`TResult`

The [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') value of both callbacks.
#### Parameters

<a name='wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult).that'></a>

`that` [wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.Match{T,TResult}(Maybe{T},TResult).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult).T 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, TResult).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

<a name='wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult).some'></a>

`some` [TResult](Maybe.Match{T,TResult}(Maybe{T},TResult).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult).TResult 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, TResult).TResult')

The value to return if [IsSome](Maybe{T}.IsSome.md 'wawa.Optionals.Maybe<T>.IsSome') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[TResult](Maybe.Match{T,TResult}(Maybe{T},TResult).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,TResult).TResult 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, TResult).TResult')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')  
The parameter, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').