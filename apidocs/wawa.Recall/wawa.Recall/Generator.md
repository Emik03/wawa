# Generator Class

namespace: [wawa\.Recall](../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../wawa.Recall.md)

Implementations for [Prop\<T\>](../../wawa.Recall/wawa.Recall/Prop\`1.md) and its derivatives\.

```csharp
public static class Generator;
```

Inheritance: `object` > Generator

## Methods

| Name | Summary |
|------|---------|
| [TrySet\<T\>\(HookMay\<T\>?, T\)](./Generator/TrySet.md) | Attempts to set the inner value to the parameter `value`\. |
| [TrySet\<T\>\(HookMay\<T\>?, Action?\)](./Generator/TrySet.md) |  |
| [TryAdd\<T\>\(HookMay\<T\>?, T\)](./Generator/TryAdd.md) | Attempts to add the parameter `value` from the inner value\. |
| [TryAdd\<T\>\(HookMay\<T\>?, Action?\)](./Generator/TryAdd.md) |  |
| [TryRemove\<T\>\(HookMay\<T\>?, T\)](./Generator/TryRemove.md) |  |
| [TryRemove\<T\>\(HookMay\<T\>?, Action?\)](./Generator/TryRemove.md) |  |
| [Set\<T\>\(PropDef\<T\>, T\)](./Generator/Set.md) | Sets the inner value to the parameter `value`\. |
| [TrySet\<T\>\(PropMay\<T\>?, T\)](./Generator/TrySet.md) | Attempts to set the inner value to the parameter `value`\. |
| [ExpectSet\<T\>\(PropMay\<T\>, T\)](./Generator/ExpectSet.md) | Sets the inner value with the provided `value`\. Will throw on fail\. |
| [SetRaw\<T\>\(HookDef\<T\>, T\)](./Generator/SetRaw.md) | Sets the inner value to the parameter `value`\. |
| [Set\<T\>\(HookDef\<T\>, Action?\)](./Generator/Set.md) | Sets the inner value to the parameter `value`\. |
| [ExpectSetRaw\<T\>\(HookMay\<T\>, T\)](./Generator/ExpectSetRaw.md) | Sets the inner value with the provided `value`\. Will throw on fail\. |
| [ExpectSet\<T\>\(HookMay\<T\>, Action?\)](./Generator/ExpectSet.md) | Sets the inner value with the provided `value`\. Will throw on fail\. |
| [AddRaw\<T\>\(HookDef\<T\>, T\)](./Generator/AddRaw.md) | Adds the parameter `value` from the inner value\. |
| [Add\<T\>\(HookDef\<T\>, Action?\)](./Generator/Add.md) | Adds the parameter `value` from the inner value\. |
| [ExpectAddRaw\<T\>\(HookMay\<T\>, T\)](./Generator/ExpectAddRaw.md) | Adds the parameter `value` from the inner value\. Will throw on fail\. |
| [ExpectAdd\<T\>\(HookMay\<T\>, Action\)](./Generator/ExpectAdd.md) | Adds the parameter `value` from the inner value\. Will throw on fail\. |
| [RemoveRaw\<T\>\(HookDef\<T\>, T\)](./Generator/RemoveRaw.md) | Removes the parameter `value` from the inner value\. |
| [Remove\<T\>\(HookDef\<T\>, Action?\)](./Generator/Remove.md) | Removes the parameter `value` from the inner value\. |
| [Clear\<T\>\(Hook\<T\>\)](./Generator/Clear.md) | Clears all hooks set by this instance\. |
| [Clear\<T\>\(HookDef\<T\>\)](./Generator/Clear.md) | Clears all hooks set by this instance\. |
| [Clear\<T\>\(HookMay\<T\>\)](./Generator/Clear.md) | Clears all hooks set by this instance\. |
| [ExpectRemoveRaw\<T\>\(HookMay\<T\>, T\)](./Generator/ExpectRemoveRaw.md) | Removes the parameter `value` from the inner value\. Will throw on fail\. |
| [ExpectRemove\<T\>\(HookMay\<T\>, Action\)](./Generator/ExpectRemove.md) | Removes the parameter `value` from the inner value\. Will throw on fail\. |
| [Logger\(IVanilla, string\)](./Generator/Logger.md) | Gets the logger of the [IVanilla](../../wawa.Recall/wawa.Recall/IVanilla.md)\. |
| [Do\<T\>\(IEnumerable\<T\>?, Action\<T\>\)](./Generator/Do.md) |  |
| [Do\<T\>\(T, Action\<T\>\)](./Generator/Do.md) | Executes the function, then returns the parameter `that`\. |

