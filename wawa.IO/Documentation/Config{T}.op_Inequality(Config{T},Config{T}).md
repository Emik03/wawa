### [wawa.IO](wawa.IO.md 'wawa.IO').[Config&lt;T&gt;](Config{T}.md 'wawa.IO.Config<T>')

## Config<T>.operator !=(Config<T>, Config<T>) Operator

Determines whether both instances are one of [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') and the other instanced.

```csharp
public static bool operator !=(wawa.IO.Config<T> left, wawa.IO.Config<T> right);
```
#### Parameters

<a name='wawa.IO.Config_T_.op_Inequality(wawa.IO.Config_T_,wawa.IO.Config_T_).left'></a>

`left` [wawa.IO.Config&lt;](Config{T}.md 'wawa.IO.Config<T>')[T](Config{T}.md#wawa.IO.Config_T_.T 'wawa.IO.Config<T>.T')[&gt;](Config{T}.md 'wawa.IO.Config<T>')

The left-hand side.

<a name='wawa.IO.Config_T_.op_Inequality(wawa.IO.Config_T_,wawa.IO.Config_T_).right'></a>

`right` [wawa.IO.Config&lt;](Config{T}.md 'wawa.IO.Config<T>')[T](Config{T}.md#wawa.IO.Config_T_.T 'wawa.IO.Config<T>.T')[&gt;](Config{T}.md 'wawa.IO.Config<T>')

The right-hand side.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if both do not share the same [FilePath](Config{T}.FilePath.md 'wawa.IO.Config<T>.FilePath'),  
otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').