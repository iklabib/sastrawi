using System.Text.RegularExpressions;

namespace Disambiguator;

class DisambiguatorPrefixRule41 : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^ku(.*)$");
        if (!match.Success)
            return null;

        return match.Groups[1].Value;
    }
}