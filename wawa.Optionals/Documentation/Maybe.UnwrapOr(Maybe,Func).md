### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.UnwrapOr<T>(this Maybe<T>, Func<Unit,T>) Method

Gives the inner value, or the returned value from the callback.

```csharp
public static T UnwrapOr<T>(this Wawa.Optionals.Maybe<T> that, System.Func<Wawa.Optionals.Unit,T> otherwise);
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.UnwrapOr_T_(thisWawa.Optionals.Maybe_T_,System.Func_Wawa.Optionals.Unit,T_).T'></a>

`T`

The type of value stored within [that](Maybe.UnwrapOr(Maybe,Func).md#Wawa.Optionals.Maybe.UnwrapOr_T_(thisWawa.Optionals.Maybe_T_,System.Func_Wawa.Optionals.Unit,T_).that 'Wawa.Optionals.Maybe.UnwrapOr<T>(this Wawa.Optionals.Maybe<T>, System.Func<Wawa.Optionals.Unit,T>).that').
#### Parameters

<a name='Wawa.Optionals.Maybe.UnwrapOr_T_(thisWawa.Optionals.Maybe_T_,System.Func_Wawa.Optionals.Unit,T_).that'></a>

`that` [Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.UnwrapOr(Maybe,Func).md#Wawa.Optionals.Maybe.UnwrapOr_T_(thisWawa.Optionals.Maybe_T_,System.Func_Wawa.Optionals.Unit,T_).T 'Wawa.Optionals.Maybe.UnwrapOr<T>(this Wawa.Optionals.Maybe<T>, System.Func<Wawa.Optionals.Unit,T>).T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').

<a name='Wawa.Optionals.Maybe.UnwrapOr_T_(thisWawa.Optionals.Maybe_T_,System.Func_Wawa.Optionals.Unit,T_).otherwise'></a>

`otherwise` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[Unit](Unit.md 'Wawa.Optionals.Unit')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Maybe.UnwrapOr(Maybe,Func).md#Wawa.Optionals.Maybe.UnwrapOr_T_(thisWawa.Optionals.Maybe_T_,System.Func_Wawa.Optionals.Unit,T_).T 'Wawa.Optionals.Maybe.UnwrapOr<T>(this Wawa.Optionals.Maybe<T>, System.Func<Wawa.Optionals.Unit,T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The callback to execute if [IsSome](Maybe_T_.IsSome().md 'Wawa.Optionals.Maybe<T>.IsSome') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[T](Maybe.UnwrapOr(Maybe,Func).md#Wawa.Optionals.Maybe.UnwrapOr_T_(thisWawa.Optionals.Maybe_T_,System.Func_Wawa.Optionals.Unit,T_).T 'Wawa.Optionals.Maybe.UnwrapOr<T>(this Wawa.Optionals.Maybe<T>, System.Func<Wawa.Optionals.Unit,T>).T')  
The inner value, or the returned value from the parameter [otherwise](Maybe.UnwrapOr(Maybe,Func).md#Wawa.Optionals.Maybe.UnwrapOr_T_(thisWawa.Optionals.Maybe_T_,System.Func_Wawa.Optionals.Unit,T_).otherwise 'Wawa.Optionals.Maybe.UnwrapOr<T>(this Wawa.Optionals.Maybe<T>, System.Func<Wawa.Optionals.Unit,T>).otherwise').