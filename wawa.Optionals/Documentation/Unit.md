### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals')

## Unit Struct

A type that has exactly one value, and is used when there is no other meaningful value that could be returned.

```csharp
public readonly struct Unit :
System.IComparable<Wawa.Optionals.Unit>,
System.Collections.Generic.IComparer<Wawa.Optionals.Unit>,
System.ICloneable,
System.Collections.Generic.IEnumerable<Wawa.Optionals.Unit>,
System.Collections.IEnumerable,
System.IEquatable<Wawa.Optionals.Unit>,
System.Collections.Generic.IEqualityComparer<Wawa.Optionals.Unit>,
System.IFormattable
```

Implements [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[Unit](Unit.md 'Wawa.Optionals.Unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[Unit](Unit.md 'Wawa.Optionals.Unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1'), [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Unit](Unit.md 'Wawa.Optionals.Unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Unit](Unit.md 'Wawa.Optionals.Unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[Unit](Unit.md 'Wawa.Optionals.Unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1'), [System.IFormattable](https://docs.microsoft.com/en-us/dotnet/api/System.IFormattable 'System.IFormattable')

| Fields | |
| :--- | :--- |
| [AsString](Unit.AsString.md 'Wawa.Optionals.Unit.AsString') | Gets the string representation of [Unit](Unit.md 'Wawa.Optionals.Unit'). |

| Properties | |
| :--- | :--- |
| [Value](Unit.Value.md 'Wawa.Optionals.Unit.Value') | Gets the singular value. |

| Operators | |
| :--- | :--- |
| [operator ==(Unit, Unit)](Unit.op_Equality(Unit,Unit).md 'Wawa.Optionals.Unit.op_Equality(Wawa.Optionals.Unit, Wawa.Optionals.Unit)') | Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'). |
| [operator &gt;(Unit, Unit)](Unit.op_GreaterThan(Unit,Unit).md 'Wawa.Optionals.Unit.op_GreaterThan(Wawa.Optionals.Unit, Wawa.Optionals.Unit)') | Returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'). |
| [operator &gt;=(Unit, Unit)](Unit.op_GreaterThanOrEqual(Unit,Unit).md 'Wawa.Optionals.Unit.op_GreaterThanOrEqual(Wawa.Optionals.Unit, Wawa.Optionals.Unit)') | Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'). |
| [operator !=(Unit, Unit)](Unit.op_Inequality(Unit,Unit).md 'Wawa.Optionals.Unit.op_Inequality(Wawa.Optionals.Unit, Wawa.Optionals.Unit)') | Returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'). |
| [operator &lt;(Unit, Unit)](Unit.op_LessThan(Unit,Unit).md 'Wawa.Optionals.Unit.op_LessThan(Wawa.Optionals.Unit, Wawa.Optionals.Unit)') | Returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'). |
| [operator &lt;=(Unit, Unit)](Unit.op_LessThanOrEqual(Unit,Unit).md 'Wawa.Optionals.Unit.op_LessThanOrEqual(Wawa.Optionals.Unit, Wawa.Optionals.Unit)') | Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'). |
