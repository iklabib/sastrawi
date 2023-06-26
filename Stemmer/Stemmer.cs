using Context;
using Visitor;
using Filter;
using System.Text.RegularExpressions;

namespace Stemmer;

public class Stemmer : IStemmer
{
    protected HashSet<string> dictionary;
    protected VisitorProvider visitorProvider;

    public Stemmer(HashSet<string> dictionary)
    {
        this.dictionary = dictionary;
        this.visitorProvider = new VisitorProvider();
    }

    public HashSet<string> GetDictionary()
    {
        return dictionary;
    }

    public string Stem(string text)
    {
        string normalized = TextNormalizer.NormalizeText(text);
        var stems = new List<string>();

        foreach (string word in normalized.Split(' '))
        {
            stems.Add(StemWord(word));
        }
        return String.Join(' ', stems);
    }

    protected string StemWord(string word)
    {
        if (IsPlural(word))
            return StemPluralWord(word);
        return StemSingularWord(word);
    }

    protected bool IsPlural(string word)
    {
        string pattern = @"^(.*)-(ku|mu|nya|lah|kah|tah|pun)$";
        var match = Regex.Match(word, pattern);
        if (match.Success)
            return match.Groups[1].Value.Contains('-');
        return word.Contains('-');
    }

    protected string StemPluralWord(string plural)
    {
        var match = Regex.Match(plural, @"^(.*)-(.*)$");
        if (!match.Success)
            return plural;
        
        string[] words = match.Groups.Values
                                     .Skip(1)
                                     .Select(el => el.Value)
                                     .ToArray();

        string suffix = words[1];
        string[] suffixes = new string[] { "ku", "mu", "nya", "lah", "kah", "tah", "pun" };

        match = Regex.Match(words[0], @"^(.*)-(.*)$");
        if (suffixes.Contains(words[1]) && match.Success)
        {
            words[0] = match.Groups[1].Value;
            words[1] = match.Groups[2].Value + "-" + suffix;
        }

        // berbalas-balasan -> balas
        string rootWord1 = StemSingularWord(words[0]);
        string rootWord2 = StemSingularWord(words[1]);

        if (!dictionary.Contains(words[1]) && rootWord2 == words[1])
        {
            rootWord2 = StemSingularWord("me" + words[1]);
        }

        if (rootWord1 == rootWord2)
            return rootWord1;

        return plural;
    }

    protected string StemSingularWord(string word)
    {
        Context.Context context = new(word, dictionary, visitorProvider);
        context.Execute();
        return context.GetResult();
    }
}
