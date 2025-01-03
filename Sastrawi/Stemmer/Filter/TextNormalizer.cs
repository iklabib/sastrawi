using System.Text.RegularExpressions;

namespace Sastrawi.Stemmer.Filter;

public class TextNormalizer
{
    public static string NormalizeText(string text)
    {
        var flags = RegexOptions.Multiline | RegexOptions.IgnoreCase;
        string normalized = Regex.Replace(text.ToLower(), @"[^a-z0-9 -]", " ", flags);
        normalized = Regex.Replace(normalized, @"( +)", " ", flags);
        return normalized.Trim();
    }
}
