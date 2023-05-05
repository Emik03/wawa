### [Wawa.IO](Wawa.IO.md 'Wawa.IO').[PathFinder](PathFinder.md 'Wawa.IO.PathFinder')

## PathFinder.Caller Property

Gets the [System.Reflection.AssemblyName](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.AssemblyName 'System.Reflection.AssemblyName') of the caller that invoked the method calling this.

```csharp
public static System.Reflection.AssemblyName Caller { get; }
```

#### Property Value
[System.Reflection.AssemblyName](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.AssemblyName 'System.Reflection.AssemblyName')

### Remarks
  
This is used by the library to log itself, and obtain information about callers.