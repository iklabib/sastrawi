using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule23 : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^per([bcdfghjklmnpqrstvwxyz])([a-z])(.*)$");
        if (!match.Success)
            return string.Empty;

        if (Regex.Match(match.Groups[3].Value, @"^er(.*)$").Success)
            return string.Empty;

        return match.Groups[1].Value + match.Groups[2].Value + match.Groups[3].Value;
    }
}
