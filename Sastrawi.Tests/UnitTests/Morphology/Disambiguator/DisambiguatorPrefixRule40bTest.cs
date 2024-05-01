using Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule40bTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule40b();
        Assert.Equal("kerja", disambiguator.Disambiguate("kinerja"));
        Assert.Equal("sambung", disambiguator.Disambiguate("sinambung"));
        Assert.Equal("tambah", disambiguator.Disambiguate("tinambah"));
    }
}