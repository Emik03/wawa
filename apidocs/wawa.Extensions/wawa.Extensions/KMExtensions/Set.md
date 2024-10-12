# Set Method

namespace: [wawa\.Extensions](../../wawa.Extensions.md)<br />
assembly: [wawa\.Extensions](../../../wawa.Extensions.md)



## Overloads

| Name | Summary |
|------|---------|
| Set\(KMAudioRef, Action\) | Sets the specified delegate parameter if not `null` into the `KMAudioRef`\. |
| Set\(KMBombInfo, Action, Action\) | Sets specified delegate parameters into the `KMSelectable`\. |
| Set\(KMBombModule, Action, Action, Action\) | Sets specified delegate parameters into the `KMBombModule`\. |
| Set\(KMGameInfo, Action, Action, Action\) | Sets specified delegate parameters into the `KMGameInfo`\. |
| Set\(KMNeedyModule, Action, Action, Action, Action, Action, Action\) | Sets specified delegate parameters into the `KMNeedyModule`\. |
| Set\(KMSelectable, bool?, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action\) | Sets specified delegate parameters into the `KMSelectable`\. |
| Set\<T\>\(T, Action\<int\>\) | Sets the specified delegate parameter if not `null` into the `IEnumerable<T>`of `KMSelectable` instances\. An `System.Int32` is passed in the `Action<T>`based on the index from the collection\. |
| Set\<T\>\(T, bool?, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>\) | Sets specified delegate parameters into the `IEnumerable<T>` of `KMSelectable` instances\.An `System.Int32` is passed in the `Action<T>` based on the index from the collection\. |

## Set\(KMAudioRef, Action\)

Sets the specified delegate parameter if not `null` into the `KMAudioRef`\.

```csharp
public static KMAudioRef Set(this KMAudioRef audio ,Action onStopSound);
```

### Parameters

__audio__ : `KMAudioRef`

The `IEnumerable<T>` of `KMAudioRef`
instances to invoke `KMAudioRef.StopSound`\.


__onStopSound__ : `Action`

Called when the sound is prematurely stopped\.

### Return Value

`KMAudioRef`

The parameter `audio`\.

## Set\(KMBombInfo, Action, Action\)

Sets specified delegate parameters into the `KMSelectable`\.

```csharp
public static KMBombInfo Set(this KMBombInfo info ,Action onBombExploded = null ,Action onBombSolved = null);
```

### Parameters

__info__ : `KMBombInfo`

The `KMBombInfo` to hook\.

__onBombExploded__ : `Action`

Called when the bomb explodes\.

__onBombSolved__ : `Action`

Called when the bomb is defused\.

### Return Value

`KMBombInfo`

The parameter `info`\.

## Set\(KMBombModule, Action, Action, Action\)

Sets specified delegate parameters into the `KMBombModule`\.

```csharp
public static KMBombModule Set(this KMBombModule module ,Action onActivate = null ,Action onPass = null ,Action onStrike = null);
```

### Parameters

__module__ : `KMBombModule`

The `KMBombModule` to hook\.

__onActivate__ : `Action`

Called when the lights turn on\.

__onPass__ : `Action`

Called when the module is solved\.

__onStrike__ : `Action`

Called when the module strikes\.

### Return Value

`KMBombModule`

The parameter `module`\.

## Set\(KMGameInfo, Action, Action, Action\)

Sets specified delegate parameters into the `KMGameInfo`\.

```csharp
public static KMGameInfo Set(this KMGameInfo game ,Action onStateChange = null ,Action onAlarmClockChange = null ,Action onLightsChange = null);
```

### Parameters

__game__ : `KMGameInfo`

The `KMGameInfo` to hook\.

__onStateChange__ : `Action`

Called when the state of the game changes\.

__onAlarmClockChange__ : `Action`

Called when the alarm clock changes state, and passes in whether it's on or off\.


__onLightsChange__ : `Action`

Called when the lights change state, and passes in whether it's on or off\.

### Return Value

`KMGameInfo`

The parameter `game`\.

## Set\(KMNeedyModule, Action, Action, Action, Action, Action, Action\)

Sets specified delegate parameters into the `KMNeedyModule`\.

```csharp
public static KMNeedyModule Set(this KMNeedyModule needy ,Action onActivate = null ,Action onNeedyActivation = null ,Action onNeedyDeactivation = null ,Action onPass = null ,Action onStrike = null ,Action onTimerExpired = null);
```

### Parameters

__needy__ : `KMNeedyModule`

The `KMNeedyModule` to hook\.

__onActivate__ : `Action`

Called when the lights turn on\.

__onNeedyActivation__ : `Action`

Called when the needy activates\.

__onNeedyDeactivation__ : `Action`

Called when the needy deactivates\.

__onPass__ : `Action`

Called when the needy is solved\.

__onStrike__ : `Action`

Called when the needy strikes\.

__onTimerExpired__ : `Action`

Called when the timer runs out of time\.

### Return Value

`KMNeedyModule`

The parameter `needy`\.

## Set\(KMSelectable, bool?, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action\)

Sets specified delegate parameters into the `KMSelectable`\.

