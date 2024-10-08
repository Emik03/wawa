### [wawa.IO](wawa.IO.md 'wawa.IO').[Config&lt;T&gt;](Config{T}.md 'wawa.IO.Config<T>')

## Config<T>.ToString() Method

Deserializes, then re-serializes the file according to [Serialize&lt;TSerialize&gt;(TSerialize)](Config.Serialize{TSerialize}(TSerialize).md 'wawa.IO.Config.Serialize<TSerialize>(TSerialize)').  
In the editor, this method serializes the default value of the constructor in [T](Config{T}.md#wawa.IO.Config_T_.T 'wawa.IO.Config<T>.T').

```csharp
public override string ToString();
```

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string representation of the value from [Read&lt;T&gt;(this Config&lt;T&gt;)](Config.Read{T}(Config{T}).md 'wawa.IO.Config.Read<T>(this wawa.IO.Config<T>)').