using System.Text.RegularExpressions;

namespace Disambiguator;

class DisambiguatorPrefixRule42 : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^kau(.*)$");
        if (!match.Success)
            return null;

        return match.Groups[1].Value;
    }
}
