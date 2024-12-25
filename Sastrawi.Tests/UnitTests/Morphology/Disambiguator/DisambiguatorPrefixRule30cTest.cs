using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule30cTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule30c();
        Assert.Equal("tahuan", disambiguator.Disambiguate("pengetahuan"));
        Assert.Equal("blog", disambiguator.Disambiguate("pengeblog"));
        Assert.Equal("test", disambiguator.Disambiguate("pengetest"));
    }
}