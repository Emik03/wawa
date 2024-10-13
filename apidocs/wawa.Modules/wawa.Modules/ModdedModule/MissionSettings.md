# MissionSettings Method

namespace: [wawa\.Modules](../../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../../wawa.Modules.md)



## Overloads

| Name | Summary |
|------|---------|
| MissionSettings\<T\>\(\) | Attempts to parse the `T` from the mission description\. |
| MissionSettings\<T\>\(out Maybe\<Exception\>\) | Attempts to parse the `T` from the mission description\. |

## MissionSettings\<T\>\(\)

Attempts to parse the `T` from the mission description\.

```csharp
public Maybe<T> MissionSettings<T>();
```

### Type Parameters

__T__

The type to parse\.

### Return Value

[Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

The parsed value\.

## MissionSettings\<T\>\(out Maybe\<Exception\>\)

Attempts to parse the `T` from the mission description\.

```csharp
public Maybe<T> MissionSettings<T>(out Maybe<Exception> parseError);
```

### Type Parameters

__T__

The type to parse\.

### Parameters

__parseError__ : [Maybe\<Exception\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

The exception thrown if parsing fails\. Note that the return value and this parameter can
both be [None\<T\>\(\)](../../../wawa.Optionals/wawa.Optionals/Maybe/None.md) if no settings are specified in the first place\.


### Return Value

[Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

The parsed value\.

