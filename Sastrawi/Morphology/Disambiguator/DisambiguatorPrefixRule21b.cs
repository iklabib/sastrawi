using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule21b : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^pe(r[aiueo])(.*)$");
        if (!match.Success)
            return null;

        return match.Groups[1].Value + match.Groups[2].Value;
    }
}
