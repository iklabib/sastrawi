using System.Text.RegularExpressions;

namespace Disambiguator;

class DisambiguatorPrefixRule19 : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^memp([abcdfghijklmopqrstuvwxyz])(.*)$");
        if (!match.Success)
            return null;

        return "p" + match.Groups[1].Value + match.Groups[2].Value;
    }
}
