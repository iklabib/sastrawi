using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule26a : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^pem([aiueo])(.*)$");
        if (!match.Success)
            return string.Empty;

        return "m" + match.Groups[1].Value + match.Groups[2].Value;
    }
}
