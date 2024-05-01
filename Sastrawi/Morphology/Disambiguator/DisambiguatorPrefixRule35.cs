using System.Text.RegularExpressions;

namespace Disambiguator;

public class DisambiguatorPrefixRule35 : IDisambiguator
{
    public string? Disambiguate(string word)
    {
        var match = Regex.Match(word, "^ter([bcdfghjkpqstvxz])(er[bcdfghjklmnpqrstvwxyz])(.*)$");
        if (!match.Success)
            return null;

        return match.Groups[1].Value + match.Groups[2].Value + match.Groups[3].Value;
    }
}
