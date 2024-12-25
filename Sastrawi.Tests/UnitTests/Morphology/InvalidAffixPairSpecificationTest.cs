using Sastrawi.Morphology;

namespace Sastrawi.Tests.UnitTests.Morphology;

public class DisambiguatorPrefixRule1aTest
{
    [Fact]
    public void TestContainsInvalidAffixPair()
    {
        var specification = new InvalidAffixPairSpecification();
        Assert.False(specification.IsSatisfiedBy("memberikan"));
        Assert.False(specification.IsSatisfiedBy("ketahui"));

        Assert.True(specification.IsSatisfiedBy("berjatuhi"));
        Assert.True(specification.IsSatisfiedBy("dipukulan"));
        Assert.True(specification.IsSatisfiedBy("ketiduri"));
        Assert.True(specification.IsSatisfiedBy("ketidurkan"));
        Assert.True(specification.IsSatisfiedBy("menduaan"));
        Assert.True(specification.IsSatisfiedBy("terduaan"));
        Assert.True(specification.IsSatisfiedBy("perkataan"));
    }
}