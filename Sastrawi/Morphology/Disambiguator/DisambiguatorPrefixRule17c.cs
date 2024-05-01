using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule17c : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^menge(.*)$");
        if (!match.Success)
            return null;

        return match.Groups[1].Value;
    }
}
