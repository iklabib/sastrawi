using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule5Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule5();
        Assert.Equal("kerja", disambiguator.Disambiguate("bekerja"));
        Assert.Empty(disambiguator.Disambiguate("belajar"));
    }
}