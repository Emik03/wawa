// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Editors.Internals;

/// <summary>Contains a method invoked by Unity to add a potentially missing tag.</summary>
[UsedImplicitly]
static class ModBundle
{
    /// <summary>The tag that indicates that the asset be included in exporting.</summary>
    internal const string Tag = "mod.bundle";

    const string
        TagManager = "ProjectSettings/TagManager.asset",
        Tags = "tags";

    [DidReloadScripts, UsedImplicitly]
#pragma warning disable IDE0051
    static void Create()
#pragma warning restore IDE0051
    {
        if (AssetDatabase.LoadAllAssetsAtPath(TagManager) is not { Length: > 0 } asset)
            return;

        using SerializedObject so = new(asset[0]);
        var tags = so.FindProperty(Tags);

        for (var i = 0; i < tags.arraySize; i++)
            if (tags.GetArrayElementAtIndex(i).stringValue is Tag)
                return;

        tags.InsertArrayElementAtIndex(0);
        tags.GetArrayElementAtIndex(0).stringValue = Tag;
        so.ApplyModifiedProperties();
        so.Update();
    }
}
