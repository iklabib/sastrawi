using System.Text.RegularExpressions;

namespace Disambiguator;

class DisambiguatorPrefixRule1b : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, "^ber([aiueo].*)$");
        if (match.Success)
            return "r" + match.Groups[1].Value;
            
        return null;
    }
}