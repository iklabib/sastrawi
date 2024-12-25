using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule1bTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule1b();
        Assert.Equal("rakit", disambiguator.Disambiguate("berakit"));
        Assert.Empty(disambiguator.Disambiguate("bertabur"));
    }
}