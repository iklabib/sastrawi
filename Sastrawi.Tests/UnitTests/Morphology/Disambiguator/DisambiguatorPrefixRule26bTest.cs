using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule26bTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule26b();
        Assert.Equal("pilih", disambiguator.Disambiguate("pemilih"));
        Assert.Equal("pukul", disambiguator.Disambiguate("pemukul"));
    }
}