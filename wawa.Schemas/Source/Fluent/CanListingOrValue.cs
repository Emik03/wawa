// SPDX-License-Identifier: MPL-2.0
namespace wawa.Schemas.Fluent;

/// <summary>Contains the method for registering a listing.</summary>
[PublicAPI]
public abstract class CanCreateSeparateListingOrBuild : CanSection
{
    /// <summary>Creates a new listing in the <see cref="TweaksEditorSettings"/>.</summary>
    /// <param name="name">The name of the new listing.</param>
    /// <param name="fileName">The file name of the new listing.</param>
    /// <returns>Itself.</returns>
    [MustUseReturnValue, NotNull, PublicAPI]
    public abstract CanSection CreateSeparateListing([NotNull] string name, [NotNull] string fileName);

    /// <summary>Clears the builder and returns the finalized <see cref="TweaksEditorSettings"/>.</summary>
    /// <remarks><para>
    /// If you want to re-use it after this method is invoked, <see cref="CreateSeparateListing"/> needs
    /// to be first invoked before registering again with <see cref="CanRegister.Register{T}"/>.
    /// </para></remarks>
    [NotNull, PublicAPI, Pure]
    public abstract TweaksEditorSettings BuildAndClear();
}
