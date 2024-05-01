using Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule1aTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule1a();
        Assert.Equal("ia-ia", disambiguator.Disambiguate("beria-ia"));
        Assert.Null(disambiguator.Disambiguate("berlari"));
    }
}