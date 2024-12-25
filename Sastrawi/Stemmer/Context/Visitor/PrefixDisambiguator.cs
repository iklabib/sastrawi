using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Stemmer.Context.Visitor;


class PrefixDisambiguator : AbstractDisambiguatePrefixRule, IVisitor
{
    public PrefixDisambiguator(List<IDisambiguator> disambiguators)
    {
        AddDisambiguators(disambiguators);
    }
}
