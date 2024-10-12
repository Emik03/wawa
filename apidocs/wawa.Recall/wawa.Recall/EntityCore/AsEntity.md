# AsEntity Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)



## Overloads

| Name | Summary |
|------|---------|
| AsEntity\(KMBombModule\) | Creates an instance of [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) where [Solvable](../../../wawa.Recall/wawa.Recall/Entity/Solvable.md) is set\. |
| AsEntity\(KMNeedyModule\) | Creates an instance of [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) where [Needy](../../../wawa.Recall/wawa.Recall/Entity/Needy.md) is set\. |

## AsEntity\(KMBombModule\)

Creates an instance of [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) where [Solvable](../../../wawa.Recall/wawa.Recall/Entity/Solvable.md) is set\.

```csharp
public static Entity AsEntity(this KMBombModule solvable);
```

### Parameters

__solvable__ : `KMBombModule`

The `KMBombModule` to pass in [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)\.

### Return Value

[Entity](../../../wawa.Recall/wawa.Recall/Entity.md)

A new instance of [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) which encapsulates `solvable`\.

## AsEntity\(KMNeedyModule\)

Creates an instance of [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) where [Needy](../../../wawa.Recall/wawa.Recall/Entity/Needy.md) is set\.

```csharp
public static Entity AsEntity(this KMNeedyModule needy);
```

### Parameters

__needy__ : `KMNeedyModule`

The `KMNeedyModule` to pass in [Entity](../../../wawa.Recall/wawa.Recall/Entity.md)\.

### Return Value

[Entity](../../../wawa.Recall/wawa.Recall/Entity.md)

A new instance of [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) which encapsulates `needy`\.

