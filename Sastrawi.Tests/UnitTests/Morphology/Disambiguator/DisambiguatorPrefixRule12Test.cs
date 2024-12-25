using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule12Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule12();
        Assert.Equal("pengaruhi", disambiguator.Disambiguate("mempengaruhi"));
        Assert.Equal("perbaharui", disambiguator.Disambiguate("memperbaharui"));

        Assert.Empty(disambiguator.Disambiguate("mewarnai"));
    }
}