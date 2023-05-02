### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')

## Maybe<T>.explicit operator T(Maybe<T>) Operator

Converts the [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>') to [T](Maybe_T_.md#Wawa.Optionals.Maybe_T_.T 'Wawa.Optionals.Maybe<T>.T').

```csharp
public static T explicit operator T(Wawa.Optionals.Maybe<T> value);
```
#### Parameters

<a name='Wawa.Optionals.Maybe_T_.op_ExplicitT(Wawa.Optionals.Maybe_T_).value'></a>

`value` [Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe_T_.md#Wawa.Optionals.Maybe_T_.T 'Wawa.Optionals.Maybe<T>.T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')

The [T](Maybe_T_.md#Wawa.Optionals.Maybe_T_.T 'Wawa.Optionals.Maybe<T>.T') instance to convert.

#### Returns
[T](Maybe_T_.md#Wawa.Optionals.Maybe_T_.T 'Wawa.Optionals.Maybe<T>.T')  
The inner value.

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The parameter [value](Maybe_T_.op_Explicit(Maybe).md#Wawa.Optionals.Maybe_T_.op_ExplicitT(Wawa.Optionals.Maybe_T_).value 'Wawa.Optionals.Maybe<T>.op_Explicit T(Wawa.Optionals.Maybe<T>).value') is a None value.