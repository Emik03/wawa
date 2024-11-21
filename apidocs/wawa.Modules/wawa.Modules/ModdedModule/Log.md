# Log Method

namespace: [wawa\.Modules](../../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../../wawa.Modules.md)



## Overloads

| Name | Summary |
|------|---------|
| Log\(InterpolatedStringHandlerEnumerable\) | Logs and formats a message to the Unity Console in a format compliant with the Logfile Analyzer\. |
| Log\<T\>\(T, LogType\) | Logs and formats a message to the Unity Console in a format compliant with the Logfile Analyzer\. |
| Log\<T\>\(T, params object\[\]\) | Logs and formats a message to the Unity Console in a format compliant with the Logfile Analyzer\. |

## Log\(InterpolatedStringHandlerEnumerable\)

Logs and formats a message to the Unity Console in a format compliant with the Logfile Analyzer\.

```csharp
public InterpolatedStringHandlerEnumerable Log(InterpolatedStringHandlerEnumerable format);
```

### Parameters

__format__ : [InterpolatedStringHandlerEnumerable](../../../wawa.Modules/wawa.Modules/InterpolatedStringHandlerEnumerable.md)

The value to log\.

### Return Value

[InterpolatedStringHandlerEnumerable](../../../wawa.Modules/wawa.Modules/InterpolatedStringHandlerEnumerable.md)

The parameter `format`\.

## Log\<T\>\(T, LogType\)

Logs and formats a message to the Unity Console in a format compliant with the Logfile Analyzer\.

```csharp
public T Log<T>(T format = null ,LogType logType = null);
```

### Type Parameters

__T__

The type of the value to log\.

### Parameters

__format__ : `T`

The value to log\.

__logType__ : `LogType`

The kind of logging method to invoke\.

### Return Value

`T`

The parameter `format`\.

## Log\<T\>\(T, params object\[\]\)

Logs and formats a message to the Unity Console in a format compliant with the Logfile Analyzer\.

```csharp
public T Log<T>(T format = null ,params object[] args);
```

### Type Parameters

__T__

The type of the value to log\.

### Parameters

__format__ : `T`

The value to log\.

__args__ : `object`

The arguments to hook into format\.

### Return Value

`T`

The parameter `format`\.

