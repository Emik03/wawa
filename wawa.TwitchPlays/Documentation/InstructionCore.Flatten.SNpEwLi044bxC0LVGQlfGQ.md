#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains').[InstructionCore](InstructionCore.md 'Wawa.TwitchPlays.Domains.InstructionCore')

## InstructionCore.Flatten(this IEnumerable<Instruction>) Method

Flattens the enumeration for coroutine use.

```csharp
public static System.Collections.Generic.IEnumerator<object> Flatten(this System.Collections.Generic.IEnumerable<Wawa.TwitchPlays.Domains.Instruction> that);
```
#### Parameters

<a name='Wawa.TwitchPlays.Domains.InstructionCore.Flatten(thisSystem.Collections.Generic.IEnumerable_Wawa.TwitchPlays.Domains.Instruction_).that'></a>

`that` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Instruction](Instruction.md 'Wawa.TwitchPlays.Domains.Instruction')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

This instance of [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').

#### Returns
[System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')  
An [System.Collections.Generic.IEnumerator&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1') of [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') that is friendly to be used for coroutines,  
containing the values from [that](InstructionCore.Flatten.SNpEwLi044bxC0LVGQlfGQ.md#Wawa.TwitchPlays.Domains.InstructionCore.Flatten(thisSystem.Collections.Generic.IEnumerable_Wawa.TwitchPlays.Domains.Instruction_).that 'Wawa.TwitchPlays.Domains.InstructionCore.Flatten(this System.Collections.Generic.IEnumerable<Wawa.TwitchPlays.Domains.Instruction>).that').