# wawa\.Recall Namespace

assembly: [wawa\.Recall](../wawa.Recall.md)



```csharp
namespace wawa.Recall;
```

## Classes

| Name | Summary |
|------|---------|
| [Generator](./wawa.Recall/Generator.md) | Implementations for [Prop\<T\>](../wawa.Recall/wawa.Recall/Prop\`1.md) and its derivatives\. |
| [HookDef\<T\>](./wawa.Recall/HookDef\`1.md) | Encapsulates a getter `Delegate` and a setter `Delegate` to get and set an inner value toprovide a friendly and easy way to get or set one of multiple types with different `Type` signaturesby using a general `Type` that acts as a bridge between them\. The getter may `return``null`, and therefore is encapsulated in a [Maybe\<T\>](../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\. |
| [HookMay\<T\>](./wawa.Recall/HookMay\`1.md) | Encapsulates a getter `Delegate` and a setter `Delegate` to get and set an inner value toprovide a friendly and easy way to get or set one of multiple types with different `Type` signaturesby using a general `Type` that acts as a bridge between them\. The getter may `return``null`, and therefore is encapsulated in a [Maybe\<T\>](../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\. |
| [Hook\<T\>](./wawa.Recall/Hook\`1.md) | Encapsulates a getter `Delegate` and a setter `Delegate` to get and set an inner value toprovide a friendly and easy way to get or set one of multiple types with different `Type` signaturesby using a general `Type` that acts as a bridge between them\. The getter may `return``null`, and therefore is encapsulated in a [Maybe\<T\>](../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\. |
| [PropDef\<T\>](./wawa.Recall/PropDef\`1.md) | Encapsulates a getter `Delegate` and a setter `Delegate` to get and set an inner value toprovide a friendly and easy way to get or set one of multiple types with different `Type` signaturesby using a general `Type` that acts as a bridge between them\. The getter may `return``null`, and therefore is encapsulated in a [Maybe\<T\>](../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\. |
| [PropMay\<T\>](./wawa.Recall/PropMay\`1.md) | Encapsulates a getter `Delegate` and a setter `Delegate` to get and set an inner value toprovide a friendly and easy way to get or set one of multiple types with different `Type` signaturesby using a general `Type` that acts as a bridge between them\. The getter may `return``null`, and therefore is encapsulated in a [Maybe\<T\>](../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\. |
| [Prop\<T\>](./wawa.Recall/Prop\`1.md) | Encapsulates a getter `Delegate` and a setter `Delegate` to get and set an inner value to provide a friendly and easy way to get or set one of multiple types with different `Type` signatures by using a general `Type` that acts as a bridge between them\. |
| [Entity](./wawa.Recall/Entity.md) | Encapsulates a solvable or needy module in either its vanilla or modded counterpart\. |
| [EntityCore](./wawa.Recall/EntityCore.md) | Implementations for [Entity](../wawa.Recall/wawa.Recall/Entity.md)\. |
| [Highlighted](./wawa.Recall/Highlighted.md) | Encapsulates a vanilla or modded highlight\. |
| [HighlightedCore](./wawa.Recall/HighlightedCore.md) | Implementations for [Highlighted](../wawa.Recall/wawa.Recall/Highlighted.md)\. |
| [Selected](./wawa.Recall/Selected.md) | Encapsulates a vanilla or modded selectable\. |
| [SelectedCore](./wawa.Recall/SelectedCore.md) | Implementations for [Selected](../wawa.Recall/wawa.Recall/Selected.md)\. |

## Interfaces

| Name | Summary |
|------|---------|
| [IValued\<T\>](./wawa.Recall/IValued\`1.md) | An interface for all property\-like class behaviors\. |
| [IVanilla](./wawa.Recall/IVanilla.md) | An interface for all encapsulations of vanilla objects\. |

## Enums

| Name | Summary |
|------|---------|
| [Modules](./wawa.Recall/Modules.md) | The different types of modules in the game used to discern the type of vanilla module\.Modded modules are grouped as [Mod](../wawa.Recall/wawa.Recall/Modules/Mod.md) and [NeedyMod](../wawa.Recall/wawa.Recall/Modules/NeedyMod.md) depending onwhether they have a `KMBombModule` and `KMNeedyModule` respectively\. |
| [StatusLights](./wawa.Recall/StatusLights.md) | The different kinds of status lights\. |

