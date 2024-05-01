using Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule27Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule27();
        Assert.Equal("cari", disambiguator.Disambiguate("pencari"));
        Assert.Equal("daki", disambiguator.Disambiguate("pendaki"));
        Assert.Equal("jual", disambiguator.Disambiguate("penjual"));
    }
}