using Context;

namespace Visitor;

class DontStemStopWord : IVisitor
{
    public void Visit(IContext context)
    {
        if (context.GetCurrentWord().Length <= 3)
            context.StopProcess();
    }
}