```csharp
public static KMSelectable Set(this KMSelectable selectable ,bool? isParent = null ,Action onCancel = null ,Action onDefocus = null ,Action onDeselect = null ,Action onFocus = null ,Action onHighlight = null ,Action onHighlightEnded = null ,Action onInteract = null ,Action onInteractEnded = null ,Action onInteractionPunch = null ,Action onLeft = null ,Action onRight = null ,Action onSelect = null ,Action onUpdateChildren = null);
```

### Parameters

__selectable__ : `KMSelectable`

The `KMSelectable` to hook\.

__isParent__ : `bool?`

The `return` value of `KMSelectable.OnCancel`
and `KMSelectable.OnInteract`\.
If `null`, the value is evaluated at runtime to be `true` if
`KMSelectable.Children` is a populated `Array`, and `false` otherwise\.


__onCancel__ : `Action`

Called when player backs out of this selectable\.

__onDefocus__ : `Action`

Called when a different selectable becomes the focus, or the module has been backed out of\.


__onDeselect__ : `Action`

Called when the selectable stops being the current selectable\.

__onFocus__ : `Action`

Called when a module is focused, this is when it is interacted
with from the bomb face level and its children can be selected\.


__onHighlight__ : `Action`

Called when the highlight is turned on\.

__onHighlightEnded__ : `Action`

Called when the highlight is turned off\.

__onInteract__ : `Action`

Called when player interacts with the selectable\.

__onInteractEnded__ : `Action`

Called when a player interacting with the selectable releases the mouse or controller button\.


__onInteractionPunch__ : `Action`

Called when the interaction punch method is called\.

__onLeft__ : `Action`

Called when the left controller stick is pulled while selected\.

__onRight__ : `Action`

Called when the right controller stick is pulled while selected\.

__onSelect__ : `Action`

Called whenever the selectable becomes the current selectable\.

__onUpdateChildren__ : `Action`

Called when the selectable updates its children\.

### Return Value

`KMSelectable`

The parameter `selectable`\.

## Set\<T\>\(T, Action\<int\>\)

Sets the specified delegate parameter if not `null` into the `IEnumerable<T>`
of `KMSelectable` instances\. An `System.Int32` is passed in the `Action<T>`
based on the index from the collection\.

```csharp
public static T Set<T>(this T audio ,Action<int> onStopSound);
```

### Type Parameters

__T__ : `IEnumerable<KMAudioRef>`

The type of `IEnumerable<T>` containing `KMSelectable` instances\.


### Parameters

__audio__ : `T`

The `IEnumerable<T>` of `KMAudioRef`
instances to invoke `KMAudioRef.StopSound`\.


__onStopSound__ : `Action<int>`

Called when the sound is prematurely stopped\.

### Return Value

`T`

The parameter `audio`\.

## Set\<T\>\(T, bool?, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>, Action\<int\>\)

Sets specified delegate parameters into the `IEnumerable<T>` of `KMSelectable` instances\.
An `System.Int32` is passed in the `Action<T>` based on the index from the collection\.

```csharp
public static T Set<T>(this T selectables ,bool? isParent = null ,Action<int> onCancel = null ,Action<int> onDefocus = null ,Action<int> onDeselect = null ,Action<int> onFocus = null ,Action<int> onHighlight = null ,Action<int> onHighlightEnded = null ,Action<int> onInteract = null ,Action<int> onInteractEnded = null ,Action<int> onInteractionPunch = null ,Action<int> onLeft = null ,Action<int> onRight = null ,Action<int> onSelect = null ,Action<int> onUpdateChildren = null);
```

### Type Parameters

__T__ : `IEnumerable<KMSelectable>`

The type of `IEnumerable<T>` containing `KMSelectable` instances\.


### Parameters

__selectables__ : `T`

The `IEnumerable<T>` of `KMSelectable` instances to hook\.


__isParent__ : `bool?`

The `return` value of `KMSelectable.OnCancel`
and `KMSelectable.OnInteract`\.
If `null`, the value is evaluated at runtime to be `true` if
`KMSelectable.Children` is a populated `Array`, and `false` otherwise\.


__onCancel__ : `Action<int>`

Called when player backs out of this selectable\.

__onDefocus__ : `Action<int>`

Called when a different selectable becomes the focus, or the module has been backed out of\.


__onDeselect__ : `Action<int>`

Called when the selectable stops being the current selectable\.

__onFocus__ : `Action<int>`

Called when a module is focused, this is when it is interacted
with from the bomb face level and its children can be selected\.


__onHighlight__ : `Action<int>`

Called when the highlight is turned on\.

__onHighlightEnded__ : `Action<int>`

Called when the highlight is turned off\.

__onInteract__ : `Action<int>`

Called when player interacts with the selectable\.

__onInteractEnded__ : `Action<int>`

Called when a player interacting with the selectable releases the mouse or controller button\.


__onInteractionPunch__ : `Action<int>`

Called when the interaction punch method is called\.

__onLeft__ : `Action<int>`

Called when the left controller stick is pulled while selected\.

__onRight__ : `Action<int>`

Called when the right controller stick is pulled while selected\.

__onSelect__ : `Action<int>`

Called whenever the selectable becomes the current selectable\.

__onUpdateChildren__ : `Action<int>`

Called when the selectable updates its children\.

### Return Value

`T`

The parameter `selectables`\.

