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

`context` [T](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult).md#Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).T 'Wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult).T')

The context element to pass into the callback.

<a name='Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).factory'></a>

`factory` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult).md#Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).T 'Wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TResult](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult).md#Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).TResult 'Wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The factory containing one or more references that may be unavailable.

<a name='Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).def'></a>

`def` [TResult](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult).md#Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).TResult 'Wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult).TResult')

The value to return instead, since [factory](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult).md#Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).factory 'Wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult).factory') is for in-game only.

#### Returns
[TResult](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult).md#Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).TResult 'Wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult).TResult')  
The value from [factory](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult).md#Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).factory 'Wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult).factory'), or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').

### Remarks
  
This API primarily exists for if you already have a reference to Assembly-CSharp.dll, typically involving using  
a class library to allow such a reference. If you do not use a class library, then this method can be ignored in  
favor of wrappers such as [Lookup](Lookup.md 'Wawa.DDL.Lookup'), [Missions](Missions.md 'Wawa.DDL.Missions'), or [Preferences](Preferences.md 'Wawa.DDL.Preferences').  
  
Unlike the other APIs exposed by these libraries, the return value of [TResult](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult).md#Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).TResult 'Wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult).TResult')'s  
nullability may not be trusted if it is a reference type or [System.Nullable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1'), even when  
[def](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult).md#Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).def 'Wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult).def') itself is non-null. As such, enable nullable reference types or use  
[Wawa.Optionals.Maybe.AsMaybe&lt;&gt;.Nullable{&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe.AsMaybe--1#Wawa_Optionals_Maybe_AsMaybe__1_System_Nullable{__0}_ 'Wawa.Optionals.Maybe.AsMaybe``1(System.Nullable{``0})') to enforce type safety.  
  
To guarantee the DDL pattern, ensure that [T](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult).md#Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).T 'Wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult).T') and [TResult](Access.FromGame{T,TResult}(T,Converter{T,TResult},TResult).md#Wawa.DDL.Access.FromGame_T,TResult_(T,System.Converter_T,TResult_,TResult).TResult 'Wawa.DDL.Access.FromGame<T,TResult>(T, System.Converter<T,TResult>, TResult).TResult') are not  
from a potentially unavailable reference, and avoid creating closures that capture state without first  
downcasting to [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') beforehand, and recasting within the closure.  
  
Never assume functions or fields pulled directly from Assembly-CSharp.dll are safe and guaranteed non-null.