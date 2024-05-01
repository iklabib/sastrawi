using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule28b : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^pen([aiueo])(.*)$");
        if (!match.Success)
            return null;

        return "t" + match.Groups[1].Value + match.Groups[2].Value;
    }
}
