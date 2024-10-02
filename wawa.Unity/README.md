# wawa.Unity

Defines the `CachedBehavior` type, which provides a simple API for caching Unity API calls such as [`GetComponent`](https://docs.unity3d.com/2017.4/Documentation/ScriptReference/Component.GetComponent.html).

### [Documentation](https://github.com/Emik03/wawa/blob/main/wawa.Unity/Documentation/wawa.Unity.md)

---

- [Dependencies](#dependencies)
- [Example](#example)
- [Contribute](#contribute)
- [License](#license)

---

## Dependencies

| Library                                                                       | Depends on... | Used in... |
|-------------------------------------------------------------------------------|---------------|------------|
| [wawa.DDL](https://github.com/Emik03/wawa/tree/main/wawa.DDL)                 |               |            |
| [wawa.Editors](https://github.com/Emik03/wawa/tree/main/wawa.Editors)         |               |            |
| [wawa.Extensions](https://github.com/Emik03/wawa/tree/main/wawa.Extensions)   |               |            |
| [wawa.IO](https://github.com/Emik03/wawa/tree/main/wawa.IO)                   |               |            |
| [wawa.Modules](https://github.com/Emik03/wawa/tree/main/wawa.Modules)         |               | Yes        |
| [wawa.Optionals](https://github.com/Emik03/wawa/tree/main/wawa.Optionals)     |               |            |
| [wawa.Recall](https://github.com/Emik03/wawa/tree/main/wawa.Recall)           |               |            |
| [wawa.Schemas](https://github.com/Emik03/wawa/tree/main/wawa.Schemas)         |               |            |
| [wawa.TwitchPlays](https://github.com/Emik03/wawa/tree/main/wawa.TwitchPlays) |               | Yes        |

## Example

```csharp
using UnityEngine;
using wawa.Unity;

public sealed class Foo : CachedBehavior
{
    public int Bar { get; set }

    void Start()
    {
        Get<Foo>().Bar++;

        // Not inefficient, because the operation for 'Foo' has already been cached.
        Get<Foo>().Bar++;

        // Clears the cache.
        Clear();

        // GetComponents is called instead.
        Foo[] foos = Get<Foo[]>();

        // Maps it evenly in a 2-dimensional matrix.
        Foo[,] foos = Get<Foo[,]>();
    }
}
```

## Contribute

Issues and pull requests are welcome to help this repository be the best it can be.

## License

This repository falls under the [MPL-2 license](https://www.mozilla.org/en-US/MPL/2.0/).
