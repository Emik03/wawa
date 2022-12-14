#region Emik.MPL

// <copyright file="DeleteMe.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

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
