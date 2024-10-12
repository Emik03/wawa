# Stop\<T\>\(T\) Method

namespace: [wawa\.Extensions](../../wawa.Extensions.md)<br />
assembly: [wawa\.Extensions](../../../wawa.Extensions.md)

Invokes `KMAudioRef.StopSound` for all elements in the
`IEnumerable<T>` of `KMAudioRef` instances\.

```csharp
public static T Stop<T>(this T audio);
```

## Type Parameters

__T__ : `IEnumerable<KMAudioRef>`

The type of `IEnumerable<T>` containing `KMSelectable` instances\.


## Parameters

__audio__ : `T`

The `IEnumerable<T>` of `KMAudioRef`
instances to invoke `KMAudioRef.StopSound`\.


## Return Value

`T`

The parameter `audio`\.

