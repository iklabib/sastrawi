using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule9 : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(
            word,
            @"^te([bcdfghjklmnpqrstvwxyz])er([bcdfghjklmnpqrstvwxyz])(.*)$"
        );
        if (!match.Success)
            return null;

        if (match.Groups[1].Value == "r")
            return null;

        return match.Groups[1].Value + "er" + match.Groups[2].Value + match.Groups[3].Value;
    }
}
