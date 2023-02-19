### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.UnwrapOr<T>(this Maybe<T>, T) Method

Gives the inner value, or the parameter.

```csharp
public static T UnwrapOr<T>(this Wawa.Optionals.Maybe<T> that, T otherwise);
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.UnwrapOr_T_(thisWawa.Optionals.Maybe_T_,T).T'></a>

`T`

The type of value stored within [that](Maybe.UnwrapOr.ZJ3v0YALS7pxG/9mJcy92A.md#Wawa.Optionals.Maybe.UnwrapOr_T_(thisWawa.Optionals.Maybe_T_,T).that 'Wawa.Optionals.Maybe.UnwrapOr<T>(this Wawa.Optionals.Maybe<T>, T).that').
#### Parameters

<a name='Wawa.Optionals.Maybe.UnwrapOr_T_(thisWawa.Optionals.Maybe_T_,T).that'></a>

`that` [Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.UnwrapOr.ZJ3v0YALS7pxG/9mJcy92A.md#Wawa.Optionals.Maybe.UnwrapOr_T_(thisWawa.Optionals.Maybe_T_,T).T 'Wawa.Optionals.Maybe.UnwrapOr<T>(this Wawa.Optionals.Maybe<T>, T).T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').

<a name='Wawa.Optionals.Maybe.UnwrapOr_T_(thisWawa.Optionals.Maybe_T_,T).otherwise'></a>

`otherwise` [T](Maybe.UnwrapOr.ZJ3v0YALS7pxG/9mJcy92A.md#Wawa.Optionals.Maybe.UnwrapOr_T_(thisWawa.Optionals.Maybe_T_,T).T 'Wawa.Optionals.Maybe.UnwrapOr<T>(this Wawa.Optionals.Maybe<T>, T).T')

The value to return if [IsSome](Maybe_T_.IsSome.md 'Wawa.Optionals.Maybe<T>.IsSome') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[T](Maybe.UnwrapOr.ZJ3v0YALS7pxG/9mJcy92A.md#Wawa.Optionals.Maybe.UnwrapOr_T_(thisWawa.Optionals.Maybe_T_,T).T 'Wawa.Optionals.Maybe.UnwrapOr<T>(this Wawa.Optionals.Maybe<T>, T).T')  
The inner value, or the parameter [otherwise](Maybe.UnwrapOr.ZJ3v0YALS7pxG/9mJcy92A.md#Wawa.Optionals.Maybe.UnwrapOr_T_(thisWawa.Optionals.Maybe_T_,T).otherwise 'Wawa.Optionals.Maybe.UnwrapOr<T>(this Wawa.Optionals.Maybe<T>, T).otherwise').