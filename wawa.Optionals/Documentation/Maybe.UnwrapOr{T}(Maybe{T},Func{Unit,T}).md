### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.UnwrapOr<T>(this Maybe<T>, Func<Unit,T>) Method

Gives the inner value, or the returned value from the callback.<p/>`[PublicAPI]`

```csharp
public static T UnwrapOr<T>(this wawa.Optionals.Maybe<T> that, System.Func<wawa.Optionals.Unit,T> otherwise);
```
#### Type parameters

<a name='wawa.Optionals.Maybe.UnwrapOr_T_(thiswawa.Optionals.Maybe_T_,System.Func_wawa.Optionals.Unit,T_).T'></a>

`T`

The type of value stored within [that](Maybe.UnwrapOr{T}(Maybe{T},Func{Unit,T}).md#wawa.Optionals.Maybe.UnwrapOr_T_(thiswawa.Optionals.Maybe_T_,System.Func_wawa.Optionals.Unit,T_).that 'wawa.Optionals.Maybe.UnwrapOr<T>(this wawa.Optionals.Maybe<T>, System.Func<wawa.Optionals.Unit,T>).that').
#### Parameters

<a name='wawa.Optionals.Maybe.UnwrapOr_T_(thiswawa.Optionals.Maybe_T_,System.Func_wawa.Optionals.Unit,T_).that'></a>

`that` [wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.UnwrapOr{T}(Maybe{T},Func{Unit,T}).md#wawa.Optionals.Maybe.UnwrapOr_T_(thiswawa.Optionals.Maybe_T_,System.Func_wawa.Optionals.Unit,T_).T 'wawa.Optionals.Maybe.UnwrapOr<T>(this wawa.Optionals.Maybe<T>, System.Func<wawa.Optionals.Unit,T>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

<a name='wawa.Optionals.Maybe.UnwrapOr_T_(thiswawa.Optionals.Maybe_T_,System.Func_wawa.Optionals.Unit,T_).otherwise'></a>

`otherwise` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[Unit](Unit.md 'wawa.Optionals.Unit')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Maybe.UnwrapOr{T}(Maybe{T},Func{Unit,T}).md#wawa.Optionals.Maybe.UnwrapOr_T_(thiswawa.Optionals.Maybe_T_,System.Func_wawa.Optionals.Unit,T_).T 'wawa.Optionals.Maybe.UnwrapOr<T>(this wawa.Optionals.Maybe<T>, System.Func<wawa.Optionals.Unit,T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The callback to execute if [IsSome](Maybe{T}.IsSome.md 'wawa.Optionals.Maybe<T>.IsSome') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').  
<p/>`[InstantHandle, NotNull]`

#### Returns
[T](Maybe.UnwrapOr{T}(Maybe{T},Func{Unit,T}).md#wawa.Optionals.Maybe.UnwrapOr_T_(thiswawa.Optionals.Maybe_T_,System.Func_wawa.Optionals.Unit,T_).T 'wawa.Optionals.Maybe.UnwrapOr<T>(this wawa.Optionals.Maybe<T>, System.Func<wawa.Optionals.Unit,T>).T')  
The inner value, or the returned value from the parameter [otherwise](Maybe.UnwrapOr{T}(Maybe{T},Func{Unit,T}).md#wawa.Optionals.Maybe.UnwrapOr_T_(thiswawa.Optionals.Maybe_T_,System.Func_wawa.Optionals.Unit,T_).otherwise 'wawa.Optionals.Maybe.UnwrapOr<T>(this wawa.Optionals.Maybe<T>, System.Func<wawa.Optionals.Unit,T>).otherwise').