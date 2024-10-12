# SetRate\(KMBomb, float, bool\) Method

namespace: [wawa\.DDL](../../wawa.DDL.md)<br />
assembly: [wawa\.DDL](../../../wawa.DDL.md)

Sets the rate in which the timer ticks\.

```csharp
public static KMBomb SetRate(this KMBomb that ,float value ,bool signFlip = False);
```

## Parameters

__that__ : `KMBomb`

The `KMBomb` module instance to grab the rate from\.

__value__ : `float`

The value to set it to\.

__signFlip__ : `bool`

When `true`, invert `value` when
the component from `that` ticks backwards\.


## Return Value

`KMBomb`

The parameter `that`\.

