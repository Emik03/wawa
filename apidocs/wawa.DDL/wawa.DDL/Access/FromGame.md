# FromGame Method

namespace: [wawa\.DDL](../../wawa.DDL.md)<br />
assembly: [wawa\.DDL](../../../wawa.DDL.md)



## Overloads

| Name | Summary |
|------|---------|
| FromGame\<T\>\(Converter\<DBNull, T\>, T, string\) | Method for obtaining something from the game, ensuring that the Unity editor stays happy\. |
| FromGame\<T, TResult\>\(T, Converter\<T, TResult\>, TResult, string\) | Method for obtaining something from the game, ensuring that the Unity editor stays happy\. |

## FromGame\<T\>\(Converter\<DBNull, T\>, T, string\)

Method for obtaining something from the game, ensuring that the Unity editor stays happy\.

```csharp
public static T FromGame<T>(Converter<DBNull, T> ktane ,T def = null ,string overriden = "");
```

### Type Parameters

__T__

The type of the return, be sure that this doesn't come from the game\.

### Parameters

__ktane__ : `Converter<DBNull, T>`

The factory containing one or more references that may be unavailable\.

__def__ : `T`

The value to return instead, since `ktane` is for in\-game only\.

__overriden__ : `string`

The name of the factory to invoke\.

### Return Value

`T`

The value from `ktane`, or `default`\.

## FromGame\<T, TResult\>\(T, Converter\<T, TResult\>, TResult, string\)

Method for obtaining something from the game, ensuring that the Unity editor stays happy\.

```csharp
public static TResult FromGame<T ,TResult>(T context ,Converter<T, TResult> ktane ,TResult def = null ,string overriden = "");
```

### Type Parameters

__T__

The context item, be sure that this doesn't come from the game\.

__TResult__

The type of the return, be sure that this doesn't come from the game\.

### Parameters

__context__ : `T`

The context element to pass into the callback\.

__ktane__ : `Converter<T, TResult>`

The factory containing one or more references that may be unavailable\.

__def__ : `TResult`

The value to return instead, since `ktane` is for in\-game only\.

__overriden__ : `string`

The name of the factory to invoke\.

### Return Value

`TResult`

The value from `ktane`, or `default`\.

