### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.Match<T,TResult>(this Maybe<T>, Func<T,TResult>, Func<Unit,TResult>) Method

Uses the callback corresponding to the inner value of [that](Maybe.Match(Maybe,Func,Func).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_Wawa.Optionals.Unit,TResult_).that 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, System.Func<T,TResult>, System.Func<Wawa.Optionals.Unit,TResult>).that').

```csharp
public static TResult Match<T,TResult>(this Wawa.Optionals.Maybe<T> that, System.Func<T,TResult> some, System.Func<Wawa.Optionals.Unit,TResult> none);
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_Wawa.Optionals.Unit,TResult_).T'></a>

`T`

The type of value stored within [that](Maybe.Match(Maybe,Func,Func).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_Wawa.Optionals.Unit,TResult_).that 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, System.Func<T,TResult>, System.Func<Wawa.Optionals.Unit,TResult>).that').

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_Wawa.Optionals.Unit,TResult_).TResult'></a>

`TResult`

The [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') value of both callbacks.
#### Parameters

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_Wawa.Optionals.Unit,TResult_).that'></a>

`that` [Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.Match(Maybe,Func,Func).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_Wawa.Optionals.Unit,TResult_).T 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, System.Func<T,TResult>, System.Func<Wawa.Optionals.Unit,TResult>).T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_Wawa.Optionals.Unit,TResult_).some'></a>

`some` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Maybe.Match(Maybe,Func,Func).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_Wawa.Optionals.Unit,TResult_).T 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, System.Func<T,TResult>, System.Func<Wawa.Optionals.Unit,TResult>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](Maybe.Match(Maybe,Func,Func).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_Wawa.Optionals.Unit,TResult_).TResult 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, System.Func<T,TResult>, System.Func<Wawa.Optionals.Unit,TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The callback to run if [IsSome](Maybe_T_.IsSome().md 'Wawa.Optionals.Maybe<T>.IsSome') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_Wawa.Optionals.Unit,TResult_).none'></a>

`none` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[Unit](Unit.md 'Wawa.Optionals.Unit')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](Maybe.Match(Maybe,Func,Func).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_Wawa.Optionals.Unit,TResult_).TResult 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, System.Func<T,TResult>, System.Func<Wawa.Optionals.Unit,TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The callback to run if [IsSome](Maybe_T_.IsSome().md 'Wawa.Optionals.Maybe<T>.IsSome') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[TResult](Maybe.Match(Maybe,Func,Func).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_,System.Func_Wawa.Optionals.Unit,TResult_).TResult 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, System.Func<T,TResult>, System.Func<Wawa.Optionals.Unit,TResult>).TResult')  
The value returned from the corresponding callback.