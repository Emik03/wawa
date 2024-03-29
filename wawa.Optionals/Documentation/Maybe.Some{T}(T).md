### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.Some<T>(T) Method

Wraps [T](Maybe.Some{T}(T).md#Wawa.Optionals.Maybe.Some_T_(T).T 'Wawa.Optionals.Maybe.Some<T>(T).T') in a [Maybe&lt;T&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>').

```csharp
public static Wawa.Optionals.Maybe<T> Some<T>(T that)
    where T : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.Some_T_(T).T'></a>

`T`

The type of parameter and generic in [Maybe&lt;T&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>').
#### Parameters

<a name='Wawa.Optionals.Maybe.Some_T_(T).that'></a>

`that` [T](Maybe.Some{T}(T).md#Wawa.Optionals.Maybe.Some_T_(T).T 'Wawa.Optionals.Maybe.Some<T>(T).T')

This instance of [T](Maybe.Some{T}(T).md#Wawa.Optionals.Maybe.Some_T_(T).T 'Wawa.Optionals.Maybe.Some<T>(T).T').

#### Returns
[Wawa.Optionals.Maybe&lt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.Some{T}(T).md#Wawa.Optionals.Maybe.Some_T_(T).T 'Wawa.Optionals.Maybe.Some<T>(T).T')[&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')  
A new instance of [Maybe&lt;T&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>').

### Remarks
  
Value types are the only types that cannot be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').