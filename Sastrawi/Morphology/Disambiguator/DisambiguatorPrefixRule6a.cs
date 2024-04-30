using System.Text.RegularExpressions;

namespace Disambiguator;

class DisambiguatorPrefixRule6a : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^ter([aiueo].*)$");
        if (!match.Success)
            return null;

        return match.Groups[1].Value;
    }
}
