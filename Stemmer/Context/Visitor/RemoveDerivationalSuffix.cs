using System.Text.RegularExpressions;
using Context;

namespace Visitor;

class RemoveDerivationalSuffix : IVisitor
{
    public void Visit(IContext context)
    {
        string result = RemoveSuffix(context.GetCurrentWord());
        if (result == context.GetCurrentWord())
            return;

        Regex regex = new Regex(result);
        string removedPart = regex.Replace(context.GetCurrentWord(), "", 1);
        IRemoval removal = new Removal(this, context.GetCurrentWord(), result, removedPart, "DS");

        context.AddRemoval(removal);
        context.SetCurrentWord(result);
    }

    public string RemoveSuffix(string word)
    {
        Regex regex = new Regex(@"(is|isme|isasi|i|kan|an)$");
        return regex.Replace(word, "", 1);
    }
}
