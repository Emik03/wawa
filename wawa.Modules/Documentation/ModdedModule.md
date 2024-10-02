### [wawa.Modules](wawa.Modules.md 'wawa.Modules')

## ModdedModule Class

The [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') that handles general Keep Talking and Nobody Explodes modded module behaviour.

```csharp
public abstract class ModdedModule : wawa.Unity.CachedBehaviour
```

Inheritance [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [wawa.Unity.CachedBehaviour](https://docs.microsoft.com/en-us/dotnet/api/wawa.Unity.CachedBehaviour 'wawa.Unity.CachedBehaviour') &#129106; ModdedModule

| Properties | |
| :--- | :--- |
| [Children](ModdedModule.Children.md 'wawa.Modules.ModdedModule.Children') | Gets the children of the top-level selectable. |
| [Id](ModdedModule.Id.md 'wawa.Modules.ModdedModule.Id') | Gets the mod id. Override this if you are working with an assembly with a different name than your mod id. |
| [Matrix](ModdedModule.Matrix.md 'wawa.Modules.ModdedModule.Matrix') | Gets the children of the top-level selectable. |
| [Status](ModdedModule.Status.md 'wawa.Modules.ModdedModule.Status') | Gets the current solve/strike status of the module. |

| Methods | |
| :--- | :--- |
| [Awake()](ModdedModule.Awake.md 'wawa.Modules.ModdedModule.Awake()') | Logs version numbers. Be sure to call this method if you are implementing Awake. |
| [Log(string)](ModdedModule.Log(string).md 'wawa.Modules.ModdedModule.Log(string)') | Logs and formats a message to the Unity Console in a format compliant with the Logfile Analyzer. |
| [Log&lt;T&gt;(T, LogType)](ModdedModule.Log{T}(T,LogType).md 'wawa.Modules.ModdedModule.Log<T>(T, LogType)') | Logs and formats a message to the Unity Console in a format compliant with the Logfile Analyzer. |
| [Log&lt;T&gt;(T, object[])](ModdedModule.Log{T}(T,object[]).md 'wawa.Modules.ModdedModule.Log<T>(T, object[])') | Logs and formats a message to the Unity Console in a format compliant with the Logfile Analyzer. |
| [LogLower(string)](ModdedModule.LogLower(string).md 'wawa.Modules.ModdedModule.LogLower(string)') | Logs and formats a message to the Unity Console in a format not compliant with the Logfile Analyzer. |
| [LogLower&lt;T&gt;(T, LogType)](ModdedModule.LogLower{T}(T,LogType).md 'wawa.Modules.ModdedModule.LogLower<T>(T, LogType)') | Logs and formats a message to the Unity Console in a format not compliant with the Logfile Analyzer. |
| [LogLower&lt;T&gt;(T, object[])](ModdedModule.LogLower{T}(T,object[]).md 'wawa.Modules.ModdedModule.LogLower<T>(T, object[])') | Logs and formats a message to the Unity Console in a format not compliant with the Logfile Analyzer. |
| [OnActivate()](ModdedModule.OnActivate.md 'wawa.Modules.ModdedModule.OnActivate()') | The method that is called when the lights are turned on. Automatically hooked in Awake. |
| [OnDisable()](ModdedModule.OnDisable.md 'wawa.Modules.ModdedModule.OnDisable()') | Unsubscribes from [UnityEngine.Application.logMessageReceived](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Application.logMessageReceived 'UnityEngine.Application.logMessageReceived'), [KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate'),<br/>[KMBombModule.OnPass](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnPass 'KMBombModule.OnPass'), and [KMBombModule.OnStrike](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnStrike 'KMBombModule.OnStrike'). |
| [OnEnable()](ModdedModule.OnEnable.md 'wawa.Modules.ModdedModule.OnEnable()') | Subscribes from [UnityEngine.Application.logMessageReceived](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Application.logMessageReceived 'UnityEngine.Application.logMessageReceived'), [KMBombModule.OnActivate](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnActivate 'KMBombModule.OnActivate'),<br/>[KMBombModule.OnPass](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnPass 'KMBombModule.OnPass'), and [KMBombModule.OnStrike](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule.OnStrike 'KMBombModule.OnStrike'). |
| [OnException(string)](ModdedModule.OnException(string).md 'wawa.Modules.ModdedModule.OnException(string)') | The method that is called when an unhandled [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') is thrown by this module type. |
| [Play(Transform, Sound[])](ModdedModule.Play(Transform,Sound[]).md 'wawa.Modules.ModdedModule.Play(Transform, wawa.Modules.Sound[])') | Plays one or more sounds from a specified [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform'). |
| [Play(Sound[])](ModdedModule.Play(Sound[]).md 'wawa.Modules.ModdedModule.Play(wawa.Modules.Sound[])') | Plays one or more sounds from the module [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform'). |
| [Play&lt;T&gt;(T, Transform)](ModdedModule.Play{T}(T,Transform).md 'wawa.Modules.ModdedModule.Play<T>(T, Transform)') | Plays one or more sounds from a specified [UnityEngine.Transform](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Transform 'UnityEngine.Transform'). |
| [Shake(KMSelectable, float, Sound[])](ModdedModule.Shake(KMSelectable,float,Sound[]).md 'wawa.Modules.ModdedModule.Shake(KMSelectable, float, wawa.Modules.Sound[])') | Plays sounds and shakes the bomb from a selectable. |
| [Solve(string, object[])](ModdedModule.Solve(string,object[]).md 'wawa.Modules.ModdedModule.Solve(string, object[])') | Solves the module. |
| [Strike(string, object[])](ModdedModule.Strike(string,object[]).md 'wawa.Modules.ModdedModule.Strike(string, object[])') | Strikes the module. |
| [Stringify&lt;T&gt;(T)](ModdedModule.Stringify{T}(T).md 'wawa.Modules.ModdedModule.Stringify<T>(T)') | Converts [source](ModdedModule.Stringify{T}(T).md#wawa.Modules.ModdedModule.Stringify_T_(T).source 'wawa.Modules.ModdedModule.Stringify<T>(T).source') into a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of [source](ModdedModule.Stringify{T}(T).md#wawa.Modules.ModdedModule.Stringify_T_(T).source 'wawa.Modules.ModdedModule.Stringify<T>(T).source'). |
