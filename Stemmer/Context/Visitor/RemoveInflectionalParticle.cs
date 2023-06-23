using Context;
using System.Text.RegularExpressions;

namespace Visitor;

class RemoveInflectionalParticle : IVisitor
{
    public void Visit(IContext context)
    {
        string result = Remove(context.GetCurrentWord());

        if (result != context.GetCurrentWord())
        {
            string removedPart = Regex.Replace(context.GetCurrentWord(), result, " ");
            IRemoval removal = new Removal(
                this, 
                context.GetCurrentWord(),
                result,
                removedPart,
                "P"
            );
            context.AddRemoval(removal);
            context.SetCurrentWord(result);
        }
    }

    public string Remove(string word)
    {
        Regex regex = new Regex(@"-*(lah|kah|tah|pun)$");
        return regex.Replace(word, " ", 1);
    }
}