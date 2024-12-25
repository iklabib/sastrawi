using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule12 : IDisambiguator
{
    public string Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^mempe(.*)$");
        if (!match.Success)
            return string.Empty;

        return "pe" + match.Groups[1].Value;
    }
}
