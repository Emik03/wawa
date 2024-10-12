# Read\<T\>\(Config\<T\>\) Method

namespace: [wawa\.IO](../../wawa.IO.md)<br />
assembly: [wawa\.IO](../../../wawa.IO.md)

Reads the settings from the settings file\.

```csharp
public static T Read<T>(this Config<T> that) where T : new();
```

## Type Parameters

__T__ : `new()`

The generic used in `that`\.

## Parameters

__that__ : [Config\<T\>](../../../wawa.IO/wawa.IO/Config\`1.md)

This instance of [Config\<T\>](../../../wawa.IO/wawa.IO/Config\`1.md)\.

## Return Value

`T`

If the read and deserialization was successful, a `T` containing the values from the file,
otherwise a new instance of `T`\.

