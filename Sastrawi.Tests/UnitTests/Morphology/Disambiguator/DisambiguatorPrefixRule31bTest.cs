using Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule31bTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule31b();
        Assert.Equal("salut", disambiguator.Disambiguate("penyalut"));
        Assert.Equal("sekat", disambiguator.Disambiguate("penyekat"));
        Assert.Equal("sikat", disambiguator.Disambiguate("penyikat"));
        Assert.Equal("sukat", disambiguator.Disambiguate("penyukat"));
    }
}