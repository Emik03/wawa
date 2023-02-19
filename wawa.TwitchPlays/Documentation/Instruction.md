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
| [Instruction(Quaternion, Quaternion)](Instruction..ctor.fjrDW7fta7KK7liXPYO5lw.md 'Wawa.TwitchPlays.Domains.Instruction.Instruction(Quaternion, Quaternion)') | Initializes a new instance of the [Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction') class. |
| [Instruction(string, string)](Instruction..ctor.5VKCgxhfAtz+3OKDgYjutw.md 'Wawa.TwitchPlays.Domains.Instruction.Instruction(string, string)') | Initializes a new instance of the [Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction') class. |
| [Instruction(IEnumerable&lt;Instruction&gt;)](Instruction..ctor.WpqhyL6v9fOzFDrer35x4g.md 'Wawa.TwitchPlays.Domains.Instruction.Instruction(System.Collections.Generic.IEnumerable<Wawa.TwitchPlays.Domains.Instruction>)') | Initializes a new instance of the [Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction') class. |
| [Instruction(IEnumerator&lt;Instruction&gt;)](Instruction..ctor.RRuqZrfI9KkJIZXEwM/6nA.md 'Wawa.TwitchPlays.Domains.Instruction.Instruction(System.Collections.Generic.IEnumerator<Wawa.TwitchPlays.Domains.Instruction>)') | Initializes a new instance of the [Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction') class. |
| [Instruction(TwitchString)](Instruction..ctor.miedG/wvDmgAo+0HSd8h1Q.md 'Wawa.TwitchPlays.Domains.Instruction.Instruction(Wawa.TwitchPlays.Domains.TwitchString)') | Initializes a new instance of the [Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction') class. |

| Properties | |
| :--- | :--- |
| [FrameAdvance](Instruction.FrameAdvance.md 'Wawa.TwitchPlays.Domains.Instruction.FrameAdvance') | Gets the value that can be yielded to wait for the next frame. |
| [Pause](Instruction.Pause.md 'Wawa.TwitchPlays.Domains.Instruction.Pause') | Gets the value that can be yielded to allow other modules to be processed in Twitch Plays. |

| Methods | |
| :--- | :--- |
| [FromCustomYieldInstruction(CustomYieldInstruction)](Instruction.FromCustomYieldInstruction.WV4gqQKXeoEAELCvHxg/Uw.md 'Wawa.TwitchPlays.Domains.Instruction.FromCustomYieldInstruction(CustomYieldInstruction)') | Converts the [UnityEngine.CustomYieldInstruction](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.CustomYieldInstruction 'UnityEngine.CustomYieldInstruction') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |
| [FromInstructions(IEnumerable&lt;Instruction&gt;)](Instruction.FromInstructions.a3R1iUy8DnPPzu+6KTWaEw.md 'Wawa.TwitchPlays.Domains.Instruction.FromInstructions(System.Collections.Generic.IEnumerable<Wawa.TwitchPlays.Domains.Instruction>)') | Converts the [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |
| [FromInstructions(IEnumerator&lt;Instruction&gt;)](Instruction.FromInstructions.FZd5E10SowUNxFRrHPCeqg.md 'Wawa.TwitchPlays.Domains.Instruction.FromInstructions(System.Collections.Generic.IEnumerator<Wawa.TwitchPlays.Domains.Instruction>)') | Converts the [System.Collections.Generic.IEnumerator&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |
| [FromInstructions(Instruction[])](Instruction.FromInstructions.bX0owrxV4v67wUUG7Uf/Dg.md 'Wawa.TwitchPlays.Domains.Instruction.FromInstructions(Wawa.TwitchPlays.Domains.Instruction[])') | Converts the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |
| [FromKMSelectable(KMSelectable)](Instruction.FromKMSelectable.rgS/NM1xFBJvzWh69H0GIw.md 'Wawa.TwitchPlays.Domains.Instruction.FromKMSelectable(KMSelectable)') | Converts the [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |
| [FromKMSelectableArray(KMSelectable[])](Instruction.FromKMSelectableArray.IeSEwuoLPZtQB+p3b2rY7Q.md 'Wawa.TwitchPlays.Domains.Instruction.FromKMSelectableArray(KMSelectable[])') | Converts the [KMSelectable](https://docs.microsoft.com/en-us/dotnet/api/KMSelectable 'KMSelectable')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')<br/>to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |
| [FromQuaternion(Quaternion)](Instruction.FromQuaternion.NqcUJ0RlNYZflPuTHDVDKA.md 'Wawa.TwitchPlays.Domains.Instruction.FromQuaternion(Quaternion)') | Converts the [UnityEngine.Quaternion](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Quaternion 'UnityEngine.Quaternion') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |
| [FromTwitchString(TwitchString)](Instruction.FromTwitchString.OWz7vZUNxT9liNfA1wvadA.md 'Wawa.TwitchPlays.Domains.Instruction.FromTwitchString(Wawa.TwitchPlays.Domains.TwitchString)') | Converts the [TwitchString](TwitchString.md 'Wawa.TwitchPlays.Domains.TwitchString') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |
| [FromYieldInstruction(YieldInstruction)](Instruction.FromYieldInstruction.t5HEZqxHCPq5bfqdRFdlyw.md 'Wawa.TwitchPlays.Domains.Instruction.FromYieldInstruction(YieldInstruction)') | Converts the [UnityEngine.YieldInstruction](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.YieldInstruction 'UnityEngine.YieldInstruction') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction'). |

| Operators | |
| :--- | :--- |
| [operator ==(Instruction, Instruction)](Instruction.op_Equality.XsgTiD1aArVB9exd4PNmtQ.md 'Wawa.TwitchPlays.Domains.Instruction.op_Equality(Wawa.TwitchPlays.Domains.Instruction, Wawa.TwitchPlays.Domains.Instruction)') | Determines whether both instances contain the same values. |
| [implicit operator Instruction(CustomYieldInstruction)](Instruction.op_Implicit.HPiJhhP07r21iAZQ+ej/xw.md 'Wawa.TwitchPlays.Domains.Instruction.op_Implicit Wawa.TwitchPlays.Domains.Instruction(CustomYieldInstruction)') | Implicitly calls the constructor. |
| [implicit operator Instruction(KMSelectable)](Instruction.op_Implicit.nK/tGHHjv6FQHBA6r2SS2g.md 'Wawa.TwitchPlays.Domains.Instruction.op_Implicit Wawa.TwitchPlays.Domains.Instruction(KMSelectable)') | Implicitly calls the constructor. |
| [implicit operator Instruction(KMSelectable[])](Instruction.op_Implicit.2fP2jWKPbW0S6Itpt4JL2w.md 'Wawa.TwitchPlays.Domains.Instruction.op_Implicit Wawa.TwitchPlays.Domains.Instruction(KMSelectable[])') | Implicitly calls the constructor. |
| [implicit operator Instruction(Quaternion)](Instruction.op_Implicit.K+2VOCmCNXnzLCPJVS61ag.md 'Wawa.TwitchPlays.Domains.Instruction.op_Implicit Wawa.TwitchPlays.Domains.Instruction(Quaternion)') | Implicitly calls the constructor. |
| [implicit operator Instruction(TwitchString)](Instruction.op_Implicit.k0GQrQlCT6snFcP+9jPQLg.md 'Wawa.TwitchPlays.Domains.Instruction.op_Implicit Wawa.TwitchPlays.Domains.Instruction(Wawa.TwitchPlays.Domains.TwitchString)') | Implicitly calls the constructor. |
| [implicit operator Instruction(YieldInstruction)](Instruction.op_Implicit.bB7I69yfZhvKGjNom0VkWg.md 'Wawa.TwitchPlays.Domains.Instruction.op_Implicit Wawa.TwitchPlays.Domains.Instruction(YieldInstruction)') | Implicitly calls the constructor. |
| [operator !=(Instruction, Instruction)](Instruction.op_Inequality.eNvy5BWLwqTt2/YpVYbPng.md 'Wawa.TwitchPlays.Domains.Instruction.op_Inequality(Wawa.TwitchPlays.Domains.Instruction, Wawa.TwitchPlays.Domains.Instruction)') | Determines whether both instances do not contain the same values. |
