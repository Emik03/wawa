# wawa.IO

Adds types for KTaNE-related IO operations.

---

- [Dependencies](#dependencies)
- [Example](#example)
- [Contribute](#contribute)
- [License](#license)

---

## Dependencies

| Library              | Depends on... | Used in... |
|----------------------|---------------|------------|
| [Emik.Optionals]()   | ✔️            | ️❌         |
| [Emik.Unity]()       | ❌             | ️❌         |
| [wawa.DDL]()         | ✔️            | ❌️         |
| [wawa.Editors]()     | ❌             | ❌          |
| [wawa.Extensions]()  | ❌             | ❌          |
| [wawa.Modules]()     | ❌             | ✔️         |
| [wawa.TwitchPlays]() | ❌             | ✔️         |

## Example

```csharp
using System;
using UnityEngine;
using Wawa.IO;

ModInfo m = PathFinder.GetModInfo();

var path = PathFinder.GetFile("someFile.txt");

var action = PathFinder.GetUnmanaged<Action>("ffi_lib", "name_of_method");
action(); // Invoke FFI methods easily!

var conf = new Config<Foo>();

int someValue = conf.Read().Bar;

// Serialize then write.
conf.Write(new());

// Write directly.
conf.Write(
    """
    { "Foo": 1 }
    """
);

[Serializable]
public sealed class Foo
{
    public int Bar { get; set; }
}
```

## Contribute

Issues and pull requests are welcome to help this repository be the best it can be.

## License

This repository falls under the [MPL-2 license](https://www.mozilla.org/en-US/MPL/2.0/).
