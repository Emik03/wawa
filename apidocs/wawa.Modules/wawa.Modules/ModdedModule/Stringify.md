# Stringify Method

namespace: [wawa\.Modules](../../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../../wawa.Modules.md)



## Overloads

| Name | Summary |
|------|---------|
| Stringify\<T\>\(T\) | Converts `source` into a `System.String` representation of `source`\. |
| Stringify\<T\>\(T, string\) | Converts `source` into a `System.String` representation of `source`\. |

## Stringify\<T\>\(T\)

Converts `source` into a `System.String` representation of `source`\.

```csharp
public virtual string Stringify<T>(T source);
```

### Type Parameters

__T__

The type of the source\.

### Parameters

__source__ : `T`

The item to get a `System.String` representation of\.

### Return Value

`string`

`source` as `System.String`\.

## Stringify\<T\>\(T, string\)

Converts `source` into a `System.String` representation of `source`\.

```csharp
public virtual string Stringify<T>(T source ,string format);
```

### Type Parameters

__T__

The type of the source\.

### Parameters

__source__ : `T`

The item to get a `System.String` representation of\.

__format__ : `string`

The format string\.

### Return Value

`string`

`source` as `System.String`\.

