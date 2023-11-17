// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Editors.Internals;

/// <summary>Source generator.</summary>
static class Scaffold
{
    [NotNull]
    const string
        Cancelled = "Operation cancelled.",
        CSharp = ".cs",
        CSharpStringSyntax = "csharp", // EditorAssembly = "Assembly-CSharp",
        FileTwitch = "Twitch",
        Highlight = "Component_Highlight",
        KMAssets = "https://github.com/Qkrisi/ktanemodkit/tree/master/Assets/KMAssets",
        NeedyBackground = "Component_Needy_Background",
        Material = ".mat",
        Mesh = ".fbx",
        ModdedModule = nameof(ModdedModule),
        Modules = "wawa.Modules",
        NeedyController = "NeedyBackingAnimController.controller",
        NeedyVar = "_needy",
        Prefab = "prefab",
        Reload =
            "Scaffolding complete. Once the editor reloads, you will have to attach the newly generated script files " +
            "in the root folder of Assets to the newly generated component manually.",
        Scripts = nameof(Scripts),
        SolvableBackground = "Component_PuzzleBackground",
        SolvableVar = "_solvable",
        Title = "Please enter the name of your new module.",
        TwitchPlays = "wawa.TwitchPlays";

    [NotNull, StringSyntax(CSharpStringSyntax)]
    const string
        CollectionsNamespace = @"
using System.Collections;
using System.Collections.Generic;",
        Greeting = "Log(\"Hello, World! ma o, toki!\");",
        ModulesNamespace = @"
using Wawa.Modules;",
        NeedyDeclaration = $"{nameof(KMNeedyModule)} {NeedyVar}",
        NotImplemented = $"throw new {nameof(NotImplementedException)}();",
        SolvableDeclaration = $"{nameof(KMBombModule)} {SolvableVar}",
        TwitchPrefix = @$"
    // Uncomment or remove as needed. Documentation for what each field does is as follows:
    // https://github.com/samfundev/KtaneTwitchPlays/wiki/External-Mod-Module-Support#additional-implementation-tasks

    [{nameof(SerializeField)}]
    bool
        TimeModeActive,
        TwitchShouldCancelCommand,
        TwitchPlaysActive,
        TwitchPlaysSkipTimeAllowed = true,
        ZenModeActive;

    [{nameof(SerializeField)}]
    string TwitchHelpMessage, TwitchManualCode;

    [{nameof(SerializeField)}]
    {nameof(List<KMBombModule>)}<{nameof(KMBombModule)}> TwitchAbandonModule;
    ",
        TwitchSuffix = @$"

    {nameof(IEnumerator)} ProcessTwitchCommand(string command)
    {{
        {NotImplemented}
    }}

    {nameof(IEnumerator)} TwitchHandleForcedSolve()
    {{
        {NotImplemented}
    }}",
        WawaTemplate = @$"
    protected override void OnActivate()
    {{
        {Greeting}
    }}";

    [NotNull]
    static readonly Assembly[] s_assemblies = AppDomain.CurrentDomain.GetAssemblies();

    static readonly Vector3 s_statusLight = new(0.075167f, 0.02f, 0.076057f);

    static readonly Quaternion s_puzzleBackground = new(0, 180, 0, 0);

    [NotNull, StringSyntax(CSharpStringSyntax)]
    static string Header =>
        @$"// SPDX-License-Identifier: MIT OR Unlicense
// Autogenerated using the {nameof(Scaffold)} feature in {Who}.
// Code generated by {Who} is in public domain.
// Source: https://github.com/Emik03/wawa
";

    /// <summary>Creates a solvable module.</summary>
    internal static void Solvable()
    {
        if (true.Prompt(out var path))
        {
            Debug.Log(Cancelled);
            return;
        }

        var name = Path.GetFileNameWithoutExtension(path);
        var dir = Path.GetDirectoryName(path) ?? "";
        var go = new GameObject(name, typeof(KMAudio), typeof(KMBombInfo));

        name.AddSources(dir, true);

        var solvable = go.AddComponent<KMBombModule>();
        var selectable = go.AddComponent<KMSelectable>();

        solvable.ModuleType = solvable.ModuleDisplayName = go.name;
        selectable.Children = new KMSelectable[1];
        selectable.Highlight = go.AddHighlightable();

        go.AddStatusLight();
        go.AddPuzzleBackground(SolvableBackground);
        go.Save(path);
    }

