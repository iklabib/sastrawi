using System.Reflection;

namespace Stemmer;

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
        var words = GetWordsFromFile();
        return words.ToHashSet();
    }

    protected string[] GetWordsFromFile()
    {
        var dataDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        string dictionaryFile = Path.Combine(dataDir, "kata-dasar.txt");
        if (!System.IO.File.Exists(dictionaryFile))
            throw new Exception("Data directory is missing. It seems that your installation is corrupted.");

        using (var file = new StreamReader(dictionaryFile))
        {
            return file.ReadToEnd().Trim().Split().ToArray();
        }
    }
}