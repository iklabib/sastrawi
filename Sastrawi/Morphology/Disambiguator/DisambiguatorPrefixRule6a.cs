using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule6a : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^ter([aiueo].*)$");
        if (!match.Success)
            return string.Empty;

        return match.Groups[1].Value;
    }
}
