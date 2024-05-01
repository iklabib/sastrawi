using Stemmer;
namespace Sastrawi.Tests.IntegrationTests;

public class StemmerTest
{
    private IStemmer stemmer;
    public StemmerTest() {
        var stemmerFactory = new StemmerFactory();
        stemmer = stemmerFactory.CreateStemmer();
    }

    [Fact]
    public void TestStems()
    {
        Assert.Equal("bijak", stemmer.Stem("kebijakan"));
        Assert.Equal("kerja", stemmer.Stem("kinerja"));
        Assert.Equal("kandung", stemmer.Stem("mengandung"));
        Assert.Equal("makan", stemmer.Stem("memakan"));
        Assert.Equal("asean", stemmer.Stem("asean"));
        Assert.Equal("pandu", stemmer.Stem("pemandu"));
        Assert.Equal("kurang", stemmer.Stem("mengurangi"));
        Assert.Equal("perintah", stemmer.Stem("pemerintah"));
        Assert.Equal("kabul", stemmer.Stem("mengabulkan"));
        Assert.Equal("kupas", stemmer.Stem("mengupas"));
        Assert.Equal("puruk", stemmer.Stem("keterpurukan"));
        Assert.Equal("temu", stemmer.Stem("ditemukan"));
        Assert.Equal("erti", stemmer.Stem("mengerti"));
        Assert.Equal("kebon", stemmer.Stem("kebon"));
        Assert.Equal("depan", stemmer.Stem("terdepan"));
        Assert.Equal("kikis", stemmer.Stem("mengikis"));
        Assert.Equal("duduk", stemmer.Stem("kedudukan"));
        Assert.Equal("tekan", stemmer.Stem("menekan"));
        Assert.Equal("rusa", stemmer.Stem("perusakan")); // overstemming, it's better than perusa
        Assert.Equal("temu", stemmer.Stem("ditemui"));
        Assert.Equal("di", stemmer.Stem("di"));
        Assert.Equal("kalah", stemmer.Stem("mengalahkan"));
        Assert.Equal("lewat", stemmer.Stem("melewati"));
        Assert.Equal("nafas", stemmer.Stem("bernafas"));
        Assert.Equal("tiru", stemmer.Stem("meniru-niru"));
        Assert.Equal("panggil", stemmer.Stem("memanggil-manggil"));
        Assert.Equal("sebut", stemmer.Stem("menyebut-nyebut"));
        Assert.Equal("nganga", stemmer.Stem("menganga"));
        Assert.Equal("besar", stemmer.Stem("besaran"));
        Assert.Equal("henyak", stemmer.Stem("terhenyak"));
        Assert.Equal("kokoh", stemmer.Stem("mengokohkan"));
        Assert.Equal("lain", stemmer.Stem("melainkan"));
        Assert.Equal("kuasa", stemmer.Stem("kuasa-Mu"));
        Assert.Equal("malaikat", stemmer.Stem("malaikat-malaikat-Nya"));
        Assert.Equal("nikmat", stemmer.Stem("nikmat-Ku"));
    }
}