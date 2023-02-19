### [Wawa.Modules](Wawa.Modules.md 'Wawa.Modules')

## ModdedModule Class

A [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') that handles general Keep Talking and Nobody Explodes modded module behaviour.

```csharp
public abstract class ModdedModule : Wawa.Unity.CachedBehaviour
```

Inheritance [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [Wawa.Unity.CachedBehaviour](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Unity.CachedBehaviour 'Wawa.Unity.CachedBehaviour') &#129106; ModdedModule

| Properties | |
| :--- | :--- |
| [Children](ModdedModule.Children.md 'Wawa.Modules.ModdedModule.Children') | Gets the children of the top-level selectable. |
| [Id](ModdedModule.Id.md 'Wawa.Modules.ModdedModule.Id') | Gets the mod id. Override this if you are working with an assembly with a different name than your mod id. |
| [Matrix](ModdedModule.Matrix.md 'Wawa.Modules.ModdedModule.Matrix') | Gets the children of the top-level selectable. |
| [Status](ModdedModule.Status.md 'Wawa.Modules.ModdedModule.Status') | Gets the current solve/strike status of the module. |

| Methods | |
| :--- | :--- |
| [Awake()](ModdedModule.Awake().md 'Wawa.Modules.ModdedModule.Awake()') | Logs version numbers. Be sure to call this method if you are implementing Awake. |
| [Log&lt;T&gt;(T, LogType)](ModdedModule.Log.ZGbWJ5KQlnZIB0p5Minu/w.md 'Wawa.Modules.ModdedModule.Log<T>(T, LogType)') | Logs and formats a message to the Unity Console in a format compliant with the Logfile Analyzer. |
| [Log&lt;T&gt;(T, object[])](ModdedModule.Log.icB6E+1Ogk34YLaSRClvVg.md 'Wawa.Modules.ModdedModule.Log<T>(T, object[])') | Logs and formats a message to the Unity Console in a format compliant with the Logfile Analyzer. |
| [LogLower&lt;T&gt;(T, LogType)](ModdedModule.LogLower.X9Ct9gqIFzN2MpEP2pj1BA.md 'Wawa.Modules.ModdedModule.LogLower<T>(T, LogType)') | Logs and formats a message to the Unity Console in a format not compliant with the Logfile Analyzer. |
| [LogLower&lt;T&gt;(T, object[])](ModdedModule.LogLower.4T2RJXwCmcOsm32QPbDiGw.md 'Wawa.Modules.ModdedModule.LogLower<T>(T, object[])') | Logs and formats a message to the Unity Console in a format not compliant with the Logfile Analyzer. |
| [OnActivate()](ModdedModule.OnActivate().md 'Wawa.Modules.ModdedModule.OnActivate()') | The method that is called when the lights are turned on. Automatically hooked in Awake. |
| [OnDisable()](ModdedModule.OnDisable().md 'Wawa.Modules.ModdedModule.OnDisable()') | Subscribes [UnityEngine.Application.logMessageReceived](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Application.logMessageReceived 'UnityEngine.Application.logMessageReceived') and [KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate'). |
| [OnEnable()](ModdedModule.OnEnable().md 'Wawa.Modules.ModdedModule.OnEnable()') | Unsubscribes [UnityEngine.Application.logMessageReceived](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Application.logMessageReceived 'UnityEngine.Application.logMessageReceived') and [KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate'). |
| [OnException(string)](ModdedModule.OnException.lBV2gm4ooVnibY5wimmWgQ.md 'Wawa.Modules.ModdedModule.OnException(string)') | The method that is called when an unhandled [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') is thrown by this module type. |
| [Play(Transform, Sound[])](ModdedModule.Play.z1zsYDzCNLXAn4XRglnNZw.md 'Wawa.Modules.ModdedModule.Play(Transform, Wawa.Modules.Sound[])') | Plays one or more sounds from a specified [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform'). |
| [Play(Sound[])](ModdedModule.Play.ynf3u8+pZHqKb89XCv7eFg.md 'Wawa.Modules.ModdedModule.Play(Wawa.Modules.Sound[])') | Plays one or more sounds from the module [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform'). |
| [PlayEnum&lt;T&gt;(T, Transform)](ModdedModule.PlayEnum.Ty1E/DhGg20IkUL9MRPzFQ.md 'Wawa.Modules.ModdedModule.PlayEnum<T>(T, Transform)') | Plays one or more sounds from a specified [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform'). |
| [Shake(KMSelectable, float, Sound[])](ModdedModule.Shake.nlFFuwD4coNBXXjtGYhAjg.md 'Wawa.Modules.ModdedModule.Shake(KMSelectable, float, Wawa.Modules.Sound[])') | Plays sounds and shakes the bomb from a selectable. |
| [Solve(string, object[])](ModdedModule.Solve.nIcmVvqyfs2ihIVLcDJ81A.md 'Wawa.Modules.ModdedModule.Solve(string, object[])') | Solves the module. |
| [Strike(string, object[])](ModdedModule.Strike.zlRt8R6FbQCu8oNTRD4I7Q.md 'Wawa.Modules.ModdedModule.Strike(string, object[])') | Strikes the module. |
