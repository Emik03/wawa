### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks')

## Modules Enum

The different types of modules in the game used to discern the type of vanilla module.  
Modded modules are grouped as [Mod](Modules.md#Wawa.Callbacks.Modules.Mod 'Wawa.Callbacks.Modules.Mod') and [NeedyMod](Modules.md#Wawa.Callbacks.Modules.NeedyMod 'Wawa.Callbacks.Modules.NeedyMod') depending on  
whether they have a [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') and [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule') respectively.

```csharp
public enum Modules
```
### Fields

<a name='Wawa.Callbacks.Modules.BigButton'></a>

`BigButton` 3

On the Subject of The Button.

### Remarks
  
Manual: https://ktane.timwi.de/HTML/The%20Button.html.

<a name='Wawa.Callbacks.Modules.Empty'></a>

`Empty` 0

No module. Uses the bomb backing component.

<a name='Wawa.Callbacks.Modules.Keypad'></a>

`Keypad` 4

On the Subject of Keypads.

### Remarks
  
Manual: https://ktane.timwi.de/HTML/Keypad.html.

<a name='Wawa.Callbacks.Modules.Maze'></a>

`Maze` 11

On the Subject of Mazes.

### Remarks
  
Manual: https://ktane.timwi.de/HTML/Maze.html.

<a name='Wawa.Callbacks.Modules.Memory'></a>

`Memory` 7

On the Subject of Memory.

### Remarks
  
Manual: https://ktane.timwi.de/HTML/Memory.html.

<a name='Wawa.Callbacks.Modules.Mod'></a>

`Mod` 16

Any solvable modded module which uses a [KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule').

<a name='Wawa.Callbacks.Modules.Morse'></a>

`Morse` 8

On the Subject of Morse Code.

### Remarks
  
Manual: https://ktane.timwi.de/HTML/Morse%20Code.html.

<a name='Wawa.Callbacks.Modules.NeedyCapacitor'></a>

`NeedyCapacitor` 14

On the Subject of Capacitor Discharge.

### Remarks
  
Manual: https://ktane.timwi.de/HTML/Capacitor%20Discharge.html.

<a name='Wawa.Callbacks.Modules.NeedyKnob'></a>

`NeedyKnob` 15

On the Subject of Knobs.

### Remarks
  
Manual: https://ktane.timwi.de/HTML/Knob.html.

<a name='Wawa.Callbacks.Modules.NeedyMod'></a>

`NeedyMod` 17

Any needy modded module which uses a [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule').

<a name='Wawa.Callbacks.Modules.NeedyVentGas'></a>

`NeedyVentGas` 13

On the Subject of Venting Gas.

### Remarks
  
Manual: https://ktane.timwi.de/HTML/Venting%20Gas.html.

<a name='Wawa.Callbacks.Modules.Password'></a>

`Password` 12

On the Subject of Passwords.

### Remarks
  
Manual: https://ktane.timwi.de/HTML/Password.html.

<a name='Wawa.Callbacks.Modules.Simon'></a>

`Simon` 5

On the Subject of Simon Says.

### Remarks
  
Manual: https://ktane.timwi.de/HTML/Simon%20Says.html.

<a name='Wawa.Callbacks.Modules.Timer'></a>

`Timer` 1

The vanilla timer component which ticks down the bomb's time.

<a name='Wawa.Callbacks.Modules.Venn'></a>

`Venn` 9

On the Subject of Complicated Wires.

### Remarks
  
Manual: https://ktane.timwi.de/HTML/Complicated%20Wires.html.

<a name='Wawa.Callbacks.Modules.WhosOnFirst'></a>

`WhosOnFirst` 6

On the Subject of Who's on First.

### Remarks
  
Manual: https://ktane.timwi.de/HTML/Who's%20On%20First.html.

<a name='Wawa.Callbacks.Modules.Wires'></a>

`Wires` 2

On the Subject of Wires.

### Remarks
  
Manual: https://ktane.timwi.de/HTML/Wires.html.

<a name='Wawa.Callbacks.Modules.WireSequence'></a>

`WireSequence` 10

On the Subject of Wire Sequences.

### Remarks
  
Manual: https://ktane.timwi.de/HTML/Wire%20Sequences.html.

### Remarks
  
This enum is a one-to-one copy of `Assets.Scripts.Missions.ComponentTypeEnum`,  
and as such, casting from or to these two types is defined behaviour.