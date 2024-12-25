using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule19Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule19();
        Assert.Equal("proteksi", disambiguator.Disambiguate("memproteksi"));
        Assert.Equal("patroli", disambiguator.Disambiguate("mempatroli"));
    }
}