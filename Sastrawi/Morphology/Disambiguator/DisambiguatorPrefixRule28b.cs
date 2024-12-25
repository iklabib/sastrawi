using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule28b : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^pen([aiueo])(.*)$");
        if (!match.Success)
            return string.Empty;

        return "t" + match.Groups[1].Value + match.Groups[2].Value;
    }
}
