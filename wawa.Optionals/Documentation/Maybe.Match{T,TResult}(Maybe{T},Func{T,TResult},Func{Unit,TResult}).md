### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.Match<T,TResult>(this Maybe<T>, Func<T,TResult>, Func<Unit,TResult>) Method

Uses the callback corresponding to the inner value of [that](Maybe.Match{T,TResult}(Maybe{T},Func{T,TResult},Func{Unit,TResult}).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_wawa.Optionals.Unit,TResult_).that 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, System.Func<T,TResult>, System.Func<wawa.Optionals.Unit,TResult>).that').<p/>`[PublicAPI]`

```csharp
public static TResult Match<T,TResult>(this wawa.Optionals.Maybe<T> that, System.Func<T,TResult> some, System.Func<wawa.Optionals.Unit,TResult> none);
```
#### Type parameters

<a name='wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_wawa.Optionals.Unit,TResult_).T'></a>

`T`

The type of value stored within [that](Maybe.Match{T,TResult}(Maybe{T},Func{T,TResult},Func{Unit,TResult}).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_wawa.Optionals.Unit,TResult_).that 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, System.Func<T,TResult>, System.Func<wawa.Optionals.Unit,TResult>).that').

<a name='wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_wawa.Optionals.Unit,TResult_).TResult'></a>

`TResult`

The [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') value of both callbacks.
#### Parameters

<a name='wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_wawa.Optionals.Unit,TResult_).that'></a>

`that` [wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.Match{T,TResult}(Maybe{T},Func{T,TResult},Func{Unit,TResult}).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_wawa.Optionals.Unit,TResult_).T 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, System.Func<T,TResult>, System.Func<wawa.Optionals.Unit,TResult>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

<a name='wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_wawa.Optionals.Unit,TResult_).some'></a>

`some` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Maybe.Match{T,TResult}(Maybe{T},Func{T,TResult},Func{Unit,TResult}).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_wawa.Optionals.Unit,TResult_).T 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, System.Func<T,TResult>, System.Func<wawa.Optionals.Unit,TResult>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](Maybe.Match{T,TResult}(Maybe{T},Func{T,TResult},Func{Unit,TResult}).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_wawa.Optionals.Unit,TResult_).TResult 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, System.Func<T,TResult>, System.Func<wawa.Optionals.Unit,TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The callback to run if [IsSome](Maybe{T}.IsSome.md 'wawa.Optionals.Maybe<T>.IsSome') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').<p/>`[InstantHandle, NotNull]`

<a name='wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_wawa.Optionals.Unit,TResult_).none'></a>

`none` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[Unit](Unit.md 'wawa.Optionals.Unit')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](Maybe.Match{T,TResult}(Maybe{T},Func{T,TResult},Func{Unit,TResult}).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_wawa.Optionals.Unit,TResult_).TResult 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, System.Func<T,TResult>, System.Func<wawa.Optionals.Unit,TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The callback to run if [IsSome](Maybe{T}.IsSome.md 'wawa.Optionals.Maybe<T>.IsSome') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').<p/>`[InstantHandle, NotNull]`

#### Returns
[TResult](Maybe.Match{T,TResult}(Maybe{T},Func{T,TResult},Func{Unit,TResult}).md#wawa.Optionals.Maybe.Match_T,TResult_(thiswawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_wawa.Optionals.Unit,TResult_).TResult 'wawa.Optionals.Maybe.Match<T,TResult>(this wawa.Optionals.Maybe<T>, System.Func<T,TResult>, System.Func<wawa.Optionals.Unit,TResult>).TResult')  
The value returned from the corresponding callback.