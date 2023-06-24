using System.Text.RegularExpressions;

namespace Disambiguator;

class DisambiguatorPrefixRule30c : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^penge(.*)$");
        if (!match.Success)
            return null;
        
        return match.Groups[1].Value;
    }
}