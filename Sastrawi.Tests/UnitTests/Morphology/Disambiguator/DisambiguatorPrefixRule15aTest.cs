using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule15aTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule15a();
        Assert.Equal("nikmati", disambiguator.Disambiguate("menikmati"));
        Assert.Empty(disambiguator.Disambiguate("menyayangi"));
    }
}