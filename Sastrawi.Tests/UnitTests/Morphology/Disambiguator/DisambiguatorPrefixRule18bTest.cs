using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule18bTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule18b();
        Assert.Equal("sapu", disambiguator.Disambiguate("menyapu"));
        Assert.Equal("sikat", disambiguator.Disambiguate("menyikat"));
    }
}