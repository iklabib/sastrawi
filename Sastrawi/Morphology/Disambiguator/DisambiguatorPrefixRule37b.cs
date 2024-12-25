using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule37b : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, "^([bcdfghjklmnpqrstvwxyz])er([aiueo])(.*)$");
        if (!match.Success)
            return string.Empty;

        return match.Groups[1].Value + match.Groups[2].Value + match.Groups[3].Value;
    }
}
