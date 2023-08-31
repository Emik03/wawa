# wawa.TwitchPlays

Adds an extensive system for creating Twitch Plays components that are attached to modded modules.

### [Documentation](https://github.com/Emik03/wawa/blob/main/wawa.TwitchPlays/Documentation/index.md)

---

- [Dependencies](#dependencies)
- [Example](#example)
- [Contribute](#contribute)
- [License](#license)

---

## Dependencies

| Library                                                                     | Depends on... | Used in... |
|-----------------------------------------------------------------------------|---------------|------------|
| [wawa.DDL](https://github.com/Emik03/wawa/tree/main/wawa.DDL)               | Yes           |            |
| [wawa.Editors](https://github.com/Emik03/wawa/tree/main/wawa.Editors)       |               |            |
| [wawa.Extensions](https://github.com/Emik03/wawa/tree/main/wawa.Extensions) |               |            |
| [wawa.IO](https://github.com/Emik03/wawa/tree/main/wawa.IO)                 | Yes           |            |
| [wawa.Modules](https://github.com/Emik03/wawa/tree/main/wawa.Modules)       | Yes           |            |
| [wawa.Optionals](https://github.com/Emik03/wawa/tree/main/wawa.Optionals)   | Yes           | ️          |
| [wawa.Recall](https://github.com/Emik03/wawa/tree/main/wawa.Recall)         |               |            |
| [wawa.Unity](https://github.com/Emik03/wawa/tree/main/wawa.Unity)           | Yes           | ️          |

## Example

```csharp
using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using Wawa.TwitchPlays;
using Wawa.TwitchPlays.Domains;

/// <summary>Implements Twitch Plays support for <see cref="Foo"/>.</summary>
public sealed class FooTwitch : Twitch<Foo>
{
    enum Button
    {
        [Alias("top-left"), UsedImplicitly]
        TL,
        [Alias("top-right"), UsedImplicitly]
        TR,
        [Alias("bottom-left"), UsedImplicitly]
        BL,
        [Alias("bottom-right"), UsedImplicitly]
        BR,
    }

    /// <inheritdoc />
    public override IEnumerable<Instruction> ForceSolve()
    {
        yield return TwitchString.Solve;
    }

    /// <summary>Holds a button for a specified duration.</summary>
    /// <example><para>Examples of commands that invoke this method:<list type="bullet">
    /// <item><description>hold 1</description></item>
    /// <item><description>HOLD 2.45</description></item>
    /// <item><description>hOlD&#160;&#160;&#160;&#160;6.1 tR</description></item>
    /// </list></para></example>
    /// <param name="duration">How long to hold the buttons for.</param>
    /// <param name="button">Which button to hold, by default the top-left.</param>
    /// <returns>For demonstration purposes, this always throws.</returns>
    [Command]
    IEnumerable<Instruction> Hold(float duration, Button button = Button.TL)
    {
        yield return new WaitForSeconds(duration);
    }

    /// <summary>Presses a sequence of buttons.</summary>
    /// <example><para>Examples of commands that invoke this method:<list type="bullet">
    /// <item><description>submit</description></item>
    /// <item><description>SUBMIT TL</description></item>
    /// <item><description>sUbMiT tR bL bL bR</description></item>
    /// </list></para></example>
    /// <param name="buttons">The buttons to press, in order.</param>
    /// <returns>For demonstration purposes, this always throws.</returns>
    [Command("submit", 1)] // With priority '1', this method gets evaluated sooner than the method 'Hold'.
    static IEnumerable<Instruction> Press([NotNull] params Button[] buttons)
    {
        yield return Array.ConvertAll(buttons, x => Module.Get<KMSelectable[]>()[(int)x]);
    }
}
```

## Contribute

Issues and pull requests are welcome to help this repository be the best it can be.

## License

This repository falls under the [MPL-2 license](https://www.mozilla.org/en-US/MPL/2.0/).
