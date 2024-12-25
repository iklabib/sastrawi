using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule30b : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^peng([aiueo])(.*)$");
        if (!match.Success)
            return string.Empty;

        return "k" + match.Groups[1].Value + match.Groups[2].Value;
    }
}
