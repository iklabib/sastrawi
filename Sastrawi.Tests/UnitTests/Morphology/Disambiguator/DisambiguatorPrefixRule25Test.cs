using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule25Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule25();
        Assert.Equal("baruan", disambiguator.Disambiguate("pembaruan"));
        Assert.Equal("fokusan", disambiguator.Disambiguate("pemfokusan"));
        Assert.Equal("vaksinan", disambiguator.Disambiguate("pemvaksinan"));
    }
}