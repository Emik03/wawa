# Serialize\<TSerialize\>\(TSerialize\) Method

namespace: [wawa\.IO](../../wawa.IO.md)<br />
assembly: [wawa\.IO](../../../wawa.IO.md)

Serializes settings the same way it's written to the file\. Supports settings that use enums\.

```csharp
public static string Serialize<TSerialize>(TSerialize value);
```

## Type Parameters

__TSerialize__

The type to serialize the value\.

## Parameters

__value__ : `TSerialize`

The value to serialize\.

## Return Value

`string`

A `System.String` representation of `value` by serializing it as JSON\.

