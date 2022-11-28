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

| Library              | Depends on... | Used in... |
|----------------------|---------------|------------|
| [Emik.Optionals]()   | ❌             | ️❌         |
| [Emik.Unity]()       | ❌             | ️❌         |
| [wawa.DDL]()         | ❌             | ❌️         |
| [wawa.Editors]()     | ❌             | ❌          |
| [wawa.IO]()          | ❌             | ❌️         |
| [wawa.Modules]()     | ❌             | ❌️         |
| [wawa.TwitchPlays]() | ❌             | ❌️         |

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
