using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule4 : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        if (word == "belajar")
            return "ajar";
        return null;
    }
}
