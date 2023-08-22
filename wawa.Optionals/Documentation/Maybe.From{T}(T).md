### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.From<T>(T) Method

Wraps [T](Maybe.From{T}(T).md#Wawa.Optionals.Maybe.From_T_(T).T 'Wawa.Optionals.Maybe.From<T>(T).T') in a [Maybe&lt;T&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>').

```csharp
public static Wawa.Optionals.Maybe<T> From<T>(T that)
    where T : class;
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.From_T_(T).T'></a>

`T`

The type of parameter and generic in [Maybe&lt;T&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>').
#### Parameters

<a name='Wawa.Optionals.Maybe.From_T_(T).that'></a>

`that` [T](Maybe.From{T}(T).md#Wawa.Optionals.Maybe.From_T_(T).T 'Wawa.Optionals.Maybe.From<T>(T).T')

This instance of [T](Maybe.From{T}(T).md#Wawa.Optionals.Maybe.From_T_(T).T 'Wawa.Optionals.Maybe.From<T>(T).T').

#### Returns
[Wawa.Optionals.Maybe&lt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.From{T}(T).md#Wawa.Optionals.Maybe.From_T_(T).T 'Wawa.Optionals.Maybe.From<T>(T).T')[&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')  
A new instance of [Maybe&lt;T&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>').