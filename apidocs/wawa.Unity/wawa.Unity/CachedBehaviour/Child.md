# Child\<T\>\(bool, bool\) Method

namespace: [wawa\.Unity](../../wawa.Unity.md)<br />
assembly: [wawa\.Unity](../../../wawa.Unity.md)

Caches and returns any or all `T` components
in this `Component.gameObject` and all children\.

```csharp
public T Child<T>(bool includeInactive = False ,bool includeSelf = False) where T : class;
```

## Type Parameters

__T__ : `class`

The singular component to locate\. If this generic is specified as an array,
all components are returned\.


## Parameters

__includeInactive__ : `bool`

Determines whether the search should include inactive `GameObject` instances\.


__includeSelf__ : `bool`

Determines whether the search should include itself\.
Only takes effect when `T` is `Array`\.


## Return Value

`T`

All components in `T` if `T` is an array, otherwise any component\.

