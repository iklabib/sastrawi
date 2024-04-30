using System.Text.RegularExpressions;

namespace Disambiguator;

class DisambiguatorPrefixRule39b : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^([bcdfghjklmnpqrstvwxyz])em([aiueo])(.*)$");
        if (!match.Success)
            return null;

        return match.Groups[1].Value + match.Groups[2].Value + match.Groups[3].Value;
    }
}
