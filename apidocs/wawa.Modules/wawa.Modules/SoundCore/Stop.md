# Stop Method

namespace: [wawa\.Modules](../../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../../wawa.Modules.md)



## Overloads

| Name | Summary |
|------|---------|
| Stop\(Sound\) | Gets the [Reference](../../../wawa.Modules/wawa.Modules/Sound/Reference.md) and stops the sound if it is playing\. |
| Stop\<T\>\(T\) | Gets the [Reference](../../../wawa.Modules/wawa.Modules/Sound/Reference.md) of a collection of sounds and stops the sound if it is playing\. |

## Stop\(Sound\)

Gets the [Reference](../../../wawa.Modules/wawa.Modules/Sound/Reference.md) and stops the sound if it is playing\.

```csharp
public static Sound Stop(this Sound that);
```

### Parameters

__that__ : [Sound](../../../wawa.Modules/wawa.Modules/Sound.md)

This instance of [Sound](../../../wawa.Modules/wawa.Modules/Sound.md)\.

### Return Value

[Sound](../../../wawa.Modules/wawa.Modules/Sound.md)

The parameter `that`\.

## Stop\<T\>\(T\)

Gets the [Reference](../../../wawa.Modules/wawa.Modules/Sound/Reference.md) of a collection of sounds and stops the sound if it is playing\.

```csharp
public static T Stop<T>(this T sounds);
```

### Type Parameters

__T__ : `IEnumerable<Sound>`

The type of iterator\.

### Parameters

__sounds__ : `T`

The multiple [Sound](../../../wawa.Modules/wawa.Modules/Sound.md) instances to each call [Stop\(Sound\)](../../../wawa.Modules/wawa.Modules/SoundCore/Stop.md) on\.

### Return Value

`T`

The parameter `sounds`\.

