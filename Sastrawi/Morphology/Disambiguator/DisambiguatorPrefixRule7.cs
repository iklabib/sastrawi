using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule7 : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^ter([bcdfghjklmnpqrstvwxyz])er([aiueo].*)$");
        if (!match.Success)
            return null;

        if (match.Groups[1].Value == "r")
            return null;

        return match.Groups[1].Value + "er" + match.Groups[2].Value;
    }
}
