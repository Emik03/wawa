# GetRate\(KMBomb, bool\) Method

namespace: [wawa\.DDL](../../wawa.DDL.md)<br />
assembly: [wawa\.DDL](../../../wawa.DDL.md)

Gets the rate in which the timer ticks\.

```csharp
public static float GetRate(this KMBomb that ,bool signFlip = False);
```

## Parameters

__that__ : `KMBomb`

The `KMBomb` module instance to grab the rate from\.

__signFlip__ : `bool`

When `true`, invert the returned value when
the component from `that` ticks backwards\.


## Return Value

`float`

The speed of the ticking\.

