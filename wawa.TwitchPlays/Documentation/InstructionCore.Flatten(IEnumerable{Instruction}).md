#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[InstructionCore](InstructionCore.md 'wawa.TwitchPlays.Domains.InstructionCore')

## InstructionCore.Flatten(this IEnumerable<Instruction>) Method

Flattens the enumeration for coroutine use.<p/>`[MustDisposeResource]`

```csharp
public static System.Collections.Generic.IEnumerator<object> Flatten(this System.Collections.Generic.IEnumerable<wawa.TwitchPlays.Domains.Instruction> that);
```
#### Parameters

<a name='wawa.TwitchPlays.Domains.InstructionCore.Flatten(thisSystem.Collections.Generic.IEnumerable_wawa.TwitchPlays.Domains.Instruction_).that'></a>

`that` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Instruction](Instruction.md 'wawa.TwitchPlays.Domains.Instruction')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

This instance of [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').<p/>`[ItemCanBeNull]`

#### Returns
[System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')  
An [System.Collections.Generic.IEnumerator&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1') of [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') that is friendly to be used for coroutines,  
containing the values from [that](InstructionCore.Flatten(IEnumerable{Instruction}).md#wawa.TwitchPlays.Domains.InstructionCore.Flatten(thisSystem.Collections.Generic.IEnumerable_wawa.TwitchPlays.Domains.Instruction_).that 'wawa.TwitchPlays.Domains.InstructionCore.Flatten(this System.Collections.Generic.IEnumerable<wawa.TwitchPlays.Domains.Instruction>).that').

### Remarks
  
The caller is responsible for disposing the returned enumerator.