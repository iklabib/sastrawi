using Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule28bTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule28b();
        Assert.Equal("tari", disambiguator.Disambiguate("penari"));
        Assert.Equal("terap", disambiguator.Disambiguate("penerap"));
        Assert.Equal("tinggalan", disambiguator.Disambiguate("peninggalan"));
        Assert.Equal("tolong", disambiguator.Disambiguate("penolong"));
        Assert.Equal("tulis", disambiguator.Disambiguate("penulis"));
    }
}