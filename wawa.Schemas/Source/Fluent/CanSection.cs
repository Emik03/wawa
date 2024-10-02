// SPDX-License-Identifier: MPL-2.0
namespace wawa.Schemas.Fluent;

/// <summary>Contains the method for registering a section.</summary>
[PublicAPI]
public abstract class CanSection : CanRegister
{
    /// <summary>Creates a new section in the <see cref="TweaksEditorSettings"/>.</summary>
    /// <param name="text">The text of the new section.</param>
    /// <returns>The <see cref="TweaksEditorSettings"/> itself.</returns>
    [MustUseReturnValue, NotNull, PublicAPI]
    public abstract CanRegister Section([NotNull] string text);
}
