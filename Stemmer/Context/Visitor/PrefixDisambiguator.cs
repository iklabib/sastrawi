using Disambiguator;

namespace Visitor;

class PrefixDisambiguator : AbstractDisambiguatePrefixRule, IVisitor
{
    public PrefixDisambiguator(List<IDisambiguator> disambiguators)
    {
        AddDisambiguators(disambiguators);
    }
}
