# wawa.Editors

Editor-only dependency that extends the editor to integrate an installer and scaffolder into the editor.

When installed, `wawa` is shown at the top with the following options...

- `Scaffold`: Creates a template prefab and script. Uses a `wawa.Modules` and/or `wawa.TwitchPlays` template if the
  library exists, otherwise a generic template.
- `Updater`: Downloads the latest of that library, as well as all dependencies.

---

- [Dependencies](#dependencies)
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
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.Extensions">wawa.Extensions</a></td>
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

## Contribute

Issues and pull requests are welcome to help this repository be the best it can be.

## License

This repository falls under the [MPL-2 license](https://www.mozilla.org/en-US/MPL/2.0/).
