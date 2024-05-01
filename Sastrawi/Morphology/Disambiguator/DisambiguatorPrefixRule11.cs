using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule11 : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^mem([bfv])(.*)$");
        if (!match.Success)
            return null;

        return match.Groups[1].Value + match.Groups[2].Value;
    }
}
