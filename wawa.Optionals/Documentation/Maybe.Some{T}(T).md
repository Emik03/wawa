### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.Some<T>(T) Method

Wraps [T](Maybe.Some{T}(T).md#wawa.Optionals.Maybe.Some_T_(T).T 'wawa.Optionals.Maybe.Some<T>(T).T') in a [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').<p/>`[PublicAPI]`

```csharp
public static wawa.Optionals.Maybe<T> Some<T>(T that)
    where T : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='wawa.Optionals.Maybe.Some_T_(T).T'></a>

`T`

The type of parameter and generic in [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').
#### Parameters

<a name='wawa.Optionals.Maybe.Some_T_(T).that'></a>

`that` [T](Maybe.Some{T}(T).md#wawa.Optionals.Maybe.Some_T_(T).T 'wawa.Optionals.Maybe.Some<T>(T).T')

This instance of [T](Maybe.Some{T}(T).md#wawa.Optionals.Maybe.Some_T_(T).T 'wawa.Optionals.Maybe.Some<T>(T).T').

#### Returns
[wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.Some{T}(T).md#wawa.Optionals.Maybe.Some_T_(T).T 'wawa.Optionals.Maybe.Some<T>(T).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')  
A new instance of [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

### Remarks
  
Value types are the only types that cannot be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').