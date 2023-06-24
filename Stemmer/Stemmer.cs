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

        foreach(string word in normalized.Split(' '))
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

    protected string StemPluralWord(string word)
    {
        var match = Regex.Match(word, @"^(.*)-(.*)$");
        if (!match.Success)
            return word;

        // malaikat-malaikat-nya -> malaikat malaikat-nya
        string suffix = match.Groups[2].Value;
        string[] suffixes = new string[] {"ku", "mu", "nya", "lah", "kah", "tah", "pun"};

        string word1 = match.Groups[1].Value;
        string word2 = match.Groups[2].Value;

        match = Regex.Match(word1, @"^(.*)-(.*)$");
        if (suffixes.Contains(word2) && match.Success)
        {
           word1 = match.Groups[1].Value;
           word2 = match.Groups[2].Value + "-" + word2;
        }

        // berbalas-balasan -> balas
        string rootWord1 = StemSingularWord(word1);
        string rootWord2 = StemSingularWord(word2);

        if (dictionary.Contains(word2) && rootWord2 == word2)
        {
            rootWord2 = StemSingularWord("me" + word2);
        }

        if (rootWord1 == rootWord2)
            return rootWord1;

        return word;
    }

    protected string StemSingularWord(string word)
    {
        Context.Context context = new(word, dictionary, visitorProvider);
        context.Execute();
        return context.GetResult();
    }
}