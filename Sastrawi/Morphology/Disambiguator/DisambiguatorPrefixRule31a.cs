using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule31a : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^peny([aiueo])(.*)$");
        if (!match.Success)
            return string.Empty;

        return "ny" + match.Groups[1].Value + match.Groups[2].Value;
    }
}
