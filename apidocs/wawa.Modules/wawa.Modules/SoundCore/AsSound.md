# AsSound Method

namespace: [wawa\.Modules](../../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../../wawa.Modules.md)



## Overloads

| Name | Summary |
|------|---------|
| AsSound\(string\) | Creates an instance of [Sound](../../../wawa.Modules/wawa.Modules/Sound.md) where [Modded](../../../wawa.Modules/wawa.Modules/Sound/Modded.md) is set\. |
| AsSound\(SoundEffect\) | Creates an instance of [Sound](../../../wawa.Modules/wawa.Modules/Sound.md) where [Vanilla](../../../wawa.Modules/wawa.Modules/Sound/Vanilla.md) is set\. |

## AsSound\(string\)

Creates an instance of [Sound](../../../wawa.Modules/wawa.Modules/Sound.md) where [Modded](../../../wawa.Modules/wawa.Modules/Sound/Modded.md) is set\.

```csharp
public static Sound AsSound(this string sound);
```

### Parameters

__sound__ : `string`

The `System.String` to pass in [Sound](../../../wawa.Modules/wawa.Modules/Sound.md)\.

### Return Value

[Sound](../../../wawa.Modules/wawa.Modules/Sound.md)

A new instance of [Sound](../../../wawa.Modules/wawa.Modules/Sound.md) which encapsulates `sound`\.

## AsSound\(SoundEffect\)

Creates an instance of [Sound](../../../wawa.Modules/wawa.Modules/Sound.md) where [Vanilla](../../../wawa.Modules/wawa.Modules/Sound/Vanilla.md) is set\.

```csharp
public static Sound AsSound(this SoundEffect sound);
```

### Parameters

__sound__ : `SoundEffect`

The `SoundEffect` to pass in [Sound](../../../wawa.Modules/wawa.Modules/Sound.md)\.

### Return Value

[Sound](../../../wawa.Modules/wawa.Modules/Sound.md)

A new instance of [Sound](../../../wawa.Modules/wawa.Modules/Sound.md) which encapsulates `sound`\.

