#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays](wawa.TwitchPlays.md 'wawa.TwitchPlays').[ITwitchDeclarable](ITwitchDeclarable.md 'wawa.TwitchPlays.ITwitchDeclarable')

## ITwitchDeclarable.ForceSolve() Method

When the module runs into an exception or the module is forced to be solved, this method is used.  
<p/>`[ItemCanBeNull]`

```csharp
System.Collections.Generic.IEnumerable<wawa.TwitchPlays.Domains.Instruction> ForceSolve();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Instruction](Instruction.md 'wawa.TwitchPlays.Domains.Instruction')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A series of instructions for the Twitch Plays mod to handle in order to guarantee solving.

### Remarks
  
Make sure that the module is solved before this method closes, otherwise it causes a forced-solve.