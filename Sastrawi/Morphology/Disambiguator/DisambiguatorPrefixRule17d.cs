using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule17d : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^meng([aiueo])(.*)$");
        if (!match.Success)
            return null;

        return "ng" + match.Groups[1].Value + match.Groups[2].Value;
    }
}
