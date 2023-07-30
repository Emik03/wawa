### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals')

## Maybe<T> Struct

A type representing an optional value; Either Some and contains a value, or None, and does not.

```csharp
public readonly struct Maybe<T> :
System.Collections.ICollection,
System.Collections.IEnumerable,
System.IComparable<Wawa.Optionals.Maybe<T>>,
System.Collections.Generic.IComparer<Wawa.Optionals.Maybe<T>>,
System.ICloneable,
System.IEquatable<Wawa.Optionals.Maybe<T>>,
System.Collections.Generic.IEqualityComparer<Wawa.Optionals.Maybe<T>>,
System.IFormattable,
System.Collections.Generic.IList<T>,
System.Collections.Generic.ICollection<T>,
System.Collections.Generic.IEnumerable<T>
```
#### Type parameters

<a name='Wawa.Optionals.Maybe_T_.T'></a>

`T`

The type to encapsulate and project as an optional value.

Implements [System.Collections.ICollection](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ICollection 'System.Collections.ICollection'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[Wawa.Optionals.Maybe&lt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[T](Maybe{T}.md#Wawa.Optionals.Maybe_T_.T 'Wawa.Optionals.Maybe<T>.T')[&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[Wawa.Optionals.Maybe&lt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[T](Maybe{T}.md#Wawa.Optionals.Maybe_T_.T 'Wawa.Optionals.Maybe<T>.T')[&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1'), [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Wawa.Optionals.Maybe&lt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[T](Maybe{T}.md#Wawa.Optionals.Maybe_T_.T 'Wawa.Optionals.Maybe<T>.T')[&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[Wawa.Optionals.Maybe&lt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[T](Maybe{T}.md#Wawa.Optionals.Maybe_T_.T 'Wawa.Optionals.Maybe<T>.T')[&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1'), [System.IFormattable](https://docs.microsoft.com/en-us/dotnet/api/System.IFormattable 'System.IFormattable'), [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](Maybe{T}.md#Wawa.Optionals.Maybe_T_.T 'Wawa.Optionals.Maybe<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1'), [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[T](Maybe{T}.md#Wawa.Optionals.Maybe_T_.T 'Wawa.Optionals.Maybe<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Maybe{T}.md#Wawa.Optionals.Maybe_T_.T 'Wawa.Optionals.Maybe<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

| Constructors | |
| :--- | :--- |
| [Maybe(T)](Maybe{T}..ctor(T).md 'Wawa.Optionals.Maybe<T>.Maybe(T)') | A type representing an optional value; Either Some and contains a value, or None, and does not. |

| Properties | |
| :--- | :--- |
| [IsNone](Maybe{T}.IsNone.md 'Wawa.Optionals.Maybe<T>.IsNone') | Gets a value indicating whether the value encapsulated is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'). |
| [IsSome](Maybe{T}.IsSome.md 'Wawa.Optionals.Maybe<T>.IsSome') | Gets a value indicating whether the value encapsulated is not [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'). |
| [Value](Maybe{T}.Value.md 'Wawa.Optionals.Maybe<T>.Value') | Gets the value that is encapsulated. This value returned may be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'). |

| Operators | |
| :--- | :--- |
| [operator &(Maybe&lt;T&gt;, Maybe&lt;T&gt;)](Maybe{T}.op_BitwiseAnd(Maybe{T},Maybe{T}).md 'Wawa.Optionals.Maybe<T>.op_BitwiseAnd(Wawa.Optionals.Maybe<T>, Wawa.Optionals.Maybe<T>)') | Gives itself, or the parameter. |
| [operator |(Maybe&lt;T&gt;, T)](Maybe{T}.op_BitwiseOr(Maybe{T},T).md 'Wawa.Optionals.Maybe<T>.op_BitwiseOr(Wawa.Optionals.Maybe<T>, T)') | Gives the inner value, or the parameter. |
| [operator |(Maybe&lt;T&gt;, Maybe&lt;T&gt;)](Maybe{T}.op_BitwiseOr(Maybe{T},Maybe{T}).md 'Wawa.Optionals.Maybe<T>.op_BitwiseOr(Wawa.Optionals.Maybe<T>, Wawa.Optionals.Maybe<T>)') | Gives itself, or the parameter. |
| [operator ==(Maybe&lt;T&gt;, Maybe&lt;T&gt;)](Maybe{T}.op_Equality(Maybe{T},Maybe{T}).md 'Wawa.Optionals.Maybe<T>.op_Equality(Wawa.Optionals.Maybe<T>, Wawa.Optionals.Maybe<T>)') | Determines whether both instances contain the same values. |
| [operator ^(Maybe&lt;T&gt;, Maybe&lt;T&gt;)](Maybe{T}.op_ExclusiveOr(Maybe{T},Maybe{T}).md 'Wawa.Optionals.Maybe<T>.op_ExclusiveOr(Wawa.Optionals.Maybe<T>, Wawa.Optionals.Maybe<T>)') | Gives itself, or the parameter. |
| [explicit operator T(Maybe&lt;T&gt;)](Maybe{T}.T(Maybe{T}).md 'Wawa.Optionals.Maybe<T>.op_Explicit T(Wawa.Optionals.Maybe<T>)') | Converts the [Maybe&lt;T&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>') to [T](Maybe{T}.md#Wawa.Optionals.Maybe_T_.T 'Wawa.Optionals.Maybe<T>.T'). |
| [operator false(Maybe&lt;T&gt;)](Maybe{T}.op_False(Maybe{T}).md 'Wawa.Optionals.Maybe<T>.op_False(Wawa.Optionals.Maybe<T>)') | Gets a value indicating whether the value encapsulated is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'). |
| [operator &gt;(Maybe&lt;T&gt;, Maybe&lt;T&gt;)](Maybe{T}.op_GreaterThan(Maybe{T},Maybe{T}).md 'Wawa.Optionals.Maybe<T>.op_GreaterThan(Wawa.Optionals.Maybe<T>, Wawa.Optionals.Maybe<T>)') | Determines whether the left-hand side is more than the right. |
| [operator &gt;=(Maybe&lt;T&gt;, Maybe&lt;T&gt;)](Maybe{T}.op_GreaterThanOrEqual(Maybe{T},Maybe{T}).md 'Wawa.Optionals.Maybe<T>.op_GreaterThanOrEqual(Wawa.Optionals.Maybe<T>, Wawa.Optionals.Maybe<T>)') | Determines whether the left-hand side is equal to or more than the right. |
| [implicit operator Maybe&lt;T&gt;(T)](Maybe{T}.Maybe(T).md 'Wawa.Optionals.Maybe<T>.op_Implicit Wawa.Optionals.Maybe<T>(T)') | Converts the [T](Maybe{T}.md#Wawa.Optionals.Maybe_T_.T 'Wawa.Optionals.Maybe<T>.T') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Maybe&lt;T&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>'). |
| [operator !=(Maybe&lt;T&gt;, Maybe&lt;T&gt;)](Maybe{T}.op_Inequality(Maybe{T},Maybe{T}).md 'Wawa.Optionals.Maybe<T>.op_Inequality(Wawa.Optionals.Maybe<T>, Wawa.Optionals.Maybe<T>)') | Determines whether both instances do not contain the same values. |
| [operator &lt;(Maybe&lt;T&gt;, Maybe&lt;T&gt;)](Maybe{T}.op_LessThan(Maybe{T},Maybe{T}).md 'Wawa.Optionals.Maybe<T>.op_LessThan(Wawa.Optionals.Maybe<T>, Wawa.Optionals.Maybe<T>)') | Determines whether the left-hand side is less than the right. |
| [operator &lt;=(Maybe&lt;T&gt;, Maybe&lt;T&gt;)](Maybe{T}.op_LessThanOrEqual(Maybe{T},Maybe{T}).md 'Wawa.Optionals.Maybe<T>.op_LessThanOrEqual(Wawa.Optionals.Maybe<T>, Wawa.Optionals.Maybe<T>)') | Determines whether the left-hand side is equal to or less than the right. |
| [operator true(Maybe&lt;T&gt;)](Maybe{T}.op_True(Maybe{T}).md 'Wawa.Optionals.Maybe<T>.op_True(Wawa.Optionals.Maybe<T>)') | Gets a value indicating whether the value encapsulated is not [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'). |
