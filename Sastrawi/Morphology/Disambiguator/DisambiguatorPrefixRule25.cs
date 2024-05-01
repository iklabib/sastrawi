using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule25 : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^pem([bfv])(.*)$");
        if (!match.Success)
            return null;

        return match.Groups[1].Value + match.Groups[2].Value;
    }
}
