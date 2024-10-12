# Access Class

namespace: [wawa\.DDL](../wawa.DDL.md)<br />
assembly: [wawa\.DDL](../../wawa.DDL.md)

A class for accessing things from the game\.

```csharp
public static class Access;
```

Inheritance: `object` > Access

## Methods

| Name | Summary |
|------|---------|
| [FromGame\<T\>\(Converter\<DBNull, T\>, T, string\)](./Access/FromGame.md) | Method for obtaining something from the game, ensuring that the Unity editor stays happy\. |
| [FromGame\<T, TResult\>\(T, Converter\<T, TResult\>, TResult, string\)](./Access/FromGame.md) | Method for obtaining something from the game, ensuring that the Unity editor stays happy\. |

## Properties

| Name | Summary |
|------|---------|
| [IsRewritten](./Access/IsRewritten.md) | Gets a value indicating whether the runtime is in a non\-official game\. |
| [IsKtane](./Access/IsKtane.md) | Gets a value indicating whether the runtime is in\-game\. |

