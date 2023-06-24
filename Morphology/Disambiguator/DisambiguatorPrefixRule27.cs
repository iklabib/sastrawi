using System.Text.RegularExpressions;

namespace Disambiguator;

class DisambiguatorPrefixRule27 : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^pen([cdjstz])(.*)$");
        if (!match.Success)
            return null;

        return match.Groups[1].Value + match.Groups[2].Value;
    }
}
