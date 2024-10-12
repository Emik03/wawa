# ModdedModule Class

namespace: [wawa\.Modules](../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../wawa.Modules.md)

The `UnityEngine.Component` that handles general Keep Talking and Nobody Explodes modded module behaviour\.

```csharp
public abstract class ModdedModule;
```

Inheritance: `MonoBehaviour` > [CachedBehaviour](../../wawa.Unity/wawa.Unity/CachedBehaviour.md) > ModdedModule

## Methods

| Name | Summary |
|------|---------|
| [Awake\(\)](./ModdedModule/Awake.md) | Logs the version number for both the module and this library\. |
| [OnDisable\(\)](./ModdedModule/OnDisable.md) | Unsubscribes from `Application.logMessageReceived`, `KMBombModule.OnActivate`,`KMBombModule.OnPass`, and `KMBombModule.OnStrike`\. |
| [OnEnable\(\)](./ModdedModule/OnEnable.md) | Subscribes from `Application.logMessageReceived`, `KMBombModule.OnActivate`,`KMBombModule.OnPass`, and `KMBombModule.OnStrike`\. |
| [ToString\(\)](./ModdedModule/ToString.md) |  |
| [Play\(params Sound\[\]\)](./ModdedModule/Play.md) | Plays one or more sounds from the module `Transform`\. |
| [Play\(Transform, params Sound\[\]\)](./ModdedModule/Play.md) | Plays one or more sounds from a specified `Transform`\. |
| [Play\<T\>\(T, Transform\)](./ModdedModule/Play.md) | Plays one or more sounds from a specified `Transform`\. |
| [Shake\(KMSelectable, float, params Sound\[\]\)](./ModdedModule/Shake.md) | Plays sounds and shakes the bomb from a selectable\. |
| [Solve\(string, params object\[\]\)](./ModdedModule/Solve.md) | Solves the module\. |
| [Strike\(string, params object\[\]\)](./ModdedModule/Strike.md) | Strikes the module\. |
| [Log\(string\)](./ModdedModule/Log.md) | Logs and formats a message to the Unity Console in a format compliant with the Logfile Analyzer\. |
| [Stringify\<T\>\(T\)](./ModdedModule/Stringify.md) | Converts `source` into a `System.String` representation of `source`\. |
| [Log\<T\>\(T, LogType\)](./ModdedModule/Log.md) | Logs and formats a message to the Unity Console in a format compliant with the Logfile Analyzer\. |
| [Log\<T\>\(T, params object\[\]\)](./ModdedModule/Log.md) | Logs and formats a message to the Unity Console in a format compliant with the Logfile Analyzer\. |
| [LogLower\(string\)](./ModdedModule/LogLower.md) | Logs and formats a message to the Unity Console in a format not compliant with the Logfile Analyzer\. |
| [LogLower\<T\>\(T, LogType\)](./ModdedModule/LogLower.md) | Logs and formats a message to the Unity Console in a format not compliant with the Logfile Analyzer\. |
| [LogLower\<T\>\(T, params object\[\]\)](./ModdedModule/LogLower.md) | Logs and formats a message to the Unity Console in a format not compliant with the Logfile Analyzer\. |
| [OnActivate\(\)](./ModdedModule/OnActivate.md) | The method that is called when the lights are turned on\. Automatically hooked in Awake\. |
| [OnException\(string\)](./ModdedModule/OnException.md) | The method that is called when an unhandled `Exception` is thrown by this module type\. |

## Properties

| Name | Summary |
|------|---------|
| [Children](./ModdedModule/Children.md) | Gets the children of the top\-level selectable\. |
| [Matrix](./ModdedModule/Matrix.md) | Gets the children of the top\-level selectable\. |
| [Status](./ModdedModule/Status.md) | Gets the current solve/strike status of the module\. |
| [Id](./ModdedModule/Id.md) | Gets the mod id\. Override this if you are working with an assembly with a different name than your mod id\. |

