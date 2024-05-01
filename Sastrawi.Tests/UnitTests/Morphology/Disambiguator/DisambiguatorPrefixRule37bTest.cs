using Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule37bTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule37b();
        Assert.Equal("gigi", disambiguator.Disambiguate("gerigi"));
        Assert.Equal("sabut", disambiguator.Disambiguate("serabut"));
    }
}