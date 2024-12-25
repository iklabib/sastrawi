using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule8Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule8();
        Assert.Equal("tangkap", disambiguator.Disambiguate("tertangkap"));
        Assert.Empty(disambiguator.Disambiguate("teracun"));
        Assert.Empty(disambiguator.Disambiguate("terperuk"));
    }
}