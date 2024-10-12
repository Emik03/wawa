# From\(MemberInfo\) Method

namespace: [wawa\.Schemas](../../wawa.Schemas.md)<br />
assembly: [wawa\.Schemas](../../../wawa.Schemas.md)

Gets the [TweaksSettingAttribute](../../../wawa.Schemas/wawa.Schemas/TweaksSettingAttribute.md) for the `member`\.

```csharp
public static TweaksSettingAttribute From(MemberInfo member);
```

## Parameters

__member__ : `MemberInfo`



## Return Value

[TweaksSettingAttribute](../../../wawa.Schemas/wawa.Schemas/TweaksSettingAttribute.md)

The [TweaksSettingAttribute](../../../wawa.Schemas/wawa.Schemas/TweaksSettingAttribute.md) for the parameter `member`\. If the `System.Reflection.MemberInfo`
has no [TweaksSettingAttribute](../../../wawa.Schemas/wawa.Schemas/TweaksSettingAttribute.md) annotations, then the default instance is returned\. If the parameter
`member` is not a field or property, then `null` is returned instead\.

