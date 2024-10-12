# KMExtensions Class

namespace: [wawa\.Extensions](../wawa.Extensions.md)<br />
assembly: [wawa\.Extensions](../../wawa.Extensions.md)

Contains static methods able to be accessed from anywhere within this library\.

```csharp
public static class KMExtensions;
```

Inheritance: `object` > KMExtensions

## Methods

| Name | Summary |
|------|---------|
| [Add\(KMAudioRef, Action\)](./KMExtensions/Add.md) | Adds the specified delegate parameter if not `null` into the `KMAudioRef`\. |
| [Set\(KMAudioRef, Action\)](./KMExtensions/Set.md) | Sets the specified delegate parameter if not `null` into the `KMAudioRef`\. |
| [Add\(KMBombInfo, Action, Action\)](./KMExtensions/Add.md) | Sets specified delegate parameters into the `KMSelectable`\. |
| [Set\(KMBombInfo, Action, Action\)](./KMExtensions/Set.md) | Sets specified delegate parameters into the `KMSelectable`\. |
| [Add\(KMBombModule, Action, Action, Action\)](./KMExtensions/Add.md) | Sets specified delegate parameters into the `KMBombModule`\. |
| [Set\(KMBombModule, Action, Action, Action\)](./KMExtensions/Set.md) | Sets specified delegate parameters into the `KMBombModule`\. |
| [Add\(KMGameInfo, Action, Action, Action\)](./KMExtensions/Add.md) | Sets specified delegate parameters into the `KMGameInfo`\. |
| [Set\(KMGameInfo, Action, Action, Action\)](./KMExtensions/Set.md) | Sets specified delegate parameters into the `KMGameInfo`\. |
| [Add\(KMNeedyModule, Action, Action, Action, Action, Action, Action\)](./KMExtensions/Add.md) | Sets specified delegate parameters into the `KMNeedyModule`\. |
| [Set\(KMNeedyModule, Action, Action, Action, Action, Action, Action\)](./KMExtensions/Set.md) | Sets specified delegate parameters into the `KMNeedyModule`\. |
| [Add\(KMSelectable, bool?, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action\)](./KMExtensions/Add.md) | Adds specified delegate parameters into the `KMSelectable`\. |
| [Notify\(KMSelectable, KMSelectable\)](./KMExtensions/Notify.md) | Notifies the game that the children list has been updated\. |
| [Set\(KMSelectable, bool?, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action\)](./KMExtensions/Set.md) | Sets specified delegate parameters into the `KMSelectable`\. |
| [Add\<T\>\(T, Action\<int\>\)](./KMExtensions/Add.md) | Adds the specified delegate parameter if not `null` into the `IEnumerable<T>`of `KMSelectable` instances\. An `System.Int32` is passed in the `Action<T>`based on the index from the collection\. |
| [Set\<T\>\(T, Action\<int\>\)](./KMExtensions/Set.md) | Sets the specified delegate parameter if not `null` into the `IEnumerable<T>`of `KMSelectable` instances\. An `System.Int32` is passed in the `Action<T>`based on the index from the collection\. |
| [Add\<T\>\(T, bool?, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>\)](./KMExtensions/Add.md) | Adds specified delegate parameters into the `IEnumerable<T>` of `KMSelectable` instances\.An `System.Int32` is passed in the `Action<T>` based on the index from the collection\. |
| [Notify\<T\>\(T, params KMSelectable\[\]\)](./KMExtensions/Notify.md) | Notifies the game that the children list has been updated\. |
| [Notify\<T, TChild\>\(T, TChild\)](./KMExtensions/Notify.md) | Notifies the game that the children list has been updated\. |
| [Set\<T\>\(T, bool?, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>\)](./KMExtensions/Set.md) | Sets specified delegate parameters into the `IEnumerable<T>` of `KMSelectable` instances\.An `System.Int32` is passed in the `Action<T>` based on the index from the collection\. |
| [Stop\<T\>\(T\)](./KMExtensions/Stop.md) | Invokes `KMAudioRef.StopSound` for all elements in the`IEnumerable<T>` of `KMAudioRef` instances\. |

