### [Wawa.IO](Wawa.IO.md 'Wawa.IO')

## PathFinder Class

Access to the paths and contents of files within folder mod directory.

```csharp
public static class PathFinder
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; PathFinder

| Properties | |
| :--- | :--- |
| [Caller](PathFinder.Caller.md 'Wawa.IO.PathFinder.Caller') | Gets the [System.Reflection.AssemblyName](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.AssemblyName 'System.Reflection.AssemblyName') of the caller that invoked the method calling this. |

| Methods | |
| :--- | :--- |
| [AssemblyLog(string, LogType, string)](PathFinder.AssemblyLog(string,LogType,string).md 'Wawa.IO.PathFinder.AssemblyLog(string, LogType, string)') | Logs a message to the Unity Console with the assembly's name that called this. |
| [GetAssets&lt;T&gt;(string, string)](PathFinder.GetAssets{T}(string,string).md 'Wawa.IO.PathFinder.GetAssets<T>(string, string)') | Loads and returns assets from disk. |
| [GetDirectory(string)](PathFinder.GetDirectory(string).md 'Wawa.IO.PathFinder.GetDirectory(string)') | Gets the absolute directory of the mod. |
| [GetFile(string, string)](PathFinder.GetFile(string,string).md 'Wawa.IO.PathFinder.GetFile(string, string)') | Gets the absolute directory of the file located inside the mod directory. |
| [GetModInfo(string)](PathFinder.GetModInfo(string).md 'Wawa.IO.PathFinder.GetModInfo(string)') | Gets and deserializes the [ModInfo](ModInfo.md 'Wawa.IO.ModInfo') file located in every mod's root directory. |
| [GetUnmanaged&lt;T&gt;(string, string, string)](PathFinder.GetUnmanaged{T}(string,string,string).md 'Wawa.IO.PathFinder.GetUnmanaged<T>(string, string, string)') | Gets an unmanaged function from an external library. |
