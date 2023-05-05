#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains')

## Instruction Class

Defines an instruction for Twitch Plays to process.

```csharp
public sealed class Instruction :
System.ICloneable,
System.IEquatable<Wawa.TwitchPlays.Domains.Instruction>,
System.Collections.Generic.IEqualityComparer<Wawa.TwitchPlays.Domains.Instruction>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Instruction

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

### Remarks
  
Based on the advanced implementation documentation:  
https://github.com/samfundev/KtaneTwitchPlays/wiki/External-Mod-Module-Support#advanced-implementation.

| Constructors | |
| :--- | :--- |
| [Instruction(Quaternion, Quaternion)](Instruction..ctor(Quaternion,Quaternion).md 'Wawa.TwitchPlays.Domains.Instruction.Instruction(Quaternion, Quaternion)') | Initializes a new instance of the [Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction') class. |
| [Instruction(string, string)](Instruction..ctor(String,String).md 'Wawa.TwitchPlays.Domains.Instruction.Instruction(string, string)') | Initializes a new instance of the [Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction') class. |
| [Instruction(IEnumerable&lt;Instruction&gt;)](Instruction..ctor(IEnumerable{Instruction}).md 'Wawa.TwitchPlays.Domains.Instruction.Instruction(System.Collections.Generic.IEnumerable<Wawa.TwitchPlays.Domains.Instruction>)') | Initializes a new instance of the [Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction') class. |
| [Instruction(IEnumerator&lt;Instruction&gt;)](Instruction..ctor(IEnumerator{Instruction}).md 'Wawa.TwitchPlays.Domains.Instruction.Instruction(System.Collections.Generic.IEnumerator<Wawa.TwitchPlays.Domains.Instruction>)') | Initializes a new instance of the [Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction') class. |
| [Instruction(TwitchString)](Instruction..ctor(TwitchString).md 'Wawa.TwitchPlays.Domains.Instruction.Instruction(Wawa.TwitchPlays.Domains.TwitchString)') | Initializes a new instance of the [Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction') class. |

| Properties | |
| :--- | :--- |
| [FrameAdvance](Instruction.FrameAdvance.md 'Wawa.TwitchPlays.Domains.Instruction.FrameAdvance') | Gets the value that can be yielded to wait for the next frame. |
| [Pause](Instruction.Pause.md 'Wawa.TwitchPlays.Domains.Instruction.Pause') | Gets the value that can be yielded to allow other modules to be processed in Twitch Plays. |

| Methods | |
| :--- | :--- |
| [FromCustomYieldInstruction(CustomYieldInstruction)](Instruction.FromCustomYieldInstruction(CustomYieldInstruction).md 'Wawa.TwitchPlays.Domains.Instruction.FromCustomYieldInstruction(CustomYieldInstruction)') | Converts the [UnityEngine.CustomYieldInstruction](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.CustomYieldInstruction 'UnityEngine.CustomYieldInstruction') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |
| [FromInstructions(IEnumerable&lt;Instruction&gt;)](Instruction.FromInstructions(IEnumerable{Instruction}).md 'Wawa.TwitchPlays.Domains.Instruction.FromInstructions(System.Collections.Generic.IEnumerable<Wawa.TwitchPlays.Domains.Instruction>)') | Converts the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |
| [FromInstructions(IEnumerator&lt;Instruction&gt;)](Instruction.FromInstructions(IEnumerator{Instruction}).md 'Wawa.TwitchPlays.Domains.Instruction.FromInstructions(System.Collections.Generic.IEnumerator<Wawa.TwitchPlays.Domains.Instruction>)') | Converts the [System.Collections.Generic.IEnumerator&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |
| [FromInstructions(Instruction[])](Instruction.FromInstructions(Instruction[]).md 'Wawa.TwitchPlays.Domains.Instruction.FromInstructions(Wawa.TwitchPlays.Domains.Instruction[])') | Converts the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |
| [FromKMSelectable(KMSelectable)](Instruction.FromKMSelectable(KMSelectable).md 'Wawa.TwitchPlays.Domains.Instruction.FromKMSelectable(KMSelectable)') | Converts the [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |
| [FromKMSelectableArray(KMSelectable[])](Instruction.FromKMSelectableArray(KMSelectable[]).md 'Wawa.TwitchPlays.Domains.Instruction.FromKMSelectableArray(KMSelectable[])') | Converts the [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')<br/>to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |
| [FromQuaternion(Quaternion)](Instruction.FromQuaternion(Quaternion).md 'Wawa.TwitchPlays.Domains.Instruction.FromQuaternion(Quaternion)') | Converts the [UnityEngine.Quaternion](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Quaternion 'UnityEngine.Quaternion') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |
| [FromTwitchString(TwitchString)](Instruction.FromTwitchString(TwitchString).md 'Wawa.TwitchPlays.Domains.Instruction.FromTwitchString(Wawa.TwitchPlays.Domains.TwitchString)') | Converts the [TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |
| [FromYieldInstruction(YieldInstruction)](Instruction.FromYieldInstruction(YieldInstruction).md 'Wawa.TwitchPlays.Domains.Instruction.FromYieldInstruction(YieldInstruction)') | Converts the [UnityEngine.YieldInstruction](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.YieldInstruction 'UnityEngine.YieldInstruction') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |

| Operators | |
| :--- | :--- |
| [operator ==(Instruction, Instruction)](Instruction.op_Equality(Instruction,Instruction).md 'Wawa.TwitchPlays.Domains.Instruction.op_Equality(Wawa.TwitchPlays.Domains.Instruction, Wawa.TwitchPlays.Domains.Instruction)') | Determines whether both instances contain the same values. |
| [implicit operator Instruction(CustomYieldInstruction)](Instruction.Instruction(CustomYieldInstruction).md 'Wawa.TwitchPlays.Domains.Instruction.op_Implicit Wawa.TwitchPlays.Domains.Instruction(CustomYieldInstruction)') | Implicitly calls the constructor. |
| [implicit operator Instruction(KMSelectable)](Instruction.Instruction(KMSelectable).md 'Wawa.TwitchPlays.Domains.Instruction.op_Implicit Wawa.TwitchPlays.Domains.Instruction(KMSelectable)') | Implicitly calls the constructor. |
| [implicit operator Instruction(KMSelectable[])](Instruction.Instruction(KMSelectable[]).md 'Wawa.TwitchPlays.Domains.Instruction.op_Implicit Wawa.TwitchPlays.Domains.Instruction(KMSelectable[])') | Implicitly calls the constructor. |
| [implicit operator Instruction(Quaternion)](Instruction.Instruction(Quaternion).md 'Wawa.TwitchPlays.Domains.Instruction.op_Implicit Wawa.TwitchPlays.Domains.Instruction(Quaternion)') | Implicitly calls the constructor. |
| [implicit operator Instruction(TwitchString)](Instruction.Instruction(TwitchString).md 'Wawa.TwitchPlays.Domains.Instruction.op_Implicit Wawa.TwitchPlays.Domains.Instruction(Wawa.TwitchPlays.Domains.TwitchString)') | Implicitly calls the constructor. |
| [implicit operator Instruction(YieldInstruction)](Instruction.Instruction(YieldInstruction).md 'Wawa.TwitchPlays.Domains.Instruction.op_Implicit Wawa.TwitchPlays.Domains.Instruction(YieldInstruction)') | Implicitly calls the constructor. |
| [operator !=(Instruction, Instruction)](Instruction.op_Inequality(Instruction,Instruction).md 'Wawa.TwitchPlays.Domains.Instruction.op_Inequality(Wawa.TwitchPlays.Domains.Instruction, Wawa.TwitchPlays.Domains.Instruction)') | Determines whether both instances do not contain the same values. |
