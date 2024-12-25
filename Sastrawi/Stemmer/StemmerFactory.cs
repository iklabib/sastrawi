namespace Sastrawi.Stemmer;

public class StemmerFactory
{
    public CachedStemmer CreateStemmer()
    {
        var stemmer = new Stemmer(CreateDefaultDictionary());

        IDictionary<string, string> resultCache = new Dictionary<string, string>();
        var cachedStemmer = new CachedStemmer(resultCache, stemmer);

        return cachedStemmer;
    }

    public HashSet<string> CreateDefaultDictionary()
    {
        var words = GetWordsFromFile().ToHashSet();
        words.Remove(""); // remove empty string if exist
        return words;
    }

    protected string[] GetWordsFromFile()
    {
        string dictionaryFile = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "data",
            "kata-dasar.txt"
        );
        if (!System.IO.File.Exists(dictionaryFile))
            throw new FileNotFoundException(
                "Data directory is missing. It seems that your installation is corrupted."
            );

        return System.IO.File.ReadAllText(dictionaryFile).Trim().Split().ToArray();
    }
}
