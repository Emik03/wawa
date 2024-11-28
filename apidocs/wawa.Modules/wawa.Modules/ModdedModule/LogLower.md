# LogLower Method

namespace: [wawa\.Modules](../../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../../wawa.Modules.md)



## Overloads

| Name | Summary |
|------|---------|
| LogLower\(InterpolatedStringHandlerEnumerable, LogType\) | Formats and logs the parameter, which will remain hidden under the module's tab in the Logfile Analyzer\. |
| LogLower\<T\>\(T, LogType\) | Formats and logs the parameter, which will remain hidden under the module's tab in the Logfile Analyzer\. |
| LogLower\<T\>\(T, params object\[\]\) | Formats and logs the parameter, which will remain hidden under the module's tab in the Logfile Analyzer\. |

## LogLower\(InterpolatedStringHandlerEnumerable, LogType\)

Formats and logs the parameter, which will remain hidden under the module's tab in the Logfile Analyzer\.

```csharp
public InterpolatedStringHandlerEnumerable LogLower(InterpolatedStringHandlerEnumerable format ,LogType logType = null);
```

### Parameters

__format__ : [InterpolatedStringHandlerEnumerable](../../../wawa.Modules/wawa.Modules/InterpolatedStringHandlerEnumerable.md)

The value to log\.

__logType__ : `LogType`

The kind of logging method to invoke\.

### Return Value

[InterpolatedStringHandlerEnumerable](../../../wawa.Modules/wawa.Modules/InterpolatedStringHandlerEnumerable.md)

The parameter `format`\.

## LogLower\<T\>\(T, LogType\)

Formats and logs the parameter, which will remain hidden under the module's tab in the Logfile Analyzer\.

```csharp
public T LogLower<T>(T format = null ,LogType logType = null);
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

## LogLower\<T\>\(T, params object\[\]\)

Formats and logs the parameter, which will remain hidden under the module's tab in the Logfile Analyzer\.

```csharp
public T LogLower<T>(T format = null ,params object[] args);
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

