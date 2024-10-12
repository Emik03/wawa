# Notify Method

namespace: [wawa\.Extensions](../../wawa.Extensions.md)<br />
assembly: [wawa\.Extensions](../../../wawa.Extensions.md)



## Overloads

| Name | Summary |
|------|---------|
| Notify\(KMSelectable, KMSelectable\) | Notifies the game that the children list has been updated\. |
| Notify\<T\>\(T, params KMSelectable\[\]\) | Notifies the game that the children list has been updated\. |
| Notify\<T, TChild\>\(T, TChild\) | Notifies the game that the children list has been updated\. |

## Notify\(KMSelectable, KMSelectable\)

Notifies the game that the children list has been updated\.

```csharp
public static KMSelectable Notify(this KMSelectable selectable ,KMSelectable childrenToSelect = null);
```

### Parameters

__selectable__ : `KMSelectable`

The `KMSelectable` to update its children\.

__childrenToSelect__ : `KMSelectable`

The child `KMSelectable` to force a selection on, if specified\.

### Return Value

`KMSelectable`

The parameter `selectable`\.

## Notify\<T\>\(T, params KMSelectable\[\]\)

Notifies the game that the children list has been updated\.

```csharp
public static T Notify<T>(this T selectables ,params KMSelectable[] childrenToSelect);
```

### Type Parameters

__T__ : `IEnumerable<KMSelectable>`

The type of `IEnumerable<T>` containing `KMSelectable` instances\.


### Parameters

__selectables__ : `T`

The `IEnumerable<T>` of `KMSelectable` instances to update its children\.


__childrenToSelect__ : `KMSelectable`

The `Array` of children `KMSelectable` to force selections on, if specified\.


### Return Value

`T`

The parameter `selectables`\.

## Notify\<T, TChild\>\(T, TChild\)

Notifies the game that the children list has been updated\.

```csharp
public static T Notify<T ,TChild>(this T selectables ,TChild childrenToSelect);
```

### Type Parameters

__T__ : `IEnumerable<KMSelectable>`

The type of `IEnumerable<T>` containing `KMSelectable` instances\.


__TChild__ : `IEnumerable<KMSelectable>`

The type of `IEnumerable<T>` containing child `KMSelectable` instances\.


### Parameters

__selectables__ : `T`

The `IEnumerable<T>` of `KMSelectable` instances to update its children\.


__childrenToSelect__ : `TChild`

The `IEnumerable<T>` of children `KMSelectable` to force selections on, if specified\.


### Return Value

`T`

The parameter `selectables`\.

