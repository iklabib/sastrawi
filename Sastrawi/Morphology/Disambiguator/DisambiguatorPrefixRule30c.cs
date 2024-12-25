using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule30c : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^penge(.*)$");
        if (!match.Success)
            return string.Empty;

        return match.Groups[1].Value;
    }
}
