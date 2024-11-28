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
| [ToString\(\)](./ModdedModule/ToString.md) |  |
| [Stringify\<T\>\(T\)](./ModdedModule/Stringify.md) | Converts `source` into a `System.String` representation of `source`\. |
| [Stringify\<T\>\(T, string\)](./ModdedModule/Stringify.md) | Converts `source` into a `System.String` representation of `source`\. |
| [Log\(InterpolatedStringHandlerEnumerable, LogType\)](./ModdedModule/Log.md) | Formats and logs the parameter, which will show up under the module's tab in the Logfile Analyzer\. |
| [LogLower\(InterpolatedStringHandlerEnumerable, LogType\)](./ModdedModule/LogLower.md) | Formats and logs the parameter, which will remain hidden under the module's tab in the Logfile Analyzer\. |
| [Play\(params Sound\[\]\)](./ModdedModule/Play.md) | Plays one or more sounds from the module `Transform`\. |
| [Play\(Transform, params Sound\[\]\)](./ModdedModule/Play.md) | Plays one or more sounds from the specified `Transform`\. |
| [MissionSettings\(\)](./ModdedModule/MissionSettings.md) | Attempts to parse the `JToken` from the mission description\. |
| [MissionSettings\<T\>\(\)](./ModdedModule/MissionSettings.md) | Attempts to parse the `JToken` from the mission description\. |
| [Shake\(KMSelectable, float, params Sound\[\]\)](./ModdedModule/Shake.md) | Plays sounds and shakes the bomb from a selectable\. |
| [Solve\(string, params object\[\]\)](./ModdedModule/Solve.md) | Solves the module\. |
| [Strike\(string, params object\[\]\)](./ModdedModule/Strike.md) | Strikes the module\. |
| [Log\<T\>\(T, LogType\)](./ModdedModule/Log.md) | Formats and logs the parameter, which will show up under the module's tab in the Logfile Analyzer\. |
| [Log\<T\>\(T, params object\[\]\)](./ModdedModule/Log.md) | Formats and logs the parameter, which will show up under the module's tab in the Logfile Analyzer\. |
| [LogLower\<T\>\(T, LogType\)](./ModdedModule/LogLower.md) | Formats and logs the parameter, which will remain hidden under the module's tab in the Logfile Analyzer\. |
| [LogLower\<T\>\(T, params object\[\]\)](./ModdedModule/LogLower.md) | Formats and logs the parameter, which will remain hidden under the module's tab in the Logfile Analyzer\. |
| [Awake\(\)](./ModdedModule/Awake.md) | Logs the version number for both the module and this library\. |
| [OnActivate\(\)](./ModdedModule/OnActivate.md) | The method that is called when the lights are turned on\. Automatically hooked in Awake\. |
| [OnDisable\(\)](./ModdedModule/OnDisable.md) | Unsubscribes from `Application.logMessageReceived`, `KMBombModule.OnActivate`,`KMBombModule.OnPass`, and `KMBombModule.OnStrike`\. |
| [OnEnable\(\)](./ModdedModule/OnEnable.md) | Subscribes from `Application.logMessageReceived`, `KMBombModule.OnActivate`,`KMBombModule.OnPass`, and `KMBombModule.OnStrike`\. |
| [OnException\(string\)](./ModdedModule/OnException.md) | The method that is called when an unhandled `Exception` is thrown by this module type\. |

## Properties

| Name | Summary |
|------|---------|
| [Children](./ModdedModule/Children.md) | Gets the children of the top\-level selectable\. |
| [Matrix](./ModdedModule/Matrix.md) | Gets the children of the top\-level selectable\. |
| [Status](./ModdedModule/Status.md) | Gets the current solve/strike status of the module\. |
| [Id](./ModdedModule/Id.md) | Gets the mod id\. Override this if you are working with an assembly with a different name than your mod id\. |

