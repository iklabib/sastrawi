using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule39aTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule39a();
        Assert.Equal("pemain", disambiguator.Disambiguate("pemain"));
    }
}