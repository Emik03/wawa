### [Wawa.IO](Wawa.IO.md 'Wawa.IO').[Config&lt;T&gt;](Config_T_.md 'Wawa.IO.Config<T>')

## Config<T>.ToString() Method

Deserializes, then re-serializes the file according to [Serialize&lt;TSerialize&gt;(TSerialize)](Config.Serialize(TSerialize).md 'Wawa.IO.Config.Serialize<TSerialize>(TSerialize)').  
In the editor, this method serializes the default value of the constructor in [T](Config_T_.md#Wawa.IO.Config_T_.T 'Wawa.IO.Config<T>.T').

```csharp
public override string ToString();
```

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string representation of the value from [Read&lt;T&gt;(this Config&lt;T&gt;)](Config.Read(Config).md 'Wawa.IO.Config.Read<T>(this Wawa.IO.Config<T>)').