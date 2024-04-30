using System.Text.RegularExpressions;

namespace Disambiguator;

class DisambiguatorPrefixRule4 : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        if (word == "belajar")
            return "ajar";
        return null;
    }
}
