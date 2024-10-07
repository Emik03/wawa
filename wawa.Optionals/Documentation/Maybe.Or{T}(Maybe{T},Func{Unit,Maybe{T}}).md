### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.Or<T>(this Maybe<T>, Func<Unit,Maybe<T>>) Method

Gives itself, or the parameter.<p/>`[PublicAPI]`

```csharp
public static wawa.Optionals.Maybe<T> Or<T>(this wawa.Optionals.Maybe<T> that, System.Func<wawa.Optionals.Unit,wawa.Optionals.Maybe<T>> otherwise);
```
#### Type parameters

<a name='wawa.Optionals.Maybe.Or_T_(thiswawa.Optionals.Maybe_T_,System.Func_wawa.Optionals.Unit,wawa.Optionals.Maybe_T__).T'></a>

`T`

The type of value stored within [that](Maybe.Or{T}(Maybe{T},Func{Unit,Maybe{T}}).md#wawa.Optionals.Maybe.Or_T_(thiswawa.Optionals.Maybe_T_,System.Func_wawa.Optionals.Unit,wawa.Optionals.Maybe_T__).that 'wawa.Optionals.Maybe.Or<T>(this wawa.Optionals.Maybe<T>, System.Func<wawa.Optionals.Unit,wawa.Optionals.Maybe<T>>).that').
#### Parameters

<a name='wawa.Optionals.Maybe.Or_T_(thiswawa.Optionals.Maybe_T_,System.Func_wawa.Optionals.Unit,wawa.Optionals.Maybe_T__).that'></a>

`that` [wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.Or{T}(Maybe{T},Func{Unit,Maybe{T}}).md#wawa.Optionals.Maybe.Or_T_(thiswawa.Optionals.Maybe_T_,System.Func_wawa.Optionals.Unit,wawa.Optionals.Maybe_T__).T 'wawa.Optionals.Maybe.Or<T>(this wawa.Optionals.Maybe<T>, System.Func<wawa.Optionals.Unit,wawa.Optionals.Maybe<T>>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

<a name='wawa.Optionals.Maybe.Or_T_(thiswawa.Optionals.Maybe_T_,System.Func_wawa.Optionals.Unit,wawa.Optionals.Maybe_T__).otherwise'></a>

`otherwise` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[Unit](Unit.md 'wawa.Optionals.Unit')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.Or{T}(Maybe{T},Func{Unit,Maybe{T}}).md#wawa.Optionals.Maybe.Or_T_(thiswawa.Optionals.Maybe_T_,System.Func_wawa.Optionals.Unit,wawa.Optionals.Maybe_T__).T 'wawa.Optionals.Maybe.Or<T>(this wawa.Optionals.Maybe<T>, System.Func<wawa.Optionals.Unit,wawa.Optionals.Maybe<T>>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The callback to execute if [IsSome](Maybe{T}.IsSome.md 'wawa.Optionals.Maybe<T>.IsSome') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.Or{T}(Maybe{T},Func{Unit,Maybe{T}}).md#wawa.Optionals.Maybe.Or_T_(thiswawa.Optionals.Maybe_T_,System.Func_wawa.Optionals.Unit,wawa.Optionals.Maybe_T__).T 'wawa.Optionals.Maybe.Or<T>(this wawa.Optionals.Maybe<T>, System.Func<wawa.Optionals.Unit,wawa.Optionals.Maybe<T>>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')  
The inner value, or the parameter [otherwise](Maybe.Or{T}(Maybe{T},Func{Unit,Maybe{T}}).md#wawa.Optionals.Maybe.Or_T_(thiswawa.Optionals.Maybe_T_,System.Func_wawa.Optionals.Unit,wawa.Optionals.Maybe_T__).otherwise 'wawa.Optionals.Maybe.Or<T>(this wawa.Optionals.Maybe<T>, System.Func<wawa.Optionals.Unit,wawa.Optionals.Maybe<T>>).otherwise').