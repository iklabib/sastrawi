using System.Text.RegularExpressions;

namespace Disambiguator;

class DisambiguatorPrefixRule6b : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^ter([aiueo].*)$");
        if (!match.Success)
            return null;

        return "r" + match.Groups[1].Value;
    }
}
