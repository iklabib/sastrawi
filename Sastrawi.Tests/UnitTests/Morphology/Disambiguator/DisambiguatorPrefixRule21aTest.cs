using Disambiguator;

namespace Sastrawi.Tests.UnitTests.Morphology.Disambiguator;

public class DisambiguatorPrefixRule21aTest
{
    [Fact]
    public void TestDisambiguate()
    {
        var disambiguator = new DisambiguatorPrefixRule21a();
        Assert.Equal("adilan", disambiguator.Disambiguate("peradilan"));
        Assert.Equal("undikan", disambiguator.Disambiguate("perundikan"));
        Assert.Null(disambiguator.Disambiguate("perjudikan"));
    }
}