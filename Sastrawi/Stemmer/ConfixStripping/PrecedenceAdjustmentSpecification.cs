using System.Text.RegularExpressions;
using Sastrawi.Specification;

namespace Sastrawi.Stemmer.ConfixStripping;

class PrecedenceAdjustmentSpecification : ISpecification
{
    public bool IsSatisfiedBy(string value)
    {
        var regexRules = new string[]
        {
            "^be(.*)lah$",
            "^be(.*)an$",
            "^me(.*)i$",
            "^di(.*)i$",
            "^pe(.*)i$",
            "^ter(.*)i$",
        };

        foreach (string rule in regexRules)
        {
            if (Regex.Match(value, rule).Success)
                return true;
        }

        return false;
    }
}
