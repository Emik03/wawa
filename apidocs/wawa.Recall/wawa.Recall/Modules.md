# Modules Enum

namespace: [wawa\.Recall](../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../wawa.Recall.md)

The different types of modules in the game used to discern the type of vanilla module\.
Modded modules are grouped as [Mod](../../wawa.Recall/wawa.Recall/Modules/Mod.md) and [NeedyMod](../../wawa.Recall/wawa.Recall/Modules/NeedyMod.md) depending on
whether they have a `KMBombModule` and `KMNeedyModule` respectively\.

```csharp
public enum Modules;
```

Inheritance: `Enum` > Modules

## Fields

| Name | Value | Summary |
|------|-------|---------|
| Empty | 0 | No module\. Uses the bomb backing component\. |
| Timer | 1 | The vanilla timer component which ticks down the bomb's time\. |
| Wires | 2 | On the Subject of Wires\. |
| BigButton | 3 | On the Subject of The Button\. |
| Keypad | 4 | On the Subject of Keypads\. |
| Simon | 5 | On the Subject of Simon Says\. |
| WhosOnFirst | 6 | On the Subject of Who's on First\. |
| Memory | 7 | On the Subject of Memory\. |
| Morse | 8 | On the Subject of Morse Code\. |
| Venn | 9 | On the Subject of Complicated Wires\. |
| WireSequence | 10 | On the Subject of Wire Sequences\. |
| Maze | 11 | On the Subject of Mazes\. |
| Password | 12 | On the Subject of Passwords\. |
| NeedyVentGas | 13 | On the Subject of Venting Gas\. |
| NeedyCapacitor | 14 | On the Subject of Capacitor Discharge\. |
| NeedyKnob | 15 | On the Subject of Knobs\. |
| Mod | 16 | Any solvable modded module which uses a `KMBombModule`\. |
| NeedyMod | 17 | Any needy modded module which uses a `KMNeedyModule`\. |

