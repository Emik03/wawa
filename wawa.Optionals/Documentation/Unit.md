### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals')

## Unit Struct

A type that has exactly one value, and is used when there is no other meaningful value that could be returned.

```csharp
public readonly struct Unit :
System.ICloneable,
System.IEquatable<Wawa.Optionals.Unit>,
System.Collections.Generic.IEqualityComparer<Wawa.Optionals.Unit>
```

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Unit](Unit.md 'Wawa.Optionals.Unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[Unit](Unit.md 'Wawa.Optionals.Unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

| Properties | |
| :--- | :--- |
| [Value](Unit.Value.md 'Wawa.Optionals.Unit.Value') | Gets the singular value. |

| Operators | |
| :--- | :--- |
| [operator ==(Unit, Unit)](Unit.op_Equality.wBgv71X9hcNKerlxmvwv0Q.md 'Wawa.Optionals.Unit.op_Equality(Wawa.Optionals.Unit, Wawa.Optionals.Unit)') | Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'). |
| [operator !=(Unit, Unit)](Unit.op_Inequality.h+EpKbrcAD4j9WmfpXzabg.md 'Wawa.Optionals.Unit.op_Inequality(Wawa.Optionals.Unit, Wawa.Optionals.Unit)') | Returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'). |
