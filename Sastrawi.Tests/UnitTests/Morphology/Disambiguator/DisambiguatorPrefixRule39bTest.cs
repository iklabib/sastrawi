using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule39bTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule39b();
        Assert.Equal("tali", disambiguator.Disambiguate("temali"));
        Assert.Equal("getar", disambiguator.Disambiguate("gemetar"));
        Assert.Equal("guruh", disambiguator.Disambiguate("gemuruh"));
        Assert.Equal("kerlip", disambiguator.Disambiguate("kemerlip"));
        Assert.Equal("kerlap", disambiguator.Disambiguate("kemerlap"));
        Assert.Equal("kelut", disambiguator.Disambiguate("kemelut"));
    }
}