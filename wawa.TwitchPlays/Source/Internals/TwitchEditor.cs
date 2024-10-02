// SPDX-License-Identifier: MPL-2.0
namespace wawa.TwitchPlays.Internals;

/// <summary>Custom inspector for <see cref="Twitch{TMod}"/>.</summary>
// ReSharper disable Unity.PerformanceCriticalCodeInvocation
[CanEditMultipleObjects, CustomEditor(typeof(Twitch<>), true), UsedImplicitly]
#pragma warning disable CA1812
sealed class TwitchEditor : Editor
#pragma warning restore CA1812
{
    const string
        AllSolvers = "Run all solvers",
        CancelCommand = "Enable command cancelling",
        OutsidePlayMode = "The auto-solver cannot run outside of play mode.",
        PrintingYields = "Enable printing yields",
        SolvedTooEarly =
            "The module's solve coroutine finished before the module solved! This is a mistake because Twitch Plays " +
            $"will force-solve a module as soon as the {nameof(IEnumerator<object>)} finishes running. One way to " +
            $"fix this is by yield returning {nameof(Twitch<ModdedModule>.UntilSolve)} assuming the module is always " +
            "in a state to be definitively solved without additional interactions.",
        Solver = "Run solver",
        Time = "Enable time mode",
        TimeSkippable = "Enable time-skip permissions",
        TP = "Enable TP mode",
        Zen = "Enable zen mode";

    /// <inheritdoc />
    [PublicAPI]
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        if (target is not (CachedBehaviour cb and ITwitchMutable tp))
            return;

        tp.IsPrintingYields = Toggle(tp.IsPrintingYields, PrintingYields);

        tp.SetIsCancelCommand(Toggle(tp.IsCancelCommand, CancelCommand));
        tp.SetIsTime(Toggle(tp.IsTime, Time));
        tp.SetIsTimeSkippable(Toggle(tp.IsTimeSkippable, TimeSkippable));
        tp.SetIsTP(Toggle(tp.IsTP, TP));
        tp.SetIsZen(Toggle(tp.IsZen, Zen));

        if (Button(Solver))
            StartAssertion(cb, tp);

        if (!Button(AllSolvers))
            return;

        // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
        foreach (var behavior in FindObjectsOfType<MonoBehaviour>())
            if (behavior is ITwitchDeclarable tpBehavior)
                StartAssertion(behavior, tpBehavior);
    }

    /// <inheritdoc />
    [Pure]
    public override string ToString() => nameof(TwitchEditor);

    static void StartAssertion([NotNull] in MonoBehaviour obj, [NotNull] in ITwitchDeclarable tp) =>
        obj.StartCoroutine(Assert(tp));

    [NotNull, Pure]
    static IEnumerator<object> Assert([NotNull] ITwitchDeclarable tp)
    {
        var module = tp.Inner;

        if (!EditorApplication.isPlaying)
        {
            // ReSharper disable once FormatStringProblem
            module.Log(OutsidePlayMode, LogType.Error);

            yield break;
        }

        yield return tp.TwitchHandleForcedSolve();

        if (!module.Status.IsSolved) // ReSharper disable once FormatStringProblem
            module.Log(SolvedTooEarly, LogType.Error);
    }
}
