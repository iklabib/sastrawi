using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule18a : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^meny([aiueo])(.*)$");
        if (!match.Success)
            return null;

        return "ny" + match.Groups[1].Value + match.Groups[2].Value;
    }
}
