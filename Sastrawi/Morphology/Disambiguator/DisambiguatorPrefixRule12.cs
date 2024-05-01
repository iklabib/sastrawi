using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule12 : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, @"^mempe(.*)$");
        if (!match.Success)
            return null;

        return "pe" + match.Groups[1].Value;
    }
}
