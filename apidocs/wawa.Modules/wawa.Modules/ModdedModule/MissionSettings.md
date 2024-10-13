# MissionSettings Method

namespace: [wawa\.Modules](../../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../../wawa.Modules.md)



## Overloads

| Name | Summary |
|------|---------|
| MissionSettings\(\) | Attempts to parse the `JToken` from the mission description\. |
| MissionSettings\<T\>\(\) | Attempts to parse the `JToken` from the mission description\. |

## MissionSettings\(\)

Attempts to parse the `JToken` from the mission description\.

```csharp
public KeyValuePair<Maybe<JsonReaderException>, Maybe<JToken>> MissionSettings();
```

### Return Value

`KeyValuePair<Maybe<JsonReaderException>, Maybe<JToken>>`

The parsed value\. Note that while the return type might resemble a `Result` type, it is possible that both
variants are [None\<T\>\(\)](../../../wawa.Optionals/wawa.Optionals/Maybe/None.md)\. However, both variants will never both be [Some\<T\>\(T\)](../../../wawa.Optionals/wawa.Optionals/Maybe/Some.md)\.

## MissionSettings\<T\>\(\)

Attempts to parse the `JToken` from the mission description\.

```csharp
public KeyValuePair<Maybe<Exception>, Maybe<T>> MissionSettings<T>();
```

### Type Parameters

__T__

The type to parse\.

### Return Value

`KeyValuePair<Maybe<Exception>, Maybe<T>>`

The parsed value\. Note that while the return type might resemble a `Result` type, it is possible that both
variants are [None\<T\>\(\)](../../../wawa.Optionals/wawa.Optionals/Maybe/None.md)\. However, both variants will never both be [Some\<T\>\(T\)](../../../wawa.Optionals/wawa.Optionals/Maybe/Some.md)\.

