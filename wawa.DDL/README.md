# wawa.DDL

Implements the [DDL pattern](https://github.com/Emik03/.DDL#chapter-23-the-ddl-pattern) to allow direct access to common
in-game values that are normally annoying to obtain.

### [Documentation](https://github.com/Emik03/wawa/blob/main/apidocs/wawa.DDL/wawa.DDL.md)

---

- [Dependencies](#dependencies)
- [Example](#example)
- [Non-KTaNE Interop](#non-ktane-interop)
- [Contribute](#contribute)
- [License](#license)

---

## Dependencies

| Library                                                                       | Depends on... | Used in... |
|-------------------------------------------------------------------------------|---------------|------------|
| [wawa.Editors](https://github.com/Emik03/wawa/tree/main/wawa.Editors)         |               |            |
| [wawa.Extensions](https://github.com/Emik03/wawa/tree/main/wawa.Extensions)   |               |            |
| [wawa.IO](https://github.com/Emik03/wawa/tree/main/wawa.IO)                   |               | Yes        |
| [wawa.Modules](https://github.com/Emik03/wawa/tree/main/wawa.Modules)         |               | Yes        |
| [wawa.Optionals](https://github.com/Emik03/wawa/tree/main/wawa.Optionals)     | Yes           | ️          |
| [wawa.Recall](https://github.com/Emik03/wawa/tree/main/wawa.Recall)           |               | Yes        |
| [wawa.Schemas](https://github.com/Emik03/wawa/tree/main/wawa.Schemas)         |               |            |
| [wawa.TwitchPlays](https://github.com/Emik03/wawa/tree/main/wawa.TwitchPlays) |               | Yes        |
| [wawa.Unity](https://github.com/Emik03/wawa/tree/main/wawa.Unity)             |               | ️          |

## Example

```csharp
using UnityEngine;
using wawa.DDL;
using static System.Diagnostics.Debug;

Assert(GetComponent<KMBomb>().SetStrikes(2).GetStrikes() is 2);

string id = Missions.Id.UnwrapOr("<no id>");

#if UNITY_EDITOR
// Above will always return None in editor,
// so the explicit fallback value is returned.
Assert(id is "<no id>");
#endif

// Bye audio! (Can still be changed by user in settings)
Preferences.Sound = Preferences.Music = 0;
```

## Non-KTaNE Interop

Since modules are just a combination of libraries and unity bundles, they could theoretically be loaded in a completely different unity project. To allow this while keeping access to game values, an escape hatch is added.

To override the game references, first declare a type named `Overrides` in the `wawa.DDL` namespace.

```csharp
namespace wawa.DDL;

static class Overrides
{
    // Functions go here!
}
```

Next, define the following functions in the declared type:

```csharp
// These functions are assumed to never throw.
public static bool HasPacingEvents(DBNull _); // Getter

public static bool HasPacingEvents(bool value); // Setter

public static bool LightsOn(bool v); // Setter

public static int GetStrikes(KMBomb that);

public static int GetMaxStrikes(KMBomb that);

// signFlip: When `true`, invert the returned value when
// the component from `that` ticks backwards.
public static float GetRate(KeyValuePair<KMBomb /* that */, bool /* signFlip */> args);

public static string? Localized(string term);

public static string? ModNameOf(Component component);

public static string? Description(DBNull _);

public static string? Id(DBNull _);

public static string? LanguageCode(DBNull _);

public static string? Name(DBNull _);

public static DBNull OnLightsChanged(Action<bool> onLightsChanged);

// Meant to be an abstraction over `loadedMods`: Path -> Mod object
public static IDictionary? Mods(DBNull _);

public static KMBomb Detonate(KMBomb that);

public static KMBomb SetRate(KeyValuePair<KMBomb /* that */, KeyValuePair<float /* value */, bool /* signFlip */>> args);

public static KMBomb SetStrikes(KeyValuePair<KMBomb /* that */, KeyValuePair<int /* value */, bool /* signFlip */>> args);

public static KMBomb SetMaxStrikes(KeyValuePair<KMBomb /* that */, KeyValuePair<int /* value */, bool /* signFlip */>> args);
```

These are the functions used by this particular library, however if you wish to support the other libraries, you will need to refer to their sections:
- [wawa.IO](https://github.com/Emik03/wawa/blob/main/wawa.IO/README.md#non-ktane-interop)
- [wawa.Recall](https://github.com/Emik03/wawa/blob/main/wawa.Recall/README.md#non-ktane-interop)

## Contribute

Issues and pull requests are welcome to help this repository be the best it can be.

## License

This repository falls under the [MPL-2 license](https://www.mozilla.org/en-US/MPL/2.0/).
