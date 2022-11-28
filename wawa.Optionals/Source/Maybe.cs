// <copyright file="Maybe.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Wawa.Optionals;

/// <summary>Implementations for <see cref="Maybe{T}"/>.</summary>
[PublicAPI]
public static class Maybe
{
    [NotNull]
    const string UnwrapMessage = $"Called '{nameof(Unwrap)}' on a None {nameof(Maybe)}.";

    // ReSharper disable UseNegatedPatternInIsExpression

    /// <summary>Assigns a value with the inner value, or a <see langword="default"/> value if none exists.</summary>
    /// <typeparam name="T">The generic type argument in <see cref="Maybe{T}"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Maybe{T}"/>.</param>
    /// <param name="result">The resulting value, or <see langword="default"/>.</param>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> contains a value, otherwise <see langword="false"/>.
    /// </returns>
    [PublicAPI, Pure]
    public static bool TryGet<T>(
        [InstantHandle] this Maybe<T> that,
        [AllowNull, CanBeNull, NotNullWhen(true)] out T result
    ) =>
        that.IsSome
            ? (result = that.Value) is var _
            : !((result = default) is var _);

    /// <summary>Gets an empty <see cref="Maybe{T}"/> of the desired type.</summary>
    /// <typeparam name="T">The generic in <see cref="Maybe{T}"/>.</typeparam>
    /// <returns>
    /// A <see cref="Maybe{T}"/> that always has <see cref="Maybe{T}.IsNone"/>
    /// <see langword="return"/> <see langword="true"/>.
    /// </returns>
    [PublicAPI, Pure]
    public static Maybe<T> None<T>() => default;

    /// <summary>Uses the callback corresponding to the inner value of <paramref name="that"/>.</summary>
    /// <typeparam name="T">The type of value stored within <paramref name="that"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Maybe{T}"/>.</param>
    /// <param name="some">The callback to run if <see cref="Maybe{T}.IsSome"/> is <see langword="true"/>.</param>
    /// <param name="none">The callback to run if <see cref="Maybe{T}.IsSome"/> is <see langword="false"/>.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [PublicAPI]
    public static Maybe<T> Match<T>(
        [InstantHandle] this Maybe<T> that,
        [AllowNull, CanBeNull, InstantHandle] Action<T> some = null,
        [AllowNull, CanBeNull, InstantHandle] Action<Unit> none = null
    )
    {
        if (that.IsSome)
            some?.Invoke(that.Value);
        else
            none?.Invoke(default);

        return that;
    }

    /// <summary>Wraps <typeparamref name="T"/> in a <see cref="Maybe{T}"/>.</summary>
    /// <remarks><para>Value types are the only types that cannot be <see langword="null"/>.</para></remarks>
    /// <typeparam name="T">The type of parameter and generic in <see cref="Maybe{T}"/>.</typeparam>
    /// <param name="that">This instance of <typeparamref name="T"/>.</param>
    /// <returns>A new instance of <see cref="Maybe{T}"/>.</returns>
    [PublicAPI, Pure]
    public static Maybe<T> Some<T>(T that)
        where T : struct =>
        new(that);

    /// <summary>Gets an iterator that has the value once, or is empty.</summary>
    /// <typeparam name="T">The type of parameter and generic in <see cref="Maybe{T}"/>.</typeparam>
    /// <param name="source">This instance of <see cref="Maybe{T}"/>.</param>
    /// <returns>An iterator that yields the inner value once, or <see cref="Enumerable.Empty{T}"/>.</returns>
    [LinqTunnel, NotNull, Pure, PublicAPI]
    public static IEnumerable<T> GetEnumerator<T>(this Maybe<T> source) =>
        source.IsSome
            ? Enumerable.Repeat(source.Value, 1)
            : Enumerable.Empty<T>();

    /// <summary>Filters a collection with only that of items with a value.</summary>
    /// <typeparam name="T">The type of parameter and generic in <see cref="Maybe{T}"/>.</typeparam>
    /// <param name="source">This collection of <see cref="Maybe{T}"/>.</param>
    /// <returns>A filtered collection only consisting of unwrapped <typeparamref name="T"/> values.</returns>
    [LinqTunnel, NotNull, Pure, PublicAPI]
    public static IEnumerable<T> Filter<T>([InstantHandle] this IEnumerable<Maybe<T>> source) =>
        source.Where(static may => may.IsSome).Select(static may => may.Value);

    /// <summary>Flattens a nested <see cref="Maybe{T}"/>.</summary>
    /// <typeparam name="T">The type of value stored within <paramref name="that"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Maybe{T}"/>.</param>
    /// <returns>The nested <see cref="Maybe{T}"/>, or <see langword="default"/>.</returns>
    [PublicAPI, Pure]
    public static Maybe<T> Flatten<T>(this Maybe<Maybe<T>> that) => that.IsSome ? that.Value : default;

