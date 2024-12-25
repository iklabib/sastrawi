using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule15bTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule15b();
        Assert.Equal("tulis", disambiguator.Disambiguate("menulis"));
        Assert.Equal("tari", disambiguator.Disambiguate("menari"));

        Assert.Empty(disambiguator.Disambiguate("menyayangi"));
    }
}