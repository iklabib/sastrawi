namespace Visitor;

using Context;

public interface IVisitor
{
    public void Visit(IContext context);
}
