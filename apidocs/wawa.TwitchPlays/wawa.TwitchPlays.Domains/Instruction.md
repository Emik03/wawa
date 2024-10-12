# Instruction Class

namespace: [wawa\.TwitchPlays\.Domains](../wawa.TwitchPlays.Domains.md)<br />
assembly: [wawa\.TwitchPlays](../../wawa.TwitchPlays.md)

Defines an instruction for Twitch Plays to process\.

```csharp
public sealed class Instruction;
```

Inheritance: `ICloneable` > Instruction

Implements: `IEquatable<Instruction>`, `IEqualityComparer<Instruction>`

## Remarks



Based on the advanced implementation documentation:
https://github\.com/samfundev/KtaneTwitchPlays/wiki/External\-Mod\-Module\-Support\#advanced\-implementation\.



## Constructors

| Name | Summary |
|------|---------|
| [Instruction\(string, string\)](./Instruction/$ctor.md) | Initializes a new instance of the [Instruction](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) class\. |
| [Instruction\(IEnumerable\<Instruction\>\)](./Instruction/$ctor.md) | Initializes a new instance of the [Instruction](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) class\. |
| [Instruction\(IEnumerator\<Instruction\>\)](./Instruction/$ctor.md) | Initializes a new instance of the [Instruction](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) class\. |
| [Instruction\(Quaternion, Quaternion\)](./Instruction/$ctor.md) | Initializes a new instance of the [Instruction](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) class\. |
| [Instruction\(TwitchString\)](./Instruction/$ctor.md) | Initializes a new instance of the [Instruction](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) class\. |

## Methods

| Name | Summary |
|------|---------|
| [Clone\(\)](./Instruction/Clone.md) |  |
| [Equals\(Instruction, Instruction\)](./Instruction/Equals.md) |  |
| [GetHashCode\(Instruction\)](./Instruction/GetHashCode.md) |  |
| [Equals\(Instruction\)](./Instruction/Equals.md) |  |
| [implicit operator Instruction\(CustomYieldInstruction\)](./Instruction/op_Implicit.md) | Implicitly calls the constructor\. |
| [implicit operator Instruction\(KMSelectable\)](./Instruction/op_Implicit.md) | Implicitly calls the constructor\. |
| [implicit operator Instruction\(KMSelectable\[\]\)](./Instruction/op_Implicit.md) | Implicitly calls the constructor\. |
| [implicit operator Instruction\(Quaternion\)](./Instruction/op_Implicit.md) | Implicitly calls the constructor\. |
| [implicit operator Instruction\(TwitchString\)](./Instruction/op_Implicit.md) | Implicitly calls the constructor\. |
| [implicit operator Instruction\(YieldInstruction\)](./Instruction/op_Implicit.md) | Implicitly calls the constructor\. |
| [operator ==\(Instruction, Instruction\)](./Instruction/op_Equality.md) | Determines whether both instances contain the same values\. |
| [operator \!=\(Instruction, Instruction\)](./Instruction/op_Inequality.md) | Determines whether both instances do not contain the same values\. |
| [FromCustomYieldInstruction\(CustomYieldInstruction\)](./Instruction/FromCustomYieldInstruction.md) | Converts the `CustomYieldInstruction` to a `new`[Instruction](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)\. |
| [FromInstructions\(IEnumerable\<Instruction\>\)](./Instruction/FromInstructions.md) | Converts the `IEnumerable<T>` to a `new`[Instruction](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)\. |
| [FromInstructions\(IEnumerator\<Instruction\>\)](./Instruction/FromInstructions.md) | Converts the `IEnumerator<T>` to a `new`[Instruction](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)\. |
| [FromInstructions\(params Instruction\[\]\)](./Instruction/FromInstructions.md) | Converts the `Array` to a `new`[Instruction](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)\. |
| [FromKMSelectable\(KMSelectable\)](./Instruction/FromKMSelectable.md) | Converts the `KMSelectable` to a `new`[Instruction](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)\. |
| [FromKMSelectableArray\(params KMSelectable\[\]\)](./Instruction/FromKMSelectableArray.md) | Converts the `KMSelectable``Array`to a `new`[Instruction](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)\. |
| [FromQuaternion\(Quaternion\)](./Instruction/FromQuaternion.md) | Converts the `Quaternion` to a `new`[Instruction](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)\. |
| [FromTwitchString\(TwitchString\)](./Instruction/FromTwitchString.md) | Converts the [TwitchString](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/TwitchString.md) to a `new`[Instruction](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)\. |
| [FromYieldInstruction\(YieldInstruction\)](./Instruction/FromYieldInstruction.md) | Converts the `YieldInstruction` to a `new`[Instruction](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)\. |
| [Equals\(object\)](./Instruction/Equals.md) |  |
| [GetHashCode\(\)](./Instruction/GetHashCode.md) |  |
| [ToString\(\)](./Instruction/ToString.md) |  |

## Properties

| Name | Summary |
|------|---------|
| [FrameAdvance](./Instruction/FrameAdvance.md) | Gets the value that can be yielded to wait for the next frame\. |
| [Pause](./Instruction/Pause.md) | Gets the value that can be yielded to allow other modules to be processed in Twitch Plays\. |
| [UsableInForcedSolve](./Instruction/UsableInForcedSolve.md) | Gets a value indicating whether this current instance contains a value that can beevaluated by both the Twitch Plays command processor for users, and the forced solver,or whether it can only be strictly used for the Twitch Plays command processor\. |