    /// <summary>Flattens a nested <see cref="Maybe{T}"/>.</summary>
    /// <typeparam name="T">The type of value stored within <paramref name="that"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Maybe{T}"/>.</param>
    /// <returns>The nested <see cref="Maybe{T}"/>, or <see langword="default"/>.</returns>
    [PublicAPI, Pure]
    public static Maybe<T> Flatten<T>(this Maybe<Maybe<Maybe<T>>> that) => that.IsSome ? that.Value.Flatten() : default;

    /// <summary>Flattens a nested <see cref="Maybe{T}"/>.</summary>
    /// <typeparam name="T">The type of value stored within <paramref name="that"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Maybe{T}"/>.</param>
    /// <returns>The nested <see cref="Maybe{T}"/>, or <see langword="default"/>.</returns>
    [PublicAPI, Pure]
    public static Maybe<T> Flatten<T>(this Maybe<Maybe<Maybe<Maybe<T>>>> that) =>
        that.IsSome ? that.Value.Flatten() : default;

    /// <summary>Wraps <typeparamref name="T"/> in a <see cref="Maybe{T}"/>.</summary>
    /// <typeparam name="T">The type of parameter and generic in <see cref="Maybe{T}"/>.</typeparam>
    /// <param name="that">This instance of <typeparamref name="T"/>.</param>
    /// <returns>A new instance of <see cref="Maybe{T}"/>.</returns>
    [PublicAPI, Pure]
    public static Maybe<T> From<T>([AllowNull, CanBeNull] T that)
        where T : class =>
        new(that);

    /// <summary>Wraps <typeparamref name="T"/> in a <see cref="Maybe{T}"/>.</summary>
    /// <typeparam name="T">The type of parameter and generic in <see cref="Maybe{T}"/>.</typeparam>
    /// <param name="that">This instance of <typeparamref name="T"/>.</param>
    /// <returns>A new instance of <see cref="Maybe{T}"/>.</returns>
    [PublicAPI, Pure]
    public static Maybe<T> From<T>([AllowNull, CanBeNull] T? that)
        where T : struct =>
        that.HasValue ? new(that.Value) : default;

    /// <summary>Wraps <typeparamref name="T"/> in a <see cref="Maybe{T}"/>.</summary>
    /// <remarks><para>This is an extension method for calling <see cref="From{T}(T)"/>.</para></remarks>
    /// <typeparam name="T">The type of parameter and generic in <see cref="Maybe{T}"/>.</typeparam>
    /// <param name="that">This instance of <typeparamref name="T"/>.</param>
    /// <returns>A new instance of <see cref="Maybe{T}"/>.</returns>
    [PublicAPI, Pure]
    public static Maybe<T> ToMaybe<T>([AllowNull, CanBeNull] this T? that)
        where T : struct =>
        From(that);

    /// <summary>Uses the callback corresponding to the inner value of <paramref name="that"/>.</summary>
    /// <typeparam name="T">The type of value stored within <paramref name="that"/>.</typeparam>
    /// <typeparam name="TResult">The <see langword="return"/> value of both callbacks.</typeparam>
    /// <param name="that">This instance of <see cref="Maybe{T}"/>.</param>
    /// <param name="some">The callback to run if <see cref="Maybe{T}.IsSome"/> is <see langword="true"/>.</param>
    /// <returns>The value returned from the corresponding callback.</returns>
    [PublicAPI]
    public static Maybe<TResult> Match<T, TResult>(
        this Maybe<T> that,
        [InstantHandle, NotNull] Func<T, Maybe<TResult>> some
    ) =>
        that.IsSome ? some(that.Value) : default;

    /// <summary>Uses the callback corresponding to the inner value of <paramref name="that"/>.</summary>
    /// <typeparam name="T">The type of value stored within <paramref name="that"/>.</typeparam>
    /// <typeparam name="TResult">The <see langword="return"/> value of both callbacks.</typeparam>
    /// <param name="that">This instance of <see cref="Maybe{T}"/>.</param>
    /// <param name="some">The callback to run if <see cref="Maybe{T}.IsSome"/> is <see langword="true"/>.</param>
    /// <returns>The value returned from the callback, or <see langword="default"/>.</returns>
    [PublicAPI]
    public static Maybe<TResult> Match<T, TResult>(
        this Maybe<T> that,
        [InstantHandle, NotNull] Func<T, TResult> some
    ) =>
        that.IsSome ? some(that.Value) : default;

    /// <summary>Gives the parameter corresponding to the inner value of <paramref name="that"/>.</summary>
    /// <typeparam name="T">The type of value stored within <paramref name="that"/>.</typeparam>
    /// <typeparam name="TResult">The <see langword="return"/> value of both callbacks.</typeparam>
    /// <param name="that">This instance of <see cref="Maybe{T}"/>.</param>
    /// <param name="some">The value to return if <see cref="Maybe{T}.IsSome"/> is <see langword="true"/>.</param>
    /// <returns>The parameter, or <see langword="default"/>.</returns>
    [PublicAPI, Pure]
    public static Maybe<TResult> Match<T, TResult>(this Maybe<T> that, TResult some) => that.IsSome ? some : default;

