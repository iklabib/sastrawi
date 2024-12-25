using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule34Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule34();
        Assert.Equal("tarung", disambiguator.Disambiguate("petarung"));
    }
}