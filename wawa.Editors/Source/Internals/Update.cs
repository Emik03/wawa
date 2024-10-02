// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Editors.Internals;

/// <summary>Updates libraries.</summary>
static class Update
{
    /// <summary>The constants.</summary>
    [NotNull]
    const string
        Dll = "dll",
        ExternalAnnotations = "ExternalAnnotations.xml",
        FetchLink = $"https://api.{GitHubUrl}releases/latest",
        GitHub = $"github.com/{GitHubUser}/{GitHubRepo}/",
        GitHubRepo = "wawa",
        GitHubUser = "Emik03",
        GitHubUrl = $"github.com/repos/{GitHubUser}/{GitHubRepo}/",
        Pdb = "pdb",
        Prep = "Now preparing to fetch and download the following libraries: ",
        RelativeEditor = $"Editor/{RelativeFolder}",
        RelativeFolder = "Plugins/Managed/",
        Separator = ", ",
        TagName = "tag_name",
        Xml = "xml";

    /// <summary>The latest version of the library.</summary>
    [NotNull]
    static string s_tag = "";

    /// <summary>The path to the directory containing plugins that are bundled with the mod on export.</summary>
    [NotNull]
    static string Folder { get; } = Path.Combine(Application.dataPath, RelativeFolder);

    /// <summary>The path to the directory containing plugins that are not bundled, but provide editor tools.</summary>
    [NotNull]
    static string EditorFolder { get; } = Path.Combine(Application.dataPath, RelativeEditor);

    /// <summary>Fetches and downloads a set of libraries.</summary>
    /// <param name="fetches">The libraries to fetch.</param>
    internal static void Fetch([InstantHandle, NotNull] params string[] fetches)
    {
        var displayed = string.Join(Separator, fetches);
        AssemblyLog($"{Prep}{displayed}");

        var mono = Object.FindObjectOfType<MonoBehaviour>() is var behave && behave ? behave :
            new GameObject(nameof(DeleteMe)) is var obj && obj.AddComponent<DeleteMe>() is var del && del ? del :
            obj.AddComponent<NetworkMatch>();

        var requests = Latest(mono, fetches);
        mono.StartCoroutine(requests);
    }

    /// <summary>Gets the coroutine for fetching and downloading a file.</summary>
    /// <param name="tag">The tag of the library.</param>
    /// <param name="lib">The name of the library.</param>
    /// <param name="ext">The extension of the library.</param>
    /// <returns>The coroutine for the download.</returns>
    [NotNull, Pure]
    static IEnumerator<UnityWebRequestAsyncOperation> Download(
        [NotNull] string tag,
        [NotNull] string lib,
        [NotNull] string ext
    )
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

        if (Path.GetDirectoryName(path) is { } dir)
            Directory.CreateDirectory(dir);

        File.WriteAllBytes(path, data);
    }

    /// <summary>Gets the coroutine for downloading all the files of the library specified.</summary>
    /// <param name="lib">The name of the library.</param>
    /// <returns>The coroutine for the download.</returns>
    [NotNull, Pure]
    static IEnumerator<IEnumerator<UnityWebRequestAsyncOperation>> Downloads([NotNull] string lib)
    {
        yield return Download(s_tag, lib, Dll);
        yield return Download(s_tag, lib, ExternalAnnotations);
        yield return Download(s_tag, lib, Pdb);
        yield return Download(s_tag, lib, Xml);

        AssemblyLog($"Finished downloading {lib}!");
    }

    /// <summary>Gets the coroutine to fetch and download the latest version of this library.</summary>
    /// <param name="mono">The instance to start coroutines on.</param>
    /// <param name="fetches">The libraries to fetch.</param>
    /// <returns>The coroutine for the download.</returns>
    [NotNull, Pure]
    static IEnumerator<UnityWebRequestAsyncOperation> Latest(
        [NotNull] MonoBehaviour mono,
        [InstantHandle, NotNull] IEnumerable<string> fetches
    )
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
