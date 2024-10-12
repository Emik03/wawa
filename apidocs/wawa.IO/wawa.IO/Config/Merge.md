# Merge\<T\>\(Config\<T\>, T, bool\) Method

namespace: [wawa\.IO](../../wawa.IO.md)<br />
assembly: [wawa\.IO](../../../wawa.IO.md)

Reads, merges, and writes the settings to the settings file\.

```csharp
public static Config<T> Merge<T>(this Config<T> that ,T value ,bool isDiscarding = False) where T : new();
```

## Type Parameters

__T__ : `new()`

The generic used in `that`\.

## Parameters

__that__ : [Config\<T\>](../../../wawa.IO/wawa.IO/Config\`1.md)

This instance of [Config\<T\>](../../../wawa.IO/wawa.IO/Config\`1.md)\.

__value__ : `T`

The value to merge the file with\.

__isDiscarding__ : `bool`

Determines whether it should remove values from the original
file that isn't contained within the type, or has the incorrect type\.


## Return Value

[Config\<T\>](../../../wawa.IO/wawa.IO/Config\`1.md)

The parameter `that`\.

