### [Wawa.Modules](Wawa.Modules.md 'Wawa.Modules')

## State Class

Encapsulation of status conditions for a [ModdedModule](ModdedModule.md 'Wawa.Modules.ModdedModule').

```csharp
public sealed class State :
System.ICloneable,
System.IEquatable<Wawa.Modules.State>,
System.Collections.Generic.IEqualityComparer<Wawa.Modules.State>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; State

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[State](State.md 'Wawa.Modules.State')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[State](State.md 'Wawa.Modules.State')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

| Properties | |
| :--- | :--- |
| [HasStruck](State.HasStruck.md 'Wawa.Modules.State.HasStruck') | Gets or sets a value indicating whether the module has ever called [Strike(string, object[])](ModdedModule.Strike(string,object[]).md 'Wawa.Modules.ModdedModule.Strike(string, object[])'). |
| [Id](State.Id.md 'Wawa.Modules.State.Id') | Gets the unique module id of this module type, primarily used in logging. |
| [IsSolved](State.IsSolved.md 'Wawa.Modules.State.IsSolved') | Gets a value indicating whether the module is solved. |

| Operators | |
| :--- | :--- |
| [operator ==(State, State)](State.op_Equality(State,State).md 'Wawa.Modules.State.op_Equality(Wawa.Modules.State, Wawa.Modules.State)') | Determines whether both instances contain the same values. |
| [operator !=(State, State)](State.op_Inequality(State,State).md 'Wawa.Modules.State.op_Inequality(Wawa.Modules.State, Wawa.Modules.State)') | Determines whether both instances do not contain the same values. |