    /// <summary>Creates a needy module.</summary>
    internal static void Needy()
    {
        if (false.Prompt(out var path))
        {
            Debug.Log(Cancelled);
            return;
        }

        var name = Path.GetFileNameWithoutExtension(path);
        var dir = Path.GetDirectoryName(path) ?? "";
        var go = new GameObject(name, typeof(KMAudio), typeof(KMBombInfo));

        name.AddSources(dir, false);

        var animator = go.AddComponent<Animator>();
        var needy = go.AddComponent<KMNeedyModule>();
        var selectable = go.AddComponent<KMSelectable>();

        animator.runtimeAnimatorController = Load<AnimatorController>(NeedyController);
        needy.ModuleType = needy.ModuleDisplayName = go.name;
        selectable.Highlight = go.AddHighlightable();

        go.AddStatusLight();
        go.AddPuzzleBackground(NeedyBackground);
        go.Save(path);
    }

    static void AddPuzzleBackground([NotNull] this GameObject go, [NotNull] string name)
    {
        var bg = go.Add(name);
        var renderer = bg.AddComponent<MeshRenderer>();

        bg.AddComponent<MeshFilter>().mesh = Load<Mesh>($"{name}{Mesh}");

        bg.transform.localRotation = s_puzzleBackground;
        renderer.allowOcclusionWhenDynamic = true;
        renderer.material = Load<Material>($"{name}{Material}");
    }