    /// <summary>
    /// Gets the value that is encapsulated. This value returned will not be <see langword="null"/>,
    /// and consequentially if it is.
    /// </summary>
    /// <typeparam name="T">The type of value stored within <paramref name="that"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Maybe{T}"/>.</param>
    /// <exception cref="InvalidOperationException">
    /// The parameter <paramref name="that"/> has <see cref="Maybe{T}.IsSome"/> set to <see langword="false"/>.
    /// </exception>
    /// <returns>The inner value.</returns>
    [PublicAPI, Pure]
    public static T Unwrap<T>(this Maybe<T> that) =>
        that.IsSome
            ? that.Value
            : throw new InvalidOperationException(UnwrapMessage);

    /// <summary>Gives the inner value, or the parameter.</summary>
    /// <typeparam name="T">The type of value stored within <paramref name="that"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Maybe{T}"/>.</param>
    /// <param name="otherwise">The value to return if <see cref="Maybe{T}.IsSome"/> is <see langword="false"/>.</param>
    /// <returns>The inner value, or the parameter <paramref name="otherwise"/>.</returns>
    [PublicAPI, Pure]
    public static T UnwrapOr<T>(this Maybe<T> that, T otherwise) => that.IsSome ? that.Value : otherwise;

    /// <summary>Gives the inner value, or the returned value from the callback.</summary>
    /// <typeparam name="T">The type of value stored within <paramref name="that"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Maybe{T}"/>.</param>
    /// <param name="otherwise">
    /// The callback to execute if <see cref="Maybe{T}.IsSome"/> is <see langword="false"/>.
    /// </param>
    /// <returns>The inner value, or the returned value from the parameter <paramref name="otherwise"/>.</returns>
    [PublicAPI]
    public static T UnwrapOr<T>(this Maybe<T> that, [InstantHandle, NotNull] Func<Unit, T> otherwise) =>
        that.IsSome ? that.Value : otherwise(default);

    /// <summary>Gives the inner value, or <see langword="default"/>.</summary>
    /// <typeparam name="T">The type of value stored within <paramref name="that"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Maybe{T}"/>.</param>
    /// <returns>The inner value, or <see langword="default"/>.</returns>
    [PublicAPI, Pure]
    public static T UnwrapOrDefault<T>(this Maybe<T> that)
        where T : struct =>
        that.IsSome ? that.Value : default;

    /// <summary>Gives the inner value, or a <see langword="new"/> instance.</summary>
    /// <typeparam name="T">The type of value stored within <paramref name="that"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Maybe{T}"/>.</param>
    /// <returns>The inner value, or a <see langword="new"/> instance.</returns>
    [PublicAPI, Pure]
#pragma warning disable CA1711
    public static T UnwrapOrNew<T>(this Maybe<T> that)
#pragma warning restore CA1711
        where T : new() =>
        that.IsSome ? that.Value : new();

    /// <summary>Uses the callback corresponding to the inner value of <paramref name="that"/>.</summary>
    /// <typeparam name="T">The type of value stored within <paramref name="that"/>.</typeparam>
    /// <typeparam name="TResult">The <see langword="return"/> value of both callbacks.</typeparam>
    /// <param name="that">This instance of <see cref="Maybe{T}"/>.</param>
    /// <param name="some">The callback to run if <see cref="Maybe{T}.IsSome"/> is <see langword="true"/>.</param>
    /// <param name="none">The callback to run if <see cref="Maybe{T}.IsSome"/> is <see langword="false"/>.</param>
    /// <returns>The value returned from the corresponding callback.</returns>
    [PublicAPI]
    public static TResult Match<T, TResult>(
        this Maybe<T> that,
        [InstantHandle, NotNull] Func<T, TResult> some,
        [InstantHandle, NotNull] Func<Unit, TResult> none
    ) =>
        that.IsSome ? some(that.Value) : none(default);

    /// <summary>Gives the parameter corresponding to the inner value of <paramref name="that"/>.</summary>
    /// <typeparam name="T">The type of value stored within <paramref name="that"/>.</typeparam>
    /// <typeparam name="TResult">The <see langword="return"/> value of both callbacks.</typeparam>
    /// <param name="that">This instance of <see cref="Maybe{T}"/>.</param>
    /// <param name="some">The value to return if <see cref="Maybe{T}.IsSome"/> is <see langword="true"/>.</param>
    /// <param name="none">The value to return if <see cref="Maybe{T}.IsSome"/> is <see langword="false"/>.</param>
    /// <returns>The corresponding parameter.</returns>
    [PublicAPI, Pure]
    public static TResult Match<T, TResult>(this Maybe<T> that, TResult some, TResult none) =>
        that.IsSome ? some : none;
}
