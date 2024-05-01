using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule10 : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^me([lrwy])([aiueo])(.*)$");
        if (!match.Success)
            return null;

        return match.Groups[1].Value + match.Groups[2].Value + match.Groups[3].Value;
    }
}
