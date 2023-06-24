using System.Text.RegularExpressions;

namespace Disambiguator;

class DisambiguatorPrefixRule30a : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^peng([aiueo])(.*)$");
        if (!match.Success)
            return null;
        
        return match.Groups[1].Value + match.Groups[2].Value;
    }
}