using Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule14Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule14();
        Assert.Equal("cantum", disambiguator.Disambiguate("mencantum"));
        Assert.Equal("duduki", disambiguator.Disambiguate("menduduki"));
        Assert.Equal("jemput", disambiguator.Disambiguate("menjemput"));
        Assert.Equal("syukuri", disambiguator.Disambiguate("mensyukuri"));
        Assert.Equal("syaratkan", disambiguator.Disambiguate("mensyaratkan"));
        Assert.Equal("taati", disambiguator.Disambiguate("mentaati"));
        Assert.Equal("ziarahi", disambiguator.Disambiguate("menziarahi"));

        Assert.Null(disambiguator.Disambiguate("menyayangi"));
    }
}