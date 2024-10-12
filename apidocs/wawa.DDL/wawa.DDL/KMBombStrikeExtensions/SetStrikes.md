# SetStrikes\(KMBomb, int, bool\) Method

namespace: [wawa\.DDL](../../wawa.DDL.md)<br />
assembly: [wawa\.DDL](../../../wawa.DDL.md)

Sets the number of strikes\.

```csharp
public static KMBomb SetStrikes(this KMBomb that ,int value ,bool tryDetonate = False);
```

## Parameters

__that__ : `KMBomb`

The `KMBomb` module instance to grab strikes from\.

__value__ : `int`

The value to set it to\.

__tryDetonate__ : `bool`

When `true`, check for whether detonation should occur\.

## Return Value

`KMBomb`

The parameter `that`\.

