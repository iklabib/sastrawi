using Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule21bTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule21b();
        Assert.Equal("rusak", disambiguator.Disambiguate("perusak"));
        Assert.Equal("rancang", disambiguator.Disambiguate("perancang"));
        Assert.Null(disambiguator.Disambiguate("perjudikan"));
    }
}