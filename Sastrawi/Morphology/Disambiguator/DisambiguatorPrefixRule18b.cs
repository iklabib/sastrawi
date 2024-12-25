using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule18b : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^meny([aiueo])(.*)$");
        if (!match.Success)
            return string.Empty;

        return "s" + match.Groups[1].Value + match.Groups[2].Value;
    }
}
