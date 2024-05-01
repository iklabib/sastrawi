using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule31a : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^peny([aiueo])(.*)$");
        if (!match.Success)
            return null;

        return "ny" + match.Groups[1].Value + match.Groups[2].Value;
    }
}
