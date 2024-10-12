# Entity Constructor

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Initializes a new instance of the [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) class\.
This guarantees the module kind solvable and modded\.

## Overloads

| Name | Summary |
|------|---------|
| Entity\(KMBombModule\) | Initializes a new instance of the [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) class\.This guarantees the module kind solvable and modded\. |
| Entity\(KMNeedyModule\) | Initializes a new instance of the [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) class\. This guarantees the module kind needy and modded\. |

## Entity\(KMBombModule\)

Initializes a new instance of the [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) class\.
This guarantees the module kind solvable and modded\.

```csharp
public Entity(KMBombModule solvable);
```

### Parameters

__solvable__ : `KMBombModule`

The `KMBombModule` instance to encapsulate\.

## Entity\(KMNeedyModule\)

Initializes a new instance of the [Entity](../../../wawa.Recall/wawa.Recall/Entity.md) class\. This guarantees the module kind needy and modded\.

```csharp
public Entity(KMNeedyModule needy);
```

### Parameters

__needy__ : `KMNeedyModule`

The `KMNeedyModule` instance to encapsulate\.

