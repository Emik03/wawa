### [wawa.DDL](wawa.DDL.md 'wawa.DDL')

## Access Class

A class for accessing things from the game.

```csharp
public static class Access
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Access

| Properties | |
| :--- | :--- |
| [IsKtane](Access.IsKtane.md 'wawa.DDL.Access.IsKtane') | Gets a value indicating whether the runtime is in-game. |
| [IsRewritten](Access.IsRewritten.md 'wawa.DDL.Access.IsRewritten') | Gets a value indicating whether the runtime is in a non-official game. |

| Methods | |
| :--- | :--- |
| [FromGame&lt;T,TResult&gt;(T, Converter&lt;T,TResult&gt;, TResult, string)](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult,string).md 'wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult, string)') | Method for obtaining something from the game, ensuring that the Unity editor stays happy. |
| [FromGame&lt;T&gt;(Converter&lt;DBNull,T&gt;, T, string)](Access.FromGame{T}(Converter{DBNull,T},T,string).md 'wawa.DDL.Access.FromGame<T>(System.Converter<System.DBNull,T>, T, string)') | Method for obtaining something from the game, ensuring that the Unity editor stays happy. |
