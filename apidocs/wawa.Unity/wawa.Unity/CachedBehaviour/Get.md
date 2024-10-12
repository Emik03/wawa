# Get\<T\>\(\) Method

namespace: [wawa\.Unity](../../wawa.Unity.md)<br />
assembly: [wawa\.Unity](../../../wawa.Unity.md)

Caches and returns any or all `T` components in this `Component.gameObject`\.

```csharp
public T Get<T>() where T : class;
```

## Type Parameters

__T__ : `class`

The singular component to locate\.
If this generic is specified as an array, all components are returned\.


## Return Value

`T`

All components in `T` if `T` is an array, otherwise any component\.

