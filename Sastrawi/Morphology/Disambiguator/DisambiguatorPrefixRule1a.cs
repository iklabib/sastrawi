using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule1a : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, "^ber([aiueo].*)$");
        if (match.Success)
            return match.Groups[1].Value;

        return null;
    }
}
