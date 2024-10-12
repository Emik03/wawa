# wawa.IO

Adds types for KTaNE-related IO operations.

### [Documentation](https://github.com/Emik03/wawa/blob/main/apidocs/wawa.IO/wawa.IO.md)

---

- [Dependencies](#dependencies)
- [Example](#example)
- [Contribute](#contribute)
- [License](#license)

---

## Dependencies

| Library                                                                       | Depends on... | Used in... |
|-------------------------------------------------------------------------------|---------------|------------|
| [wawa.DDL](https://github.com/Emik03/wawa/tree/main/wawa.DDL)                 | Yes           |            |
| [wawa.Editors](https://github.com/Emik03/wawa/tree/main/wawa.Editors)         |               |            |
| [wawa.Extensions](https://github.com/Emik03/wawa/tree/main/wawa.Extensions)   |               |            |
| [wawa.Modules](https://github.com/Emik03/wawa/tree/main/wawa.Modules)         |               | Yes        |
| [wawa.Optionals](https://github.com/Emik03/wawa/tree/main/wawa.Optionals)     | Yes           | ️          |
| [wawa.Recall](https://github.com/Emik03/wawa/tree/main/wawa.Recall)           |               |            |
| [wawa.Schemas](https://github.com/Emik03/wawa/tree/main/wawa.Schemas)         |               |            |
| [wawa.TwitchPlays](https://github.com/Emik03/wawa/tree/main/wawa.TwitchPlays) |               | Yes        |
| [wawa.Unity](https://github.com/Emik03/wawa/tree/main/wawa.Unity)             |               |            |

## Example

```csharp
using System;
using UnityEngine;
using wawa.IO;

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
