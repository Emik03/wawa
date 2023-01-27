// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Overkill;

/// <inheritdoc />
[CLSCompliant(false)]
public sealed class InjectorResolver : BaseAssemblyResolver
{
    readonly DefaultAssemblyResolver _defaultResolver = new();

    /// <summary>Initializes a new instance of the <see cref="InjectorResolver"/> class.</summary>
    /// <param name="injector">The injector.</param>
    public InjectorResolver(AssemblyDefinition injector) => Injectors = injector.Yield();

    /// <summary>Initializes a new instance of the <see cref="InjectorResolver"/> class.</summary>
    /// <param name="injectors">The injectors.</param>
    public InjectorResolver(IEnumerable<AssemblyDefinition> injectors) => Injectors = injectors;

    /// <summary>Gets the injectors.</summary>
    public IEnumerable<AssemblyDefinition> Injectors { get; }

    /// <inheritdoc />
    [CollectionAccess(CollectionAccessType.None)]
    protected override void Dispose(bool disposing)
    {
        _defaultResolver.Dispose();
        base.Dispose(disposing);
    }

    /// <inheritdoc />
    public override AssemblyDefinition Resolve(AssemblyNameReference name) =>
        Injectors.FirstOrDefault(x => IsEqual(x, name)) ??
        _defaultResolver.Resolve(name);

    static bool IsEqual(AssemblyDefinition asm, AssemblyNameReference asmName) =>
        asm.Name.Name == asmName.Name && asm.Name.Version == asmName.Version;
}
