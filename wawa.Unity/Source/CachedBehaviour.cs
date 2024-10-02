// SPDX-License-Identifier: MPL-2.0
namespace wawa.Unity;

/// <summary><see cref="MonoBehaviour"/> with caching methods.</summary>
[CLSCompliant(false), PublicAPI]
public abstract class CachedBehaviour : MonoBehaviour
{
    /// <summary>Contains the cached components.</summary>
    [NotNull, ProvidesContext]
    readonly Dictionary<Type, object> _cache = [];

    /// <summary>Clears the cache.</summary>
    [PublicAPI]
    public void Clear() => _cache.Clear();

    /// <summary>
    /// Caches and returns any or all <typeparamref name="T"/> components
    /// in this <see cref="Component.gameObject"/> and all children.
    /// </summary>
    /// <typeparam name="T">
    /// The singular component to locate. If this generic is specified as an array,
    /// all components are returned.
    /// </typeparam>
    /// <param name="includeInactive">
    /// Determines whether the search should include inactive <see cref="GameObject"/> instances.
    /// </param>
    /// <param name="includeSelf">
    /// Determines whether the search should include itself.
    /// Only takes effect when <typeparamref name="T"/> is <see cref="Array"/>.
    /// </param>
    /// <exception cref="MissingComponentException">
    /// The component <typeparamref name="T"/> couldn't be located.
    /// </exception>
    /// <returns>
    /// All components in <typeparamref name="T"/> if <typeparamref name="T"/> is an array, otherwise any component.
    /// </returns>
    [NotNull, PublicAPI]
    public T Child<T>(bool includeInactive = false, bool includeSelf = false)
        where T : class =>
        _cache.TryGetValue(typeof(T), out var o)
            ? (T)o
            : Assert<T>(
                _cache[typeof(T)] = typeof(T).IsArray
                    ? Create<Component, T>(GetComponentsInChildren(Element<T>(), includeInactive), includeSelf)
                    : GetComponentInChildren(typeof(T), includeInactive)
            );

    /// <summary>Caches and returns any or all <typeparamref name="T"/> components in the current scene.</summary>
    /// <typeparam name="T">
    /// The singular component to locate.
    /// If this generic is specified as an array, all components are returned.
    /// </typeparam>
    /// <param name="includeSelf">
    /// Determines whether the search should include itself.
    /// Only takes effect when <typeparamref name="T"/> is <see cref="Array"/>.
    /// </param>
    /// <exception cref="MissingComponentException">
    /// The component <typeparamref name="T"/> couldn't be located.
    /// </exception>
    /// <returns>
    /// All components in <typeparamref name="T"/> if <typeparamref name="T"/> is an array, otherwise any component.
    /// </returns>
    [NotNull, PublicAPI]
    public T Find<T>(bool includeSelf = false)
        where T : class =>
        _cache.TryGetValue(typeof(T), out var o)
            ? (T)o
            : Assert<T>(
                _cache[typeof(T)] = typeof(T).IsArray
                    ? Create<Object, T>(FindObjectsOfType(Element<T>()), includeSelf)
                    : FindObjectOfType(typeof(T))
            );

    /// <summary>
    /// Caches and returns any or all <typeparamref name="T"/> components in this <see cref="Component.gameObject"/>.
    /// </summary>
    /// <typeparam name="T">
    /// The singular component to locate.
    /// If this generic is specified as an array, all components are returned.
    /// </typeparam>
    /// <exception cref="MissingComponentException">
    /// The component <typeparamref name="T"/> couldn't be located.
    /// </exception>
    /// <returns>
    /// All components in <typeparamref name="T"/> if <typeparamref name="T"/> is an array, otherwise any component.
    /// </returns>
    [NotNull, PublicAPI]
    public T Get<T>()
        where T : class =>
        _cache.TryGetValue(typeof(T), out var o)
            ? (T)o
            : Assert<T>(
                _cache[typeof(T)] = typeof(T).IsArray
                    ? Create<Component, T>(GetComponents(Element<T>()), true)
                    : GetComponent(typeof(T))
            );

    /// <summary>
    /// Caches and returns any or all <typeparamref name="T"/> components in this <see cref="Component.gameObject"/>
    /// and all parents.
    /// </summary>
    /// <typeparam name="T">
    /// The singular component to locate. If this generic is specified as an array,
    /// all components are returned.
    /// </typeparam>
    /// <param name="includeInactive">
    /// Determines whether the search should include inactive <see cref="GameObject"/> instances.
    /// This parameter is only used if <typeparamref name="T"/> is specified to be an array.
    /// </param>
    /// <param name="includeSelf">
    /// Determines whether the search should include itself.
    /// Only takes effect when <typeparamref name="T"/> is <see cref="Array"/>.
    /// </param>
    /// <exception cref="MissingComponentException">
    /// The component <typeparamref name="T"/> couldn't be located.
    /// </exception>
    /// <returns>
    /// All components in <typeparamref name="T"/> if <typeparamref name="T"/> is an array, otherwise any component.
    /// </returns>
    [NotNull, PublicAPI]
    public T Parent<T>(bool includeInactive = false, bool includeSelf = false)
        where T : class =>
        _cache.TryGetValue(typeof(T), out var o)
            ? (T)o
            : Assert<T>(
                _cache[typeof(T)] = typeof(T).IsArray
                    ? Create<Component, T>(GetComponentsInParent(Element<T>(), includeInactive), includeSelf)
                    : GetComponentInParent(typeof(T))
            );

    [NotNull, Pure] // ReSharper disable once NullableWarningSuppressionIsUsed
    static Type Element<T>() => typeof(T).IsArray ? typeof(T).GetElementType()! : typeof(T);

    [MustUseReturnValue, NotNull]
    T Assert<T>([AllowNull, CanBeNull] in object o)
        where T : class =>
        o as T ?? throw new MissingComponentException($"Could not find {Element<T>().Name} in {this}.");

    [MustUseReturnValue, NotNull]
    TTo Create<TFrom, TTo>([NotNull] in TFrom[] input, [InstantHandle] bool includeSelf)
    {
        var type = Element<TTo>();

        long
            start = includeSelf ? 0 : GetComponents(type).GetLongLength(0),
            length = input.GetLongLength(0) - start,
            rank = typeof(TTo).GetArrayRank(),
            size = (long)Math.Ceiling(Math.Pow(length, 1.0 / rank));

        var indices = new long[rank];

        for (long i = 0; i < rank; i++)
            indices[i] = size;

        var array = Array.CreateInstance(type, indices);

        for (long i = 0; i < length; i++)
        {
            for (long j = 0; j < rank; j++)
                indices[j] = i / (long)Math.Pow(size, j) % size;

            array.SetValue(input[i + start], indices);
        }

        return (TTo)(object)array;
    }
}
