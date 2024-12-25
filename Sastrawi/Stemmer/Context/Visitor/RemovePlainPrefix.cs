using System.Text.RegularExpressions;

namespace Sastrawi.Stemmer.Context.Visitor;

class RemovePlainPrefix : IVisitor
{
    public void Visit(IContext context)
    {
        string result = Remove(context.GetCurrentWord());
        if (result == context.GetCurrentWord())
            return;

        Regex regex = new Regex(result);
        string removedPart = regex.Replace(context.GetCurrentWord(), "", 1);
        IRemoval removal = new Removal(this, context.GetCurrentWord(), result, removedPart, "DP");

        context.AddRemoval(removal);
        context.SetCurrentWord(result);
    }

    public string Remove(string word)
    {
        Regex regex = new Regex(@"^(di|ke|se)");
        return regex.Replace(word, "", 1);
    }
}
