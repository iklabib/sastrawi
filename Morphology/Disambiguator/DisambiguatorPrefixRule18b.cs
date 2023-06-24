using System.Text.RegularExpressions;

namespace Disambiguator;

class DisambiguatorPrefixRule18b : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^meny([aiueo])(.*)$");
        if (!match.Success)
            return null;

        return "s" + match.Groups[1].Value + match.Groups[2].Value;
    }
}
