# State Class

namespace: [wawa\.Modules](../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../wawa.Modules.md)

Encapsulation of status conditions for a [ModdedModule](../../wawa.Modules/wawa.Modules/ModdedModule.md)\.

```csharp
public sealed class State;
```

Inheritance: `ICloneable` > State

Implements: `IEquatable<State>`, `IEqualityComparer<State>`

## Methods

| Name | Summary |
|------|---------|
| [Clone\(\)](./State/Clone.md) |  |
| [Equals\(State, State\)](./State/Equals.md) |  |
| [GetHashCode\(State\)](./State/GetHashCode.md) |  |
| [Equals\(State\)](./State/Equals.md) |  |
| [operator ==\(State, State\)](./State/op_Equality.md) | Determines whether both instances contain the same values\. |
| [operator \!=\(State, State\)](./State/op_Inequality.md) | Determines whether both instances do not contain the same values\. |
| [Equals\(object\)](./State/Equals.md) |  |
| [GetHashCode\(\)](./State/GetHashCode.md) |  |
| [ToString\(\)](./State/ToString.md) |  |

## Properties

| Name | Summary |
|------|---------|
| [HasStruck](./State/HasStruck.md) | Gets or sets a value indicating whether the module has ever called [Strike\(string, params object\[\]\)](../../wawa.Modules/wawa.Modules/ModdedModule/Strike.md)\. |
| [IsSolved](./State/IsSolved.md) | Gets a value indicating whether the module is solved\. |
| [Id](./State/Id.md) | Gets the unique module id of this module type, primarily used in logging\. |

