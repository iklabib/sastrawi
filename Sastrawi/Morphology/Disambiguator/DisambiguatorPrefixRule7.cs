using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule7 : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^ter([bcdfghjklmnpqrstvwxyz])er([aiueo].*)$");
        if (!match.Success)
            return string.Empty;

        if (match.Groups[1].Value == "r")
            return string.Empty;

        return match.Groups[1].Value + "er" + match.Groups[2].Value;
    }
}
