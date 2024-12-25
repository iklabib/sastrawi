using System.Text.RegularExpressions;

namespace Sastrawi.Morphology.Disambiguator;

public class DisambiguatorPrefixRule4 : IDisambiguator
{
    public string Disambiguate(string word)
    {
        if (word == "belajar")
            return "ajar";
        return string.Empty;
    }
}
