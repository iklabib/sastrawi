using System.Text.RegularExpressions;

namespace Morphology;

public class InvalidAffixPairSpecification : ISpecification
{
    public bool IsSatisfiedBy(string word)
    {
        if (Regex.Match(word, @"^me(.*)kan$").Success)
            return false;

        if (word == "ketahui")
            return false;

        string[] invalidAffixes = new String[]
        {
            @"^ber(.*)i$",
            @"^di(.*)an$",
            @"^ke(.*)i$",
            @"^ke(.*)an$",
            @"^me(.*)an$",
            @"^me(.*)an$",
            @"^ter(.*)an$",
            @"^per(.*)an$",
        };

        foreach (string invalidAffix in invalidAffixes)
        {
            if (Regex.Match(word, invalidAffix).Success)
                return true;
        }

        return false;
    }
}
