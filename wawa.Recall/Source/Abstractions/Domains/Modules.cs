// SPDX-License-Identifier: MPL-2.0
namespace wawa.Recall;

/// <summary>
/// The different types of modules in the game used to discern the type of vanilla module.
/// Modded modules are grouped as <see cref="Mod"/> and <see cref="NeedyMod"/> depending on
/// whether they have a <see cref="KMBombModule"/> and <see cref="KMNeedyModule"/> respectively.
/// </summary>
/// <remarks><para>
/// This enum is a one-to-one copy of <c>Assets.Scripts.Missions.ComponentTypeEnum</c>,
/// and as such, casting from or to these two types is defined behaviour.
/// </para></remarks>
[PublicAPI]
public enum Modules
{
    /// <summary>No module. Uses the bomb backing component.</summary>
    [PublicAPI]
    Empty,

    /// <summary>The vanilla timer component which ticks down the bomb's time.</summary>
    [PublicAPI]
    Timer,

    /// <summary>On the Subject of Wires.</summary>
    /// <remarks><para>Manual: https://ktane.timwi.de/HTML/Wires.html.</para></remarks>
    [PublicAPI]
    Wires,

    /// <summary>On the Subject of The Button.</summary>
    /// <remarks><para>Manual: https://ktane.timwi.de/HTML/The%20Button.html.</para></remarks>
    [PublicAPI]
    BigButton,

    /// <summary>On the Subject of Keypads.</summary>
    /// <remarks><para>Manual: https://ktane.timwi.de/HTML/Keypad.html.</para></remarks>
    [PublicAPI]
    Keypad,

    /// <summary>On the Subject of Simon Says.</summary>
    /// <remarks><para>Manual: https://ktane.timwi.de/HTML/Simon%20Says.html.</para></remarks>
    [PublicAPI]
    Simon,

    /// <summary>On the Subject of Who's on First.</summary>
    /// <remarks><para>Manual: https://ktane.timwi.de/HTML/Who's%20On%20First.html.</para></remarks>
    [PublicAPI]
    WhosOnFirst,

    /// <summary>On the Subject of Memory.</summary>
    /// <remarks><para>Manual: https://ktane.timwi.de/HTML/Memory.html.</para></remarks>
    [PublicAPI]
    Memory,

    /// <summary>On the Subject of Morse Code.</summary>
    /// <remarks><para>Manual: https://ktane.timwi.de/HTML/Morse%20Code.html.</para></remarks>
    [PublicAPI]
    Morse,

    /// <summary>On the Subject of Complicated Wires.</summary>
    /// <remarks><para>Manual: https://ktane.timwi.de/HTML/Complicated%20Wires.html.</para></remarks>
    [PublicAPI]
    Venn,

    /// <summary>On the Subject of Wire Sequences.</summary>
    /// <remarks><para>Manual: https://ktane.timwi.de/HTML/Wire%20Sequences.html.</para></remarks>
    [PublicAPI]
    WireSequence,

    /// <summary>On the Subject of Mazes.</summary>
    /// <remarks><para>Manual: https://ktane.timwi.de/HTML/Maze.html.</para></remarks>
    [PublicAPI]
    Maze,

    /// <summary>On the Subject of Passwords.</summary>
    /// <remarks><para>Manual: https://ktane.timwi.de/HTML/Password.html.</para></remarks>
    [PublicAPI]
    Password,

    /// <summary>On the Subject of Venting Gas.</summary>
    /// <remarks><para>Manual: https://ktane.timwi.de/HTML/Venting%20Gas.html.</para></remarks>
    [PublicAPI]
    NeedyVentGas,

    /// <summary>On the Subject of Capacitor Discharge.</summary>
    /// <remarks><para>Manual: https://ktane.timwi.de/HTML/Capacitor%20Discharge.html.</para></remarks>
    [PublicAPI]
    NeedyCapacitor,

    /// <summary>On the Subject of Knobs.</summary>
    /// <remarks><para>Manual: https://ktane.timwi.de/HTML/Knob.html.</para></remarks>
    [PublicAPI]
    NeedyKnob,

    /// <summary>Any solvable modded module which uses a <see cref="KMBombModule"/>.</summary>
    [PublicAPI]
    Mod,

    /// <summary>Any needy modded module which uses a <see cref="KMNeedyModule"/>.</summary>
    [PublicAPI]
    NeedyMod,
}
