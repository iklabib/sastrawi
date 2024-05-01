using Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule17cTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule17c();
        Assert.Equal("cas", disambiguator.Disambiguate("mengecas"));
        Assert.Equal("cat", disambiguator.Disambiguate("mengecat"));
    }
}