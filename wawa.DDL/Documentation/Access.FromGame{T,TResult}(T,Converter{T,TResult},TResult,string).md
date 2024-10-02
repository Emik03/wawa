### [wawa.DDL](wawa.DDL.md 'wawa.DDL').[Access](Access.md 'wawa.DDL.Access')

## Access.FromGame<T,TResult>(T, Converter<T,TResult>, TResult, string) Method

Method for obtaining something from the game, ensuring that the Unity editor stays happy.

```csharp
public static TResult FromGame<T,TResult>(T context, System.Converter<T,TResult> ktane, TResult def=default(TResult), string overriden="");
```
#### Type parameters

<a name='wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult,string).T'></a>

`T`

The context item, be sure that this doesn't come from the game.

<a name='wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult,string).TResult'></a>

`TResult`

The type of the return, be sure that this doesn't come from the game.
#### Parameters

<a name='wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult,string).context'></a>

`context` [T](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult,string).md#wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult,string).T 'wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult, string).T')

The context element to pass into the callback.

<a name='wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult,string).ktane'></a>

`ktane` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult,string).md#wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult,string).T 'wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult, string).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TResult](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult,string).md#wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult,string).TResult 'wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult, string).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The factory containing one or more references that may be unavailable.

<a name='wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult,string).def'></a>

`def` [TResult](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult,string).md#wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult,string).TResult 'wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult, string).TResult')

The value to return instead, since [ktane](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult,string).md#wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult,string).ktane 'wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult, string).ktane') is for in-game only.

<a name='wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult,string).overriden'></a>

`overriden` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the factory to invoke.

#### Returns
[TResult](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult,string).md#wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult,string).TResult 'wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult, string).TResult')  
The value from [ktane](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult,string).md#wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult,string).ktane 'wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult, string).ktane'), or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').

### Remarks
  
This API primarily exists for if you already have a reference to Assembly-CSharp.dll, typically involving using  
a class library to allow such a reference. If you do not use a class library, then this method can be ignored in  
favor of wrappers such as [Lookup](Lookup.md 'wawa.DDL.Lookup'), [Missions](Missions.md 'wawa.DDL.Missions'), or [Preferences](Preferences.md 'wawa.DDL.Preferences').  
  
Unlike the other APIs exposed by these libraries, the return value of [TResult](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult,string).md#wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult,string).TResult 'wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult, string).TResult')'s  
nullability may not be trusted if it is a reference type or [System.Nullable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1'), even when  
[def](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult,string).md#wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult,string).def 'wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult, string).def') itself is non-null. As such, enable nullable reference types or use  
[wawa.Optionals.Maybe.AsMaybe&lt;&gt;.Nullable{&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe.AsMaybe--1#wawa_Optionals_Maybe_AsMaybe__1_System_Nullable{__0}_ 'wawa.Optionals.Maybe.AsMaybe``1(System.Nullable{``0})') to enforce type safety.  
  
To guarantee the DDL pattern, ensure that [T](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult,string).md#wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult,string).T 'wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult, string).T') and [TResult](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult,string).md#wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult,string).TResult 'wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult, string).TResult') are not  
from a potentially unavailable reference, and avoid creating closures that capture state without first  
downcasting to [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') beforehand, and recasting within the closure.  
  
Never assume functions or fields pulled directly from Assembly-CSharp.dll are safe and guaranteed non-null.