using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule36Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule36();
        Assert.Equal("kerja", disambiguator.Disambiguate("pekerja"));
        Assert.Equal("serta", disambiguator.Disambiguate("peserta"));
    }
}