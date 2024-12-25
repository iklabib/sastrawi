using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule32 : IDisambiguator
{
    public string Disambiguate(string word)
    {
        if (word == "pelajar")
            return "ajar";

        var match = Regex.Match(word, @"^pe(l[aiueo])(.*)$");
        if (!match.Success)
            return string.Empty;

        return match.Groups[1].Value + match.Groups[2].Value;
    }
}
