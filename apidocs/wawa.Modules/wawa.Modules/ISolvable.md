# ISolvable Interface

namespace: [wawa\.Modules](../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../wawa.Modules.md)

Interface for Twitch Plays auto\-solvers\. Used by `Module` to abstractly communicate
with Twitch Plays solvers without importing the namespace\.

```csharp
public interface ISolvable;
```

## Methods

| Name | Summary |
|------|---------|
| [ForceTPSolve\(\)](./ISolvable/ForceTPSolve.md) | When the module runs into an exception or the module is forced to be solved, it calls this method\. |

## Properties

| Name | Summary |
|------|---------|
| [IsTP](./ISolvable/IsTP.md) | Gets a value indicating whether Twitch Plays is currently active\. |

