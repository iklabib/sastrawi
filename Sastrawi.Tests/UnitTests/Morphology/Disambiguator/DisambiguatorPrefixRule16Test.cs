using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule16Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule16();
        Assert.Equal("gunakan", disambiguator.Disambiguate("menggunakan"));
        Assert.Equal("hambat", disambiguator.Disambiguate("menghambat"));
        Assert.Equal("qasar", disambiguator.Disambiguate("mengqasar"));
        Assert.Equal("kritik", disambiguator.Disambiguate("mengkritik"));

        Assert.Empty(disambiguator.Disambiguate("mengira"));
    }
}