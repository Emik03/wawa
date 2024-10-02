### [wawa.IO](wawa.IO.md 'wawa.IO').[Config&lt;T&gt;](Config{T}.md 'wawa.IO.Config<T>')

## Config<T>.operator ==(Config<T>, Config<T>) Operator

Determines whether both instances are both [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') or both instances.

```csharp
public static bool operator ==(wawa.IO.Config<T> left, wawa.IO.Config<T> right);
```
#### Parameters

<a name='wawa.IO.Config_T_.op_Equality(wawa.IO.Config_T_,wawa.IO.Config_T_).left'></a>

`left` [wawa.IO.Config&lt;](Config{T}.md 'wawa.IO.Config<T>')[T](Config{T}.md#wawa.IO.Config_T_.T 'wawa.IO.Config<T>.T')[&gt;](Config{T}.md 'wawa.IO.Config<T>')

The left-hand side operator.

<a name='wawa.IO.Config_T_.op_Equality(wawa.IO.Config_T_,wawa.IO.Config_T_).right'></a>

`right` [wawa.IO.Config&lt;](Config{T}.md 'wawa.IO.Config<T>')[T](Config{T}.md#wawa.IO.Config_T_.T 'wawa.IO.Config<T>.T')[&gt;](Config{T}.md 'wawa.IO.Config<T>')

The right-hand side operator.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if both share the same [FilePath](Config{T}.FilePath.md 'wawa.IO.Config<T>.FilePath'),  
otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').