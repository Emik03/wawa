// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Editors.Internals;

/// <summary>A temporary <see cref="MonoBehaviour"/> that does nothing other than throw an error in play mode.</summary>
sealed class DeleteMe : MonoBehaviour
{
    const string Message = "The library couldn't delete this game object, please remove this game object manually.";

    void Awake() => throw new InvalidOperationException(Message);

    /// <inheritdoc />
    [PublicAPI, Pure]
    public override string ToString() => nameof(DeleteMe);
}
