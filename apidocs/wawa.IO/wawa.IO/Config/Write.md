# Write Method

namespace: [wawa\.IO](../../wawa.IO.md)<br />
assembly: [wawa\.IO](../../../wawa.IO.md)



## Overloads

| Name | Summary |
|------|---------|
| Write\<T\>\(Config\<T\>, string\) | Writes the string to the settings file\. |
| Write\<T\>\(Config\<T\>, T\) | Writes the settings to the settings file\. |

## Write\<T\>\(Config\<T\>, string\)

Writes the string to the settings file\.

```csharp
public static Config<T> Write<T>(this Config<T> that ,string value) where T : new();
```

### Type Parameters

__T__ : `new()`

The generic used in `that`\.

### Parameters

__that__ : [Config\<T\>](../../../wawa.IO/wawa.IO/Config\`1.md)

This instance of [Config\<T\>](../../../wawa.IO/wawa.IO/Config\`1.md)\.

__value__ : `string`

The contents to write\.

### Return Value

[Config\<T\>](../../../wawa.IO/wawa.IO/Config\`1.md)

The parameter `that`\.

## Write\<T\>\(Config\<T\>, T\)

Writes the settings to the settings file\.

```csharp
public static Config<T> Write<T>(this Config<T> that ,T value) where T : new();
```

### Type Parameters

__T__ : `new()`

The generic used in `that`\.

### Parameters

__that__ : [Config\<T\>](../../../wawa.IO/wawa.IO/Config\`1.md)

This instance of [Config\<T\>](../../../wawa.IO/wawa.IO/Config\`1.md)\.

__value__ : `T`

The value to overwrite the settings file with\.

### Return Value

[Config\<T\>](../../../wawa.IO/wawa.IO/Config\`1.md)

The value `default`\.

