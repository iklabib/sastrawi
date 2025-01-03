using Sastrawi.Stemmer.Context.Visitor;

namespace Sastrawi.Stemmer.Context;


public interface IRemoval
{
    public IVisitor GetVisitor();

    public string GetSubject();

    public string GetResult();

    public string GetRemovedPart();

    public string GetAffixType();

    public IRemoval Clone();
}
