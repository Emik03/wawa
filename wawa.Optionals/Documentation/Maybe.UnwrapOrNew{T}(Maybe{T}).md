### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.UnwrapOrNew<T>(this Maybe<T>) Method

Gives the inner value, or a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new') instance.

```csharp
public static T UnwrapOrNew<T>(this Wawa.Optionals.Maybe<T> that)
    where T : new();
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.UnwrapOrNew_T_(thisWawa.Optionals.Maybe_T_).T'></a>

`T`

The type of value stored within [that](Maybe.UnwrapOrNew{T}(Maybe{T}).md#Wawa.Optionals.Maybe.UnwrapOrNew_T_(thisWawa.Optionals.Maybe_T_).that 'Wawa.Optionals.Maybe.UnwrapOrNew<T>(this Wawa.Optionals.Maybe<T>).that').
#### Parameters

<a name='Wawa.Optionals.Maybe.UnwrapOrNew_T_(thisWawa.Optionals.Maybe_T_).that'></a>

`that` [Wawa.Optionals.Maybe&lt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.UnwrapOrNew{T}(Maybe{T}).md#Wawa.Optionals.Maybe.UnwrapOrNew_T_(thisWawa.Optionals.Maybe_T_).T 'Wawa.Optionals.Maybe.UnwrapOrNew<T>(this Wawa.Optionals.Maybe<T>).T')[&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>').

#### Returns
[T](Maybe.UnwrapOrNew{T}(Maybe{T}).md#Wawa.Optionals.Maybe.UnwrapOrNew_T_(thisWawa.Optionals.Maybe_T_).T 'Wawa.Optionals.Maybe.UnwrapOrNew<T>(this Wawa.Optionals.Maybe<T>).T')  
The inner value, or a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new') instance.