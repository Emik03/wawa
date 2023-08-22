// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Editors.Internals;

/// <summary>A temporary <see cref="MonoBehaviour"/> that does nothing other than throw an error in play mode.</summary>
#pragma warning disable CA1812
sealed class DeleteMe : MonoBehaviour
#pragma warning restore CA1812
{
    const string Message = "The library couldn't delete this game object, please remove this game object manually.";

#pragma warning disable CA1822
    void Awake() => throw new InvalidOperationException(Message);
#pragma warning restore CA1822

    /// <inheritdoc />
    [PublicAPI, Pure]
    public override string ToString() => nameof(DeleteMe);
}
