using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule29 : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^peng([bcdfghjklmnpqrstvwxyz])(.*)$");
        if (!match.Success)
            return null;

        return match.Groups[1].Value + match.Groups[2].Value;
    }
}
