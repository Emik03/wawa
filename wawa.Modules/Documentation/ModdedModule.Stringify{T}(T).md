### [wawa.Modules](wawa.Modules.md 'wawa.Modules').[ModdedModule](ModdedModule.md 'wawa.Modules.ModdedModule')

## ModdedModule.Stringify<T>(T) Method

Converts [source](ModdedModule.Stringify{T}(T).md#wawa.Modules.ModdedModule.Stringify_T_(T).source 'wawa.Modules.ModdedModule.Stringify<T>(T).source') into a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of [source](ModdedModule.Stringify{T}(T).md#wawa.Modules.ModdedModule.Stringify_T_(T).source 'wawa.Modules.ModdedModule.Stringify<T>(T).source').

```csharp
public virtual string Stringify<T>(T source);
```
#### Type parameters

<a name='wawa.Modules.ModdedModule.Stringify_T_(T).T'></a>

`T`

The type of the source.
#### Parameters

<a name='wawa.Modules.ModdedModule.Stringify_T_(T).source'></a>

`source` [T](ModdedModule.Stringify{T}(T).md#wawa.Modules.ModdedModule.Stringify_T_(T).T 'wawa.Modules.ModdedModule.Stringify<T>(T).T')

The item to get a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
[source](ModdedModule.Stringify{T}(T).md#wawa.Modules.ModdedModule.Stringify_T_(T).source 'wawa.Modules.ModdedModule.Stringify<T>(T).source') as [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').

### Remarks
  
Used for logging, such as [Log&lt;T&gt;(T, object[])](ModdedModule.Log{T}(T,object[]).md 'wawa.Modules.ModdedModule.Log<T>(T, object[])').