using Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule38bTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule38b();
        Assert.Equal("tunjuk", disambiguator.Disambiguate("telunjuk"));
        Assert.Equal("getar", disambiguator.Disambiguate("geletar"));
        Assert.Equal("sidik", disambiguator.Disambiguate("selidik"));
        Assert.Equal("patuk", disambiguator.Disambiguate("pelatuk"));
        Assert.Equal("tapak", disambiguator.Disambiguate("telapak"));
        Assert.Equal("gombang", disambiguator.Disambiguate("gelombang"));
    }
}