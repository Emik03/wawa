# Do Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)



## Overloads

| Name | Summary |
|------|---------|
| Do\<T\>\(IEnumerable\<T\>?, Action\<T\>\) |  |
| Do\<T\>\(T, Action\<T\>\) | Executes the function, then returns the parameter `that`\. |

## Do\<T\>\(IEnumerable\<T\>?, Action\<T\>\)



```csharp
public static IEnumerable<T> Do<T>(this IEnumerable<T>? that ,Action<T> action);
```

### Type Parameters

__T__ : [IVanilla](../../../wawa.Recall/wawa.Recall/IVanilla.md)



### Parameters

__that__ : `IEnumerable<T>?`



__action__ : `Action<T>`



### Return Value

`IEnumerable<T>`



## Do\<T\>\(T, Action\<T\>\)

Executes the function, then returns the parameter `that`\.

```csharp
public static T Do<T>(this T that ,Action<T> action);
```

### Type Parameters

__T__ : [IVanilla](../../../wawa.Recall/wawa.Recall/IVanilla.md)

The type of context value\.

### Parameters

__that__ : `T`

The value to pass into the callback\.

__action__ : `Action<T>`

The callback\.

### Return Value

`T`

The parameter `that`\.

