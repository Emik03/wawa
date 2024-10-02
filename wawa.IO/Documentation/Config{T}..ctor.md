### [wawa.IO](wawa.IO.md 'wawa.IO').[Config&lt;T&gt;](Config{T}.md 'wawa.IO.Config<T>')

## Config() Constructor

Initializes a new instance of the [Config&lt;T&gt;](Config{T}.md 'wawa.IO.Config<T>') class.

```csharp
public Config();
```

### Remarks
- The target file name is implicitly gotten by the name of the assembly that called this constructor.  
- A file will automatically be made if it doesn't exist.  
- A JSON property defined in the type [T](Config{T}.md#wawa.IO.Config_T_.T 'wawa.IO.Config<T>.T') that doesn't exist in the file  
  will automatically be appended with a new default instance of [T](Config{T}.md#wawa.IO.Config_T_.T 'wawa.IO.Config<T>.T')'s values.  
- In the editor, this constructor will not merge the default of type [T](Config{T}.md#wawa.IO.Config_T_.T 'wawa.IO.Config<T>.T') with the file.