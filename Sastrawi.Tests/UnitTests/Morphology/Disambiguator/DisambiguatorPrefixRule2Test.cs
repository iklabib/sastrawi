using Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule2Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule2();
        Assert.Equal("tabur", disambiguator.Disambiguate("bertabur"));
        Assert.Null(disambiguator.Disambiguate("beria-ia"));
    }
}