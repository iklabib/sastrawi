using System.Text.RegularExpressions;

namespace Disambiguator;

class DisambiguatorPrefixRule26b : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^pem([aiueo])(.*)$");
        if (!match.Success)
            return null;

        return "p" + match.Groups[1].Value + match.Groups[2].Value;
    }
}
