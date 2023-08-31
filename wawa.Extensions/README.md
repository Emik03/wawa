# wawa.Extensions

Implements convenience extension methods for `KMFramework` types, as well as fixes for broken/buggy ones.

### [Documentation](https://github.com/Emik03/wawa/blob/main/wawa.Extensions/Documentation/Wawa.Extensions.md)

---

- [Dependencies](#dependencies)
- [Example](#example)
- [Contribute](#contribute)
- [License](#license)

---

## Dependencies

Completely stand-alone library, and not used as a dependency in another library.

<table>
    <thead>
        <tr>
            <th>Library</th>
            <th>Depends on...</th>
            <th>Used in...</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.DDL">wawa.DDL</a></td>
            <td align="center" colspan="2" rowspan="8" style="text-align: center;">None</td>
        </tr>
        <tr>
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.Editors">wawa.Editors</a></td>
        </tr>
        <tr>
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.IO">wawa.IO</a></td>
        </tr>
        <tr>
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.Modules">wawa.Modules</a></td>
        </tr>
        <tr>
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.Optionals">wawa.Optionals</a></td>
        </tr>
        <tr>
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.Recall">wawa.Recall</a></td>
        </tr>
        <tr>
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.TwitchPlays">wawa.TwitchPlays</a></td>
        </tr>
        <tr>
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.Unity">wawa.Unity</a></td>
        </tr>
    </tbody>
</table>

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
