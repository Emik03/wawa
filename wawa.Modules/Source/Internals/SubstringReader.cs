// SPDX-License-Identifier: MPL-2.0
namespace wawa.Modules.Internals;

/// <summary>Drop-in replacement for <see cref="StringReader"/>, but allows you to specify a starting offset.</summary>
/// <param name="s">The string to read.</param>
/// <param name="pos">The starting offset.</param>
sealed class SubstringReader([NotNull] string s, [NonNegativeValue] int pos) : TextReader
{
    /// <inheritdoc />
    [Pure]
    public override int Peek() => pos >= s.Length ? -1 : s[pos];

    /// <inheritdoc />
    public override int Read() => pos >= s.Length ? -1 : s[pos++];

    /// <inheritdoc />
    [MustUseReturnValue]
    public override int Read(char[] buffer, int index, int count)
    {
        if (pos >= s.Length)
            return 0;

        var n = Math.Min(count, s.Length - pos);
        s.CopyTo(pos, buffer, index, n);
        return pos += n;
    }
}
