using Stemmer;

public class CachedStemmer : IStemmer {
    protected IDictionary<string, string> cache;
    protected IStemmer delegatedStemmer;

    public CachedStemmer(IDictionary<string, string> cache, IStemmer stemmer)
    {
        this.cache = cache;
        delegatedStemmer = stemmer;
    }

    public string Stem(string text)
    {
        string normalized = Filter.TextNormalizer.NormalizeText(text);

        List<string> stems = new();

        foreach(string word in normalized.Split(' '))
        {
            if (cache.ContainsKey(word))
            {
                stems.Add(word);
            }

            else
            {
                string stem = delegatedStemmer.Stem(word);

                cache[word] = stem;
                stems.Add(stem);
            }

        }

        return String.Join(' ', stems);
    }

    public IDictionary<string, string> GetCache()
    {
        // deep copy
        // return cache.ToDictionary(entry => entry.Key, entry => entry.Value);
        return cache;
    }
}