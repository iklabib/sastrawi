using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule29Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule29();
        Assert.Equal("ganti", disambiguator.Disambiguate("pengganti"));
        Assert.Equal("hajar", disambiguator.Disambiguate("penghajar"));
        Assert.Equal("qasar", disambiguator.Disambiguate("pengqasar"));
    }
}