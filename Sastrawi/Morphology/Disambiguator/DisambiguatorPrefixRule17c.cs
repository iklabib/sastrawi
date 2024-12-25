using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule17c : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^menge(.*)$");
        if (!match.Success)
            return string.Empty;

        return match.Groups[1].Value;
    }
}
