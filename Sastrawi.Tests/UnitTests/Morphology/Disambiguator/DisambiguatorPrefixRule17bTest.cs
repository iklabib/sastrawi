using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule17bTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule17b();
        Assert.Equal("kira", disambiguator.Disambiguate("mengira"));
        Assert.Equal("kecil", disambiguator.Disambiguate("mengecil"));
    }
}