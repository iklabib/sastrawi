using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule41 : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^ku(.*)$");
        if (!match.Success)
            return string.Empty;

        return match.Groups[1].Value;
    }
}
