using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule15b : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^men([aiueo])(.*)$");
        if (!match.Success)
            return string.Empty;

        return "t" + match.Groups[1].Value + match.Groups[2].Value;
    }
}