    static void AddSources(
        [NotNull] this string name,
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] string root,
        bool isSolvable
    )
    {
        var hasWawaModules = Array.Exists(s_assemblies, x => x.GetName().Name is Modules);
        var hasWawaTwitchPlays = Array.Exists(s_assemblies, x => x.GetName().Name is TwitchPlays);

        var query = name
           .Where(x => x is >= 'A' and <= 'Z' or >= 'a' and <= 'z' or '_')
           .Select(x => x.ToString())
           .ToArray();

        string
            compliant = string.Join("", query),
            dir = Path.Combine(root, Scripts),
            file = Path.ChangeExtension(compliant, CSharp),
            save = Path.Combine(dir, file),
            contents = compliant.Source(hasWawaModules, isSolvable),
            twitch = Path.Combine(dir, $"{compliant}{FileTwitch}{CSharp}");

        Directory.CreateDirectory(dir);

        if (hasWawaTwitchPlays)
            compliant.AddTwitch(twitch);

        File.WriteAllText(save, contents);

        // CallbackFunction reload = () =>
        //     _ = s_assemblies
        //        .FirstOrDefault(x => x.GetName().Name is EditorAssembly)
        //       ?.GetTypes()
        //        .Where(x => string.Equals(x.Name, name, Ordinal) || string.Equals(x.Name, twitchName, Ordinal))
        //        .Select(go.AddComponent)
        //        .LastOrDefault();

        // reload += update -= reload;
        // update += reload;
    }

    static void AddTwitch(
        [NotNull] this string compliant,
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] string location
    )
    {
        var twitchContents = compliant.SourceTwitch();
        File.WriteAllText(location, twitchContents);
    }

    static void AddStatusLight([NotNull] this GameObject go) =>
        go.Add(nameof(StatusLight), typeof(KMStatusLightParent)).transform.localPosition = s_statusLight;

    static void Save(
        [NotNull] this GameObject go,
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] string path
    )
    {
        go.tag = ModBundle.Tag;

        var uri = new Uri(Application.dataPath).MakeRelativeUri(new(path));
        var relative = Uri.UnescapeDataString(uri.ToString());
        var newGo = PrefabUtility.CreatePrefab(relative, go);

        Object.DestroyImmediate(go);
        PrefabUtility.InstantiatePrefab(newGo);
        Debug.Log(Reload);
        AssetDatabase.Refresh();
    }

    static bool Prompt(
        this bool isSolvable,
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] out string path
    ) =>
        string.IsNullOrEmpty(path = isSolvable.SaveFilePanel() ?? "");

    [CanBeNull]
    [return: AllowNull]
    static string SaveFilePanel([InstantHandle] this bool isSolvable) =>
        EditorUtility.SaveFilePanel(
            Title,
            Application.dataPath,
            isSolvable ? nameof(Solvable) : nameof(Needy),
            Prefab
        );

    [NotNull]
    static string WawalessTemplate([InstantHandle] this bool b) =>
        Id(
            @$"{TwitchPrefix}
    [{nameof(SerializeField)}]
    {(b ? SolvableDeclaration : NeedyDeclaration)};

    static int s_lastModuleId;

    int _moduleId;

    void Log(string message, params object[] args)
    {{
        var log = string.Format(message, args);
        Debug.LogFormat(""[{{0}} #{{1}}] {{2}}"", {(b ? SolvableVar : NeedyVar)}.ModuleDisplayName, _moduleId, log);
    }}

    void Start()
    {{
        _moduleId = ++s_lastModuleId;
        {Greeting}
        {(b ? SolvableVar : NeedyVar)}.{nameof(KMBombModule.OnActivate)} += {nameof(KMBombModule.OnActivate)};
    }}

    void {nameof(KMBombModule.OnActivate)}()
    {{
        {NotImplemented}
    }}
    {TwitchSuffix}"
        );

    [NotNull]
    static string Source([NotNull] this string name, [InstantHandle] bool hasWawaModules, bool isSolvable) =>
        Id(
            @$"{Header}
using System;
using UnityEngine;{(hasWawaModules ? ModulesNamespace : CollectionsNamespace)}
using Random = UnityEngine.Random;

/// <summary>On the Subject of <see cref=""{name}""/>.</summary>
public sealed class {name} : {(hasWawaModules ? ModdedModule : nameof(MonoBehaviour))}
{{{(hasWawaModules ? WawaTemplate : isSolvable.WawalessTemplate())}
}}
"
        );

    [NotNull]
#pragma warning disable MA0051
    static string SourceTwitch([NotNull] this string name) =>
#pragma warning restore MA0051
        Id(
            @$"{Header}
using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using Wawa.TwitchPlays;
using Wawa.TwitchPlays.Domains;
using Random = UnityEngine.Random;

/// <summary>Implements Twitch Plays support for <see cref=""{name}""/>.</summary>
public sealed class {name}{FileTwitch} : Twitch<{name}>
{{
    enum Button
    {{
        [Alias(""top-left""), UsedImplicitly]
        TL,
        [Alias(""top-right""), UsedImplicitly]
        TR,
        [Alias(""bottom-left""), UsedImplicitly]
        BL,
        [Alias(""bottom-right""), UsedImplicitly]
        BR,
    }}

    /// <inheritdoc />
    public override {nameof(IEnumerable)}<Instruction> ForceSolve()
    {{
        {NotImplemented}
    }}

    /// <summary>Holds a button for a specified duration.</summary>
    /// <example><para>Examples of commands that invoke this method:<list type=""bullet"">
    /// <item><description>hold 1</description></item>
    /// <item><description>HOLD 2.45</description></item>
    /// <item><description>hOlD&#160;&#160;&#160;&#160;6.1 tR</description></item>
    /// </list></para></example>
    /// <param name=""duration"">How long to hold the buttons for.</param>
    /// <param name=""button"">Which button to hold, by default the top-left.</param>
    /// <returns>For demonstration purposes, this always throws.</returns>
    [Command]
    {nameof(IEnumerable)}<Instruction> Hold(float duration, Button button = Button.TL)
    {{
        {NotImplemented}
    }}

    /// <summary>Presses a sequence of buttons.</summary>
    /// <example><para>Examples of commands that invoke this method:<list type=""bullet"">
    /// <item><description>submit</description></item>
    /// <item><description>SUBMIT TL</description></item>
    /// <item><description>sUbMiT tR bL bL bR</description></item>
    /// </list></para></example>
    /// <param name=""buttons"">The buttons to press, in order.</param>
    /// <returns>For demonstration purposes, this always throws.</returns>
    [Command(""submit"", 1)] // With priority '1', this method gets evaluated sooner than the method 'Hold'.
    static {nameof(IEnumerable)}<Instruction> Press([NotNull] params Button[] buttons)
    {{
        {NotImplemented}
    }}
}}
"
        );

    [NotNull]
    static string Id([NotNull, StringSyntax(CSharpStringSyntax)] string x) => x;

    [NotNull]
    static GameObject Add([NotNull] this GameObject go, [NotNull] string name, [NotNull] params Type[] components) =>
        new(name, components)
        {
            transform =
            {
                parent = go.transform,
            },
        };

    [NotNull]
    static KMHighlightable AddHighlightable([NotNull] this GameObject go)
    {
        var highlighter = go.Add(Highlight);
        highlighter.AddComponent<MeshFilter>().mesh = Load<Mesh>($"{Highlight}{Mesh}");
        var output = highlighter.AddComponent<KMHighlightable>();
        output.HighlightScale = Vector3.one;
        return output;
    }

    [CanBeNull]
    [return: AllowNull]
    static T Load<T>([NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] string pattern)
        where T : Object
    {
        if (Array.Find(AssetDatabase.GetAllAssetPaths(), x => x.EndsWith(pattern, Ordinal)) is { } path)
            return AssetDatabase.LoadAssetAtPath<T>(path);

        AssemblyError($"Missing asset \"{pattern}\" for the {typeof(T).Name}. Please import KMAssets: {KMAssets}");
        return null;
    }
}
