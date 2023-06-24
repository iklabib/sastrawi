namespace Visitor;

public interface IVisitable
{
    public void Accept(IVisitor visitor);
}