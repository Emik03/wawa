### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.Unwrap<T>(this Maybe<T>) Method

Gets the value that is encapsulated. This value returned will not be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'),  
and consequentially if it is.

```csharp
public static T Unwrap<T>(this Wawa.Optionals.Maybe<T> that);
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.Unwrap_T_(thisWawa.Optionals.Maybe_T_).T'></a>

`T`

The type of value stored within [that](Maybe.Unwrap(Maybe).md#Wawa.Optionals.Maybe.Unwrap_T_(thisWawa.Optionals.Maybe_T_).that 'Wawa.Optionals.Maybe.Unwrap<T>(this Wawa.Optionals.Maybe<T>).that').
#### Parameters

<a name='Wawa.Optionals.Maybe.Unwrap_T_(thisWawa.Optionals.Maybe_T_).that'></a>

`that` [Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.Unwrap(Maybe).md#Wawa.Optionals.Maybe.Unwrap_T_(thisWawa.Optionals.Maybe_T_).T 'Wawa.Optionals.Maybe.Unwrap<T>(this Wawa.Optionals.Maybe<T>).T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').

#### Returns
[T](Maybe.Unwrap(Maybe).md#Wawa.Optionals.Maybe.Unwrap_T_(thisWawa.Optionals.Maybe_T_).T 'Wawa.Optionals.Maybe.Unwrap<T>(this Wawa.Optionals.Maybe<T>).T')  
The inner value.

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The parameter [that](Maybe.Unwrap(Maybe).md#Wawa.Optionals.Maybe.Unwrap_T_(thisWawa.Optionals.Maybe_T_).that 'Wawa.Optionals.Maybe.Unwrap<T>(this Wawa.Optionals.Maybe<T>).that') has [IsSome](Maybe_T_.IsSome().md 'Wawa.Optionals.Maybe<T>.IsSome') set to [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').