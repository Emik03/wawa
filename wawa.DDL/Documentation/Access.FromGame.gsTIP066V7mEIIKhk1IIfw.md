### [Wawa.DDL](Wawa.DDL.md 'Wawa.DDL').[Access](Access.md 'Wawa.DDL.Access')

## Access.FromGame<T,TResult>(T, Converter<T,TResult>, TResult) Method

Method for obtaining something from the game, ensuring that the Unity editor stays happy.

```csharp
public static TResult FromGame<T,TResult>(T context, System.Converter<T,TResult> factory, TResult def=default(TResult));
```
#### Type parameters

<a name='Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).T'></a>

`T`

The context item, be sure that this doesn't come from the game.

<a name='Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).TResult'></a>

`TResult`

The type of the return, be sure that this doesn't come from the game.
#### Parameters

<a name='Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).context'></a>

`context` [T](Access.FromGame.gsTIP066V7mEIIKhk1IIfw.md#Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).T 'Wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult).T')

The context element to pass into the callback.

<a name='Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).factory'></a>

`factory` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T](Access.FromGame.gsTIP066V7mEIIKhk1IIfw.md#Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).T 'Wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TResult](Access.FromGame.gsTIP066V7mEIIKhk1IIfw.md#Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).TResult 'Wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The factory containing the game data.

<a name='Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).def'></a>

`def` [TResult](Access.FromGame.gsTIP066V7mEIIKhk1IIfw.md#Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).TResult 'Wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult).TResult')

The default value.

#### Returns
[TResult](Access.FromGame.gsTIP066V7mEIIKhk1IIfw.md#Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).TResult 'Wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult).TResult')  
The value from [factory](Access.FromGame.gsTIP066V7mEIIKhk1IIfw.md#Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).factory 'Wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult).factory'), or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').