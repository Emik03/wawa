# GetUnmanaged\<T\>\(string, string, string\) Method

namespace: [wawa\.IO](../../wawa.IO.md)<br />
assembly: [wawa\.IO](../../../wawa.IO.md)

Gets an unmanaged function from an external library\.

```csharp
public static Maybe<T> GetUnmanaged<T>(string libPath ,string ffiMethodName ,string modId = null);
```

## Type Parameters

__T__ : `Delegate`

The signature of the function\.

## Parameters

__libPath__ : `string`

The external file\.

__ffiMethodName__ : `string`

The name of the method\.

__modId__ : `string`

The mod id to get the mod directory from\.
If `null`, implicitly gets the directory of the mod from the name of the assembly\.


## Return Value

[Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

The value `true` if copying the file was successful, otherwise `false`\.

