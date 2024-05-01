using Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule32Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule32();
        Assert.Equal("ajar", disambiguator.Disambiguate("pelajar"));
        Assert.Equal("layan", disambiguator.Disambiguate("pelayan"));
        Assert.Equal("ledak", disambiguator.Disambiguate("peledak"));
        Assert.Equal("lirik", disambiguator.Disambiguate("pelirik"));
        Assert.Equal("lobi", disambiguator.Disambiguate("pelobi"));
        Assert.Equal("lupa", disambiguator.Disambiguate("pelupa"));
    }
}