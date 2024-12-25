using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule24 : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^per([bcdfghjklmnpqrstvwxyz])([a-z])er([aiueo])(.*)$");
        if (!match.Success)
            return string.Empty;

        if (match.Groups[1].Value == "r")
            return string.Empty;

        return match.Groups[1].Value
            + match.Groups[2].Value
            + "er"
            + match.Groups[3].Value
            + match.Groups[4].Value;
    }
}
