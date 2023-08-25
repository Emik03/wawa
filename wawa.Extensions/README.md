# wawa.Extensions

Implements convenience extension methods for `KMFramework` types, as well as fixes for broken/buggy ones.

---

- [Dependencies](#dependencies)
- [Example](#example)
- [Contribute](#contribute)
- [License](#license)

---

## Dependencies

Completely stand-alone library, and not used as a dependency in another library.

| Library                                                                       | Depends on... | Used in... |
|-------------------------------------------------------------------------------|---------------|------------|
| [wawa.DDL](https://github.com/Emik03/wawa/tree/main/wawa.DDL)                 | ❌             | ❌️         |
| [wawa.Editors](https://github.com/Emik03/wawa/tree/main/wawa.Editors)         | ❌             | ❌          |
| [wawa.IO](https://github.com/Emik03/wawa/tree/main/wawa.IO)                   | ❌             | ❌️         |
| [wawa.Modules](https://github.com/Emik03/wawa/tree/main/wawa.Modules)         | ❌             | ❌️         |
| [wawa.Optionals](https://github.com/Emik03/wawa/tree/main/wawa.Optionals)     | ❌             | ️❌         |
| [wawa.TwitchPlays](https://github.com/Emik03/wawa/tree/main/wawa.TwitchPlays) | ❌             | ❌️         |
| [wawa.Unity](https://github.com/Emik03/wawa/tree/main/wawa.Unity)             | ❌             | ️❌         |

## Example

```csharp
using Wawa.Extensions;

GetComponents<KMSelectable>().Add(onInteract: Fun);

// Invokes UpdateChildren correctly.
GetComponent<KMSelectable>().Notify();

void Fun(int i) => Debug.Log(i);
```

## Contribute

Issues and pull requests are welcome to help this repository be the best it can be.

## License

This repository falls under the [MPL-2 license](https://www.mozilla.org/en-US/MPL/2.0/).
