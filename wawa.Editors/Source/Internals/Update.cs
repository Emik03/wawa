#region Emik.MPL

// <copyright file="Update.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Wawa.Editors.Internals;

/// <summary>Updates libraries.</summary>
static class Update
{
    [NotNull]
    const string
        Dll = "dll",
        ExternalAnnotations = "ExternalAnnotations.xml",
        FetchLink = $"https://api.{GitHubAPI}releases/latest",
        GitHub = $"github.com/{GitHubUser}/{GitHubRepo}/",
        GitHubAPI = $"github.com/repos/{GitHubUser}/{GitHubRepo}/",
        GitHubRepo = "wawa",
        GitHubUser = "Emik03",
        Pdb = "pdb",
        Prep = "Now preparing to fetch and download the following libraries: ",
        RelativeEditor = $"Editor/{RelativeFolder}",
        RelativeFolder = "Plugins/Managed/",
        Separator = ", ",
        TagName = "tag_name",
        Xml = "xml";

    [NotNull]
    static string s_tag = "";

    [NotNull]
    static string Folder { get; } = Path.Combine(Application.dataPath, RelativeFolder);

    [NotNull]
    static string EditorFolder { get; } = Path.Combine(Application.dataPath, RelativeEditor);

    /// <summary>Fetches and downloads a set of libraries concurrently.</summary>
    /// <param name="fetches">The libraries to fetch.</param>
    internal static void Fetch([InstantHandle, NotNull] params string[] fetches)
    {
        var displayed = string.Join(Separator, fetches);

        AssemblyLog($"{Prep}{displayed}");

        var mono = Object.FindObjectOfType<MonoBehaviour>() ??
            new GameObject(nameof(DeleteMe), typeof(DeleteMe)).GetComponent<DeleteMe>();

        var requests = Latest(mono, fetches);

        mono.StartCoroutine(requests);
    }

    [NotNull, Pure]
    static IEnumerator Download([NotNull] string tag, [NotNull] string lib, [NotNull] string ext)
    {
        var url = $"https://{GitHub}/releases/download/{tag}/{lib}.{ext}";
        using var web = UnityWebRequest.Get(url);

        AssemblyLog($"Downloading {url}...");

        yield return web.SendWebRequest();

        if (web.IsErr(out var data))
            yield break;

        AssemblyLog($"Received {data.Length} bytes.");

        var path = Path.Combine(lib is WawaEditor.This ? EditorFolder : Folder, $"{lib}.{ext}");

        AssemblyLog($"Overwriting {path}...");

        File.WriteAllBytes(path, data);
    }

    [NotNull, Pure]
    static IEnumerator Downloads([NotNull] string lib)
    {
        yield return Download(s_tag, lib, Dll);
        yield return Download(s_tag, lib, ExternalAnnotations);
        yield return Download(s_tag, lib, Pdb);
        yield return Download(s_tag, lib, Xml);

        AssemblyLog($"Finished downloading {lib}!");
    }

    [NotNull, Pure]
    static IEnumerator Latest([NotNull] MonoBehaviour mono, [InstantHandle, NotNull] IEnumerable<string> fetches)
    {
        using var web = UnityWebRequest.Get(FetchLink);

        AssemblyLog($"Fetching {FetchLink}...");

        yield return web.SendWebRequest();

        if (web.IsErr(out var data))
            yield break;

        AssemblyLog($"Received {data.Length} bytes.");

        var json = Encoding.UTF8.GetString(data);

        AssemblyLog($"Decoded bytes to {json.Length} chars.");

        s_tag = JObject.Parse(json).GetValue(TagName, Ordinal).ToObject<string>();

        AssemblyLog($"Latest version is {s_tag}.");

        var downloads = fetches.Select(Downloads);

        foreach (var requests in downloads)
            mono.StartCoroutine(requests);
    }
}
