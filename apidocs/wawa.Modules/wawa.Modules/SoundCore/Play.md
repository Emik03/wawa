# Play Method

namespace: [wawa\.Modules](../../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../../wawa.Modules.md)



## Overloads

| Name | Summary |
|------|---------|
| Play\(Sound, KMAudio, Transform, bool\) | Plays the current sound that is stored\. |
| Play\(IEnumerable\<Sound\>, KMAudio, Transform, bool\) | Plays the current sound that is stored\. |

## Play\(Sound, KMAudio, Transform, bool\)

Plays the current sound that is stored\.

```csharp
public static Maybe<KMAudioRef> Play(this Sound that ,KMAudio audio ,Transform transform ,bool isLooping = False);
```

### Parameters

__that__ : [Sound](../../../wawa.Modules/wawa.Modules/Sound.md)

This instance of [Sound](../../../wawa.Modules/wawa.Modules/Sound.md)\.

__audio__ : `KMAudio`

The `KMAudio` to play it from\.

__transform__ : `Transform`

The `Transform`, which is needed for the location of the sound\.

__isLooping__ : `bool`

Indicates whether the sound should loop\.

### Return Value

[Maybe\<KMAudioRef\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)

A [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md), consisting of either a `KMAudio.KMAudioRef`,
or `default` if `KMAudio` is unable to play a sound,
usually caused by playing too many sounds at once\.

## Play\(IEnumerable\<Sound\>, KMAudio, Transform, bool\)

Plays the current sound that is stored\.

```csharp
public static IEnumerable<Maybe<KMAudioRef>> Play(this IEnumerable<Sound> that ,KMAudio audio ,Transform transform ,bool isLooping = False);
```

### Parameters

__that__ : `IEnumerable<Sound>`

This instance of [Sound](../../../wawa.Modules/wawa.Modules/Sound.md)\.

__audio__ : `KMAudio`

The `KMAudio` to play it from\.

__transform__ : `Transform`

The `Transform`, which is needed for the location of the sound\.

__isLooping__ : `bool`

Indicates whether the sound should loop\.

### Return Value

`IEnumerable<Maybe<KMAudioRef>>`

A [Maybe\<T\>](../../../wawa.Optionals/wawa.Optionals/Maybe\`1.md), consisting of either a `KMAudio.KMAudioRef`,
or `default` if `KMAudio` is unable to play a sound,
usually caused by playing too many sounds at once\.

