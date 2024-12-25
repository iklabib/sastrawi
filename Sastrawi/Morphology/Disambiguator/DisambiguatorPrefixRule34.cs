using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule34 : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, "^pe([bcdfghjklmnpqrstvwxyz])(.*)$");
        if (!match.Success)
            return string.Empty;

        if (Regex.Match(match.Groups[2].Value, @"^er(.*)$").Success)
            return string.Empty;

        return match.Groups[1].Value + match.Groups[2].Value;
    }
}
