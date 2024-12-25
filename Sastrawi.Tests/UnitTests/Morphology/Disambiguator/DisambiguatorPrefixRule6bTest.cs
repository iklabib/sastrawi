using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule6bTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule6b();
        Assert.Equal("racun", disambiguator.Disambiguate("teracun"));
        Assert.Empty(disambiguator.Disambiguate("terbalik"));
    }
}