# ToSounds Method

namespace: [wawa\.Modules](../../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../../wawa.Modules.md)



## Overloads

| Name | Summary |
|------|---------|
| ToSounds\(IEnumerable\<string\>\) | Creates a `System.Collections.ObjectModel.ReadOnlyCollection<T>`where each element has been converted\. |
| ToSounds\(IEnumerable\<SoundEffect\>\) | Creates a `System.Collections.ObjectModel.ReadOnlyCollection<T>`where each element has been converted\. |
| ToSounds\(IEnumerable\<AudioClip\>\) | Creates a `System.Collections.ObjectModel.ReadOnlyCollection<T>`where each element has been converted\. |

## ToSounds\(IEnumerable\<string\>\)

Creates a `System.Collections.ObjectModel.ReadOnlyCollection<T>`
where each element has been converted\.

```csharp
public static ReadOnlyCollection<Sound> ToSounds(this IEnumerable<string> sounds);
```

### Parameters

__sounds__ : `IEnumerable<string>`

The collection\.

### Return Value

`ReadOnlyCollection<Sound>`

An immutable array\.

## ToSounds\(IEnumerable\<SoundEffect\>\)

Creates a `System.Collections.ObjectModel.ReadOnlyCollection<T>`
where each element has been converted\.

```csharp
public static ReadOnlyCollection<Sound> ToSounds(this IEnumerable<SoundEffect> sounds);
```

### Parameters

__sounds__ : `IEnumerable<SoundEffect>`

The collection\.

### Return Value

`ReadOnlyCollection<Sound>`

An immutable array\.

## ToSounds\(IEnumerable\<AudioClip\>\)

Creates a `System.Collections.ObjectModel.ReadOnlyCollection<T>`
where each element has been converted\.

```csharp
public static ReadOnlyCollection<Sound> ToSounds(this IEnumerable<AudioClip> sounds);
```

### Parameters

__sounds__ : `IEnumerable<AudioClip>`

The collection\.

### Return Value

`ReadOnlyCollection<Sound>`

An immutable array\.

