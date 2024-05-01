using Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule20Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule20();
        Assert.Equal("warna", disambiguator.Disambiguate("pewarna"));
        Assert.Equal("yoga", disambiguator.Disambiguate("peyoga"));
    }
}