using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule21a : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^per([aiueo])(.*)$");
        if (!match.Success)
            return null;

        return match.Groups[1].Value + match.Groups[2].Value;
    }
}
