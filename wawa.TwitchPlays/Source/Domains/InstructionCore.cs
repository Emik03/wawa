// SPDX-License-Identifier: MPL-2.0
namespace wawa.TwitchPlays.Domains;

/// <summary>Implementations for <see cref="Instruction"/>.</summary>
[PublicAPI]
public static class InstructionCore
{
    /// <summary>Flattens the enumeration for coroutine use.</summary>
    /// <remarks><para>The caller is responsible for disposing the returned enumerator.</para></remarks>
    /// <param name="that">This instance of <see cref="IEnumerable{T}"/>.</param>
    /// <returns>
    /// An <see cref="IEnumerator{T}"/> of <see cref="object"/> that is friendly to be used for coroutines,
    /// containing the values from <paramref name="that"/>.
    /// </returns>
    [MustDisposeResource, NotNull, PublicAPI, Pure]
    public static IEnumerator<object> Flatten(
        [InstantHandle, ItemCanBeNull, NotNull] this IEnumerable<Instruction> that
    ) =>
        Recursive(that.GetEnumerator());

    /// <summary>Flattens nested enumerators into one long enumerator.</summary>
    /// <param name="that">This instance of <see cref="IEnumerable{T}"/>.</param>
    /// <returns>The flattened enumerator of the parameter <paramref name="that"/>.</returns>
    [NotNull, Pure]
    internal static IEnumerator<Instruction?> Flatten([NotNull] this IEnumerator<Instruction> that)
    {
        while (that.MoveNext())
        {
            var current = that.Current;
            var value = current?.Value;

            if (value is not IEnumerator<Instruction> nested)
            {
                yield return current;

                continue;
            }

            using var these = Flatten(nested);

            while (these.MoveNext())
                yield return these.Current;
        }
    }

    [NotNull, Pure]
    static IEnumerator<object?> Recursive([AllowNull, CanBeNull] IEnumerator<Instruction> that)
    {
        if (that is null)
            yield break;

        while (that.MoveNext())
        {
            if (that.Current?.Value is not IEnumerator<Instruction> enumerable)
            {
                yield return that.Current?.Value;

                continue;
            }

            using var these = Recursive(enumerable);

            while (these.MoveNext())
                yield return these.Current;
        }
    }
}
