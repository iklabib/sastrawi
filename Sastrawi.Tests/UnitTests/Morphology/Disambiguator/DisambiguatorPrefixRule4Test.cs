using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule4Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule4();
        Assert.Equal("ajar", disambiguator.Disambiguate("belajar"));
        Assert.Empty(disambiguator.Disambiguate("bekerja"));
    }
}