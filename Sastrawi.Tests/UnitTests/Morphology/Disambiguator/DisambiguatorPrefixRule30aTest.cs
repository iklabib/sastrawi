using Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule30aTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule30a();
        Assert.Equal("alihan", disambiguator.Disambiguate("pengalihan"));
        Assert.Equal("eram", disambiguator.Disambiguate("pengeram"));
        Assert.Equal("ikat", disambiguator.Disambiguate("pengikat"));
        Assert.Equal("obat", disambiguator.Disambiguate("pengobat"));
        Assert.Equal("urusan", disambiguator.Disambiguate("pengurusan"));
    }
}