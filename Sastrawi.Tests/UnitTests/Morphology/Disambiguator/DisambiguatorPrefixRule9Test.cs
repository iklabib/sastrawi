using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule9Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule9();
        Assert.Equal("terbang", disambiguator.Disambiguate("teterbang"));
        Assert.Empty(disambiguator.Disambiguate("terperuk"));
    }
}