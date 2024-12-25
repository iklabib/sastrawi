using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule8 : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^ter([bcdfghjklmnpqrstvwxyz])(.*)$");
        if (!match.Success)
            return string.Empty;

        if (match.Groups[1].Value == "r" || Regex.Match(match.Groups[2].Value, @"^er(.*)$").Success)
            return string.Empty;

        return match.Groups[1].Value + match.Groups[2].Value;
    }
}
