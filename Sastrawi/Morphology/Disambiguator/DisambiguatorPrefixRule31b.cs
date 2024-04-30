using System.Text.RegularExpressions;

namespace Disambiguator;

class DisambiguatorPrefixRule31b : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^peny([aiueo])(.*)$");
        if (!match.Success)
            return null;

        return "s" + match.Groups[1].Value + match.Groups[2].Value;
    }
}
