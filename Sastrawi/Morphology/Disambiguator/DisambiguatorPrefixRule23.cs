using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule23 : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^per([bcdfghjklmnpqrstvwxyz])([a-z])(.*)$");
        if (!match.Success)
            return null;

        if (Regex.Match(match.Groups[3].Value, @"^er(.*)$").Success)
            return null;

        return match.Groups[1].Value + match.Groups[2].Value + match.Groups[3].Value;
    }
}
