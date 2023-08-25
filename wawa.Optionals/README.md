# wawa.Optionals

Defines the `Maybe<T>` type, which is used throughout these libraries to represent a value that may be optional.

All returned values from these libraries can be assumed to be always non-null, as a fallback value, or this type is used to explicitly mark optional values.

---

- [Dependencies](#dependencies)
- [Example](#example)
- [Contribute](#contribute)
- [License](#license)

---

## Dependencies

| Library                                                                       | Depends on... | Used in... |
|-------------------------------------------------------------------------------|---------------|------------|
| [wawa.DDL](https://github.com/Emik03/wawa/tree/main/wawa.DDL)                 | ❌             | ✔️         |
| [wawa.Editors](https://github.com/Emik03/wawa/tree/main/wawa.Editors)         | ❌             | ❌          |
| [wawa.Extensions](https://github.com/Emik03/wawa/tree/main/wawa.Extensions)   | ❌             | ❌          |
| [wawa.IO](https://github.com/Emik03/wawa/tree/main/wawa.IO)                   | ❌             | ✔️         |
| [wawa.Modules](https://github.com/Emik03/wawa/tree/main/wawa.Modules)         | ❌             | ✔️         |
| [wawa.TwitchPlays](https://github.com/Emik03/wawa/tree/main/wawa.TwitchPlays) | ❌             | ✔️         |
| [wawa.Unity](https://github.com/Emik03/wawa/tree/main/wawa.Unity)             | ❌             | ️❌         |

## Example

```csharp
using Wawa.Optionals;
using static System.Diagnostics.Debug;

Maybe<int> some = 2;
Maybe<int> none = default;

Assert(some.IsSome);
Assert(some.TryGet(out var _));
Assert(some.Match(x => x is 2, _ => false));
Assert(some.Unwrap() is 2);

Assert(none.IsNone);
Assert(!none.TryGet(out var _));
Assert(none.Match(_ => throw new(), _ => true));
Assert(none.UnwrapOrDefault() is 0);
```

## Contribute

Issues and pull requests are welcome to help this repository be the best it can be.

## License

This repository falls under the [MPL-2 license](https://www.mozilla.org/en-US/MPL/2.0/).
