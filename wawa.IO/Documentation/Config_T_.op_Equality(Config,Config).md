### [Wawa.IO](Wawa.IO.md 'Wawa.IO').[Config&lt;T&gt;](Config_T_.md 'Wawa.IO.Config<T>')

## Config<T>.operator ==(Config<T>, Config<T>) Operator

Determines whether both instances are both [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') or both instances.

```csharp
public static bool operator ==(Wawa.IO.Config<T> left, Wawa.IO.Config<T> right);
```
#### Parameters

<a name='Wawa.IO.Config_T_.op_Equality(Wawa.IO.Config_T_,Wawa.IO.Config_T_).left'></a>

`left` [Wawa.IO.Config&lt;](Config_T_.md 'Wawa.IO.Config<T>')[T](Config_T_.md#Wawa.IO.Config_T_.T 'Wawa.IO.Config<T>.T')[&gt;](Config_T_.md 'Wawa.IO.Config<T>')

The left-hand side operator.

<a name='Wawa.IO.Config_T_.op_Equality(Wawa.IO.Config_T_,Wawa.IO.Config_T_).right'></a>

`right` [Wawa.IO.Config&lt;](Config_T_.md 'Wawa.IO.Config<T>')[T](Config_T_.md#Wawa.IO.Config_T_.T 'Wawa.IO.Config<T>.T')[&gt;](Config_T_.md 'Wawa.IO.Config<T>')

The right-hand side operator.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if both share the same [FilePath](Config_T_.FilePath().md 'Wawa.IO.Config<T>.FilePath'),  
otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').