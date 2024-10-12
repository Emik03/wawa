# Sound Constructor

namespace: [wawa\.Modules](../../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../../wawa.Modules.md)

Initializes a new instance of the [Sound](../../../wawa.Modules/wawa.Modules/Sound.md) class\.

## Overloads

| Name | Summary |
|------|---------|
| Sound\(string\) | Initializes a new instance of the [Sound](../../../wawa.Modules/wawa.Modules/Sound.md) class\. |
| Sound\(UnityEngine\.Object\) | Initializes a new instance of the [Sound](../../../wawa.Modules/wawa.Modules/Sound.md) class\. Uses the name of the `AudioClip`\. |
| Sound\(SoundEffect\) | Initializes a new instance of the [Sound](../../../wawa.Modules/wawa.Modules/Sound.md) class\. |

## Sound\(string\)

Initializes a new instance of the [Sound](../../../wawa.Modules/wawa.Modules/Sound.md) class\.

```csharp
public Sound(string sound);
```

### Parameters

__sound__ : `string`

The name of the modded sound to use\.

## Sound\(UnityEngine\.Object\)

Initializes a new instance of the [Sound](../../../wawa.Modules/wawa.Modules/Sound.md) class\. Uses the name of the `AudioClip`\.

```csharp
public Sound(UnityEngine.Object sound);
```

### Parameters

__sound__ : `UnityEngine.Object`

The `UnityEngine.Object` of the modded sound to use, getting its name\.

## Sound\(SoundEffect\)

Initializes a new instance of the [Sound](../../../wawa.Modules/wawa.Modules/Sound.md) class\.

```csharp
public Sound(SoundEffect sound);
```

### Parameters

__sound__ : `SoundEffect`

The vanilla sound to use\.

