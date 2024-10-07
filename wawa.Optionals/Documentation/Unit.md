### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals')

## Unit Struct

A type that has exactly one value, and is used when there is no other meaningful value that could be returned.  
<p/>`[PublicAPI]`

```csharp
public readonly struct Unit :
System.IComparable<wawa.Optionals.Unit>,
System.Collections.Generic.IComparer<wawa.Optionals.Unit>,
System.ICloneable,
System.Collections.Generic.IEnumerable<wawa.Optionals.Unit>,
System.Collections.IEnumerable,
System.IEquatable<wawa.Optionals.Unit>,
System.Collections.Generic.IEqualityComparer<wawa.Optionals.Unit>,
System.IFormattable
```

Implements [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[Unit](Unit.md 'wawa.Optionals.Unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[Unit](Unit.md 'wawa.Optionals.Unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1'), [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Unit](Unit.md 'wawa.Optionals.Unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Unit](Unit.md 'wawa.Optionals.Unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[Unit](Unit.md 'wawa.Optionals.Unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1'), [System.IFormattable](https://docs.microsoft.com/en-us/dotnet/api/System.IFormattable 'System.IFormattable')

| Fields | |
| :--- | :--- |
| [AsString](Unit.AsString.md 'wawa.Optionals.Unit.AsString') | Gets the string representation of [Unit](Unit.md 'wawa.Optionals.Unit').<p/>`[NotNull, PublicAPI]` |

| Properties | |
| :--- | :--- |
| [Value](Unit.Value.md 'wawa.Optionals.Unit.Value') | Gets the singular value.<p/>`[PublicAPI]` |

| Operators | |
| :--- | :--- |
| [operator ==(Unit, Unit)](Unit.op_Equality(Unit,Unit).md 'wawa.Optionals.Unit.op_Equality(wawa.Optionals.Unit, wawa.Optionals.Unit)') | Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').<p/>`[PublicAPI]` |
| [operator &gt;(Unit, Unit)](Unit.op_GreaterThan(Unit,Unit).md 'wawa.Optionals.Unit.op_GreaterThan(wawa.Optionals.Unit, wawa.Optionals.Unit)') | Returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').<p/>`[PublicAPI]` |
| [operator &gt;=(Unit, Unit)](Unit.op_GreaterThanOrEqual(Unit,Unit).md 'wawa.Optionals.Unit.op_GreaterThanOrEqual(wawa.Optionals.Unit, wawa.Optionals.Unit)') | Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').<p/>`[PublicAPI]` |
| [operator !=(Unit, Unit)](Unit.op_Inequality(Unit,Unit).md 'wawa.Optionals.Unit.op_Inequality(wawa.Optionals.Unit, wawa.Optionals.Unit)') | Returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').<p/>`[PublicAPI]` |
| [operator &lt;(Unit, Unit)](Unit.op_LessThan(Unit,Unit).md 'wawa.Optionals.Unit.op_LessThan(wawa.Optionals.Unit, wawa.Optionals.Unit)') | Returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').<p/>`[PublicAPI]` |
| [operator &lt;=(Unit, Unit)](Unit.op_LessThanOrEqual(Unit,Unit).md 'wawa.Optionals.Unit.op_LessThanOrEqual(wawa.Optionals.Unit, wawa.Optionals.Unit)') | Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').<p/>`[PublicAPI]` |
