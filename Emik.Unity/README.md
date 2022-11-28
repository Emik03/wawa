# Emik.Unity

Defines the `CachedBehavior` type, which provides a simple API for caching Unity API calls such as [`GetComponent`](https://docs.unity3d.com/2017.4/Documentation/ScriptReference/Component.GetComponent.html).

---

- [Dependencies](#dependencies)
- [Example](#example)
- [Contribute](#contribute)
- [License](#license)

---

## Dependencies

| Library              | Depends on... | Used in... |
|----------------------|---------------|------------|
| [Emik.Optionals]()   | ❌             | ️❌         |
| [Emik.Unity]()       | ❌             | ❌️         |
| [wawa.Editors]()     | ❌             | ❌          |
| [wawa.Extensions]()  | ❌             | ❌          |
| [wawa.IO]()          | ❌             | ✔️         |
| [wawa.Modules]()     | ❌             | ✔️         |
| [wawa.TwitchPlays]() | ❌             | ✔️         |

## Example

```csharp
using Emik.Optionals;
using UnityEngine;

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
