using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule6aTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule6a();
        Assert.Equal("ancam", disambiguator.Disambiguate("terancam"));
        Assert.Empty(disambiguator.Disambiguate("terbalik"));
    }
}