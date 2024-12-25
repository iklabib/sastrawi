using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule13b : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^mem([aiueo])(.*)$");
        if (!match.Success)
            return string.Empty;

        return "p" + match.Groups[1].Value + match.Groups[2].Value;
    }
}
