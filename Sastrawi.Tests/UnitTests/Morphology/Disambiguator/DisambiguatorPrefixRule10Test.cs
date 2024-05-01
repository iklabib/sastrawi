using Xunit;
using Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule10Test
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule10();
        Assert.Equal("lalui", disambiguator.Disambiguate("melalui"));
        Assert.Equal("racuni", disambiguator.Disambiguate("meracuni"));
        Assert.Equal("warnai", disambiguator.Disambiguate("mewarnai"));
        Assert.Equal("yakini", disambiguator.Disambiguate("meyakini"));

        Assert.Null(disambiguator.Disambiguate("menyanyangi"));
    }
}