using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule26a : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^pem([aiueo])(.*)$");
        if (!match.Success)
            return null;

        return "m" + match.Groups[1].Value + match.Groups[2].Value;
    }
}
