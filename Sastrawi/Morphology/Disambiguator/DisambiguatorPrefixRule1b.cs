using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule1b : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, "^ber([aiueo].*)$");
        if (match.Success)
            return "r" + match.Groups[1].Value;

        return string.Empty;
    }
}
