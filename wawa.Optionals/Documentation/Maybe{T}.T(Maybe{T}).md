### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

## Maybe<T>.explicit operator T(Maybe<T>) Operator

Converts the [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>') to [T](Maybe{T}.md#wawa.Optionals.Maybe_T_.T 'wawa.Optionals.Maybe<T>.T').

```csharp
public static T explicit operator T(wawa.Optionals.Maybe<T> value);
```
#### Parameters

<a name='wawa.Optionals.Maybe_T_.op_ExplicitT(wawa.Optionals.Maybe_T_).value'></a>

`value` [wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe{T}.md#wawa.Optionals.Maybe_T_.T 'wawa.Optionals.Maybe<T>.T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

The [T](Maybe{T}.md#wawa.Optionals.Maybe_T_.T 'wawa.Optionals.Maybe<T>.T') instance to convert.

#### Returns
[T](Maybe{T}.md#wawa.Optionals.Maybe_T_.T 'wawa.Optionals.Maybe<T>.T')  
The inner value.

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The parameter [value](Maybe{T}.T(Maybe{T}).md#wawa.Optionals.Maybe_T_.op_ExplicitT(wawa.Optionals.Maybe_T_).value 'wawa.Optionals.Maybe<T>.op_Explicit T(wawa.Optionals.Maybe<T>).value') is a None value.