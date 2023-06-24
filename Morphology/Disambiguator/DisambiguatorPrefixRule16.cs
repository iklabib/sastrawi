using System.Text.RegularExpressions;

namespace Disambiguator;

class DisambiguatorPrefixRule16 : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^meng([g|h|q|k])(.*)$");
        if (!match.Success)
            return null;

        return match.Groups[1].Value + match.Groups[2].Value;
    }
}