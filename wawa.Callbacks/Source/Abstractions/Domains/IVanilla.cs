// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Callbacks;

/// <summary>An interface for all encapsulations of vanilla objects.</summary>
[CLSCompliant(false), PublicAPI]
public interface IVanilla
{
    /// <summary>Gets a value indicating whether this instance contains a vanilla instance.</summary>
    [PublicAPI]
    public bool IsVanilla { [Pure] get; }

    /// <summary>Gets a value indicating whether this instance contains a modded instance.</summary>
    [PublicAPI]
    public bool IsModded { [Pure] get; }

    /// <summary>Gets the encapsulated vanilla component, if it exists.</summary>
    [PublicAPI]
    public Maybe<MonoBehaviour> Vanilla { [Pure] get; }
}
