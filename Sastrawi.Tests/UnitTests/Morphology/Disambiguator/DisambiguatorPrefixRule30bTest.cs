using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule30bTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule30b();
        Assert.Equal("kawal", disambiguator.Disambiguate("pengawal"));
        Assert.Equal("ketat", disambiguator.Disambiguate("pengetat"));
        Assert.Equal("kira", disambiguator.Disambiguate("pengira"));
        Assert.Equal("korban", disambiguator.Disambiguate("pengorban"));
        Assert.Equal("kuat", disambiguator.Disambiguate("penguat"));
    }
}