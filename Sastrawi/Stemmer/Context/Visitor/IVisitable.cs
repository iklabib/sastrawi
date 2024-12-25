namespace Sastrawi.Stemmer.Context.Visitor;

public interface IVisitable
{
    public void Accept(IVisitor visitor);
}
