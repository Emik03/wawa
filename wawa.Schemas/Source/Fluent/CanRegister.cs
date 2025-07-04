// SPDX-License-Identifier: MPL-2.0
namespace wawa.Schemas.Fluent;

/// <summary>Contains the method for registering a type.</summary>
public abstract class CanRegister
{
    /// <summary>The message to display when a developer uses the implicit methods created by classes.</summary>
    const string Message = "There is no reason to use this method as this class is meant to be used only as a factory.";

    /// <summary>Adds the schema of <typeparamref name="T"/> to the <see cref="TweaksEditorSettings"/>.</summary>
    /// <typeparam name="T">The type to register.</typeparam>
    /// <exception cref="AmbiguousMatchException">
    /// A member within <typeparamref name="T"/> has more than one <see cref="TweaksSettingAttribute"/> annotated.
    /// </exception>
    /// <returns>Itself.</returns>
    [MustUseReturnValue, NotNull, PublicAPI]
    public abstract CanCreateSeparateListingOrBuild Register<T>();

    /// <inheritdoc />
    [EditorBrowsable(EditorBrowsableState.Never), Obsolete(Message, true), Pure]
    public override bool Equals([Allow] object? obj) => false;

    /// <inheritdoc />
    [EditorBrowsable(EditorBrowsableState.Never), ValueRange(0), Obsolete(Message, true), Pure]
    public override int GetHashCode() => 0;

    /// <inheritdoc />
    [EditorBrowsable(EditorBrowsableState.Never), NotNull, Obsolete(Message, true), Pure]
    public override string ToString() => "";

    /// <inheritdoc cref="object.GetType"/>
    [EditorBrowsable(EditorBrowsableState.Never), NotNull, Obsolete(Message, true), Pure]
    public new Type GetType() => typeof(TweaksEditorSettings);
}
