using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule3 : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^ber([bcdfghjklmnpqrstvwxyz])([a-z])er([aiueo])(.*)$");
        if (!match.Success)
            return null;

        if (match.Groups[1].Value == "r")
            return null;

        return match.Groups[1].Value
            + match.Groups[2].Value
            + "er"
            + match.Groups[3].Value
            + match.Groups[4].Value;
    }
}
