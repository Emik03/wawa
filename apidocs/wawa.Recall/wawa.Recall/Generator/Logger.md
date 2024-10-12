# Logger\(IVanilla, string\) Method

namespace: [wawa\.Recall](../../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../../wawa.Recall.md)

Gets the logger of the [IVanilla](../../../wawa.Recall/wawa.Recall/IVanilla.md)\.

```csharp
public static Action Logger(this IVanilla vanilla ,string label = null);
```

## Parameters

__vanilla__ : [IVanilla](../../../wawa.Recall/wawa.Recall/IVanilla.md)

The current [IVanilla](../../../wawa.Recall/wawa.Recall/IVanilla.md)\.

__label__ : `string`

An additional label to attach to the end\.

## Return Value

`Action`

The callable function that logs the current path of the encapsulated value\.

