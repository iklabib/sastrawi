using Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule11Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule11();
        Assert.Equal("bantu", disambiguator.Disambiguate("membantu"));
        Assert.Equal("fasilitasi", disambiguator.Disambiguate("memfasilitasi"));
        Assert.Equal("vonis", disambiguator.Disambiguate("memvonis"));

        Assert.Null(disambiguator.Disambiguate("mewarnai"));
    }
}