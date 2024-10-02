// SPDX-License-Identifier: MPL-2.0
namespace wawa.Schemas;

/// <summary>The class for holding the settings schema object used by tweaks for the mod settings.</summary>
[PublicAPI]
public sealed class TweaksEditorSettings : IEnumerable<Dictionary<string, object>>
{
    /// <summary>The builder class for creating the settings schema object used by tweaks for the mod settings.</summary>
    public sealed class Builder : CanCreateSeparateListingOrBuild, IEnumerable
    {
        /// <summary>The suffix for the default file name for mod settings.</summary>
        [NotNull, StringSyntax(StringSyntaxAttribute.Uri), UriString]
        const string Suffix = "-settings.json";

        [CanBe]
        List<Dictionary<string, object>> _last;

        [NotNull, ProvidesContext] // ReSharper disable once NullableWarningSuppressionIsUsed
        List<Dictionary<string, object>> _product = [];

        /// <inheritdoc />
        [PublicAPI]
        public override TweaksEditorSettings BuildAndClear()
        {
            var product = _product;
            _product = [];
            _last = null;
            return new(product);
        }

        /// <inheritdoc />
        [MustUseReturnValue, PublicAPI]
        public override CanSection CreateSeparateListing(string name, string fileName)
        {
            Add(name, fileName);
            return this;
        }

        /// <inheritdoc />
        [MustUseReturnValue, PublicAPI]
        public override CanRegister Section(string text)
        {
            _product.Add(new(StringComparer.Ordinal) { ["Text"] = text, ["Type"] = "Section" });
            return this;
        }

        /// <inheritdoc />
        [MustUseReturnValue, PublicAPI]
        public override CanCreateSeparateListingOrBuild Register<T>()
        {
            if (_last is null)
                return this;

            foreach (var member in typeof(T).GetMembers(BindingFlags.Public | BindingFlags.Instance))
                if (TweaksSetting.From(member) is { } setting)
                    _last.Add(setting.ToDictionary(member));

            return this;
        }

        /// <inheritdoc />
        [PublicAPI, Pure]
        IEnumerator IEnumerable.GetEnumerator() => _product.GetEnumerator();

        /// <summary>Starts a new listing in the <see cref="TweaksEditorSettings"/>.</summary>
        /// <param name="name">The name of the new listing.</param>
        /// <param name="fileName">The file name of the new listing.</param>
        /// <returns></returns>
        internal void Add([NotNull] string name, [Allow, CanBe] string fileName) =>
            _product.Add(
                new(StringComparer.Ordinal)
                {
                    ["Filename"] = $"{fileName}{Suffix}", ["Name"] = name, ["Listings"] = _last = [],
                }
            );
    }

    TweaksEditorSettings(List<Dictionary<string, object>> product) => _product = product;

    [ProvidesContext]
    readonly List<Dictionary<string, object>> _product;

    /// <summary>Creates the new builder.</summary>
    /// <param name="name">The name of the initial listing.</param>
    /// <param name="modId">
    /// The mod id to get the file name from.
    /// If <see langword="null" />, implicitly gets the file name of the mod from the name of the assembly.
    /// </param>
    /// <returns>Itself.</returns>
    [PublicAPI, Pure]
    public static CanSection CreateListing([NotNull] string name, [Allow, CanBe] string modId = null) =>
        new Builder { { name, modId ?? new StackFrame(1).GetMethod().ReflectedType?.Assembly.GetName().Name } };

    /// <inheritdoc />
    IEnumerator<Dictionary<string, object>> IEnumerable<Dictionary<string, object>>.GetEnumerator() =>
        _product.GetEnumerator();

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator() => _product.GetEnumerator();
}
